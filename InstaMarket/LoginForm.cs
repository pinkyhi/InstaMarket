using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.SessionHandlers;
using InstagramApiSharp.Logger;
using InstaMarket.DAO;
using InstaMarket.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaMarket
{
    public partial class LoginForm : Form
    {
        public static IInstaApi instaApi;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private async void  loginButton_Click(object sender, EventArgs e)
        {
            string username = botPhoneTextBox.Text;
            string password = botPasswordTextBox.Text;

            var userSession = new UserSessionData
            {
                UserName = username,
                Password = password
            };

            instaApi = InstaApiBuilder.CreateBuilder()
                
                .UseLogger(new DebugLogger(LogLevel.All))
                .SetRequestDelay(RequestDelay.FromSeconds(0, 3))
                .SetSessionHandler(new FileSessionHandler() { FilePath = "sessions\\session_"+username+".bin" })
                .SetUser(userSession)
                .Build();
            
            // Load session
            LoadSession();
            if (!instaApi.GetLoggedUser().Password.Equals(password) && instaApi.IsUserAuthenticated)
            {
                MessageBox.Show("Wrong password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (instaApi.IsUserAuthenticated)
            {

                this.Visible = false;
                MainForm mainForm = new MainForm(ref instaApi);
                mainForm.Show();
                //this.Close();
            }
            else
            {
                var logInResult = await instaApi.LoginAsync();
                if (logInResult.Succeeded)
                {
                    SaveSession();
                    this.Visible = false;
                    MainForm mainForm = new MainForm(ref instaApi);
                    mainForm.Show();
                    //this.Close();
                }
                else
                {
                    if (logInResult.Value == InstaLoginResult.ChallengeRequired)
                    {
                        var challenge = await instaApi.GetChallengeRequireVerifyMethodAsync();
                        if (challenge.Succeeded)
                        {
                            if (challenge.Value.SubmitPhoneRequired)
                            {
                                submitPhoneNumberPanel.Enabled = true;
                                submitPhoneNumberPanel.Visible = true;
                            }
                            else
                            {
                                if (challenge.Value.StepData != null)
                                {
                                    if (!string.IsNullOrEmpty(challenge.Value.StepData.PhoneNumber))
                                    {
                                        phoneChallengeRadio.Checked = false;
                                        phoneChallengeRadio.Visible = true;
                                        phoneChallengeRadio.Text = challenge.Value.StepData.PhoneNumber;
                                    }
                                    if (!string.IsNullOrEmpty(challenge.Value.StepData.Email))
                                    {
                                        emailChallengeRadio.Checked = false;
                                        emailChallengeRadio.Visible = true;
                                        emailChallengeRadio.Text = challenge.Value.StepData.Email;
                                    }
                                    challengeRequiredPanel.Enabled = true;
                                    challengeRequiredPanel.Visible = true;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show(challenge.Info.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    // Two factor is required
                    else if (logInResult.Value == InstaLoginResult.TwoFactorRequired)
                    {
                        // Open a panel so user can send two factor code
                        twoFAPanel.Visible = true;
                        twoFAPanel.Enabled = true;
                        loginPanel.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(logInResult.Value.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
                
        }

        private async void sendTowFACodeButton_Click(object sender, EventArgs e)
        {
            if (instaApi == null)
            {
                return;
            }

            if (string.IsNullOrEmpty(twoFATextBox.Text))
            {
                MessageBox.Show("Write your code in the text box");
                return;
            }

            // Send two factor code
            var twoFactorLogin = await instaApi.TwoFactorLoginAsync(twoFATextBox.Text);
            if (twoFactorLogin.Succeeded)
            {
                // Connected
                // Save session
                SaveSession();

                this.Visible = false;
                MainForm mainForm = new MainForm(ref instaApi);
                mainForm.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show(twoFactorLogin.Info.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadSession()
        {
            instaApi?.SessionHandler?.Load();
        }
        void SaveSession()
        {
            if (instaApi == null)
                return;
            if (!instaApi.IsUserAuthenticated)
                return;
            try
            {
                instaApi.SessionHandler.Save();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backToLoginPanel(object sender, EventArgs e)
        {
            twoFAPanel.Visible = false;
            twoFAPanel.Enabled = false;
            challengeRequiredPanel.Visible = false;
            challengeRequiredPanel.Enabled = false;
            submitPhoneNumberPanel.Visible = false;
            submitPhoneNumberPanel.Enabled = false;
            smsEmailCodePanel.Visible = false;
            smsEmailCodePanel.Enabled = false;
            loginPanel.Enabled = true;
        }

        private async void sendChallengeCodeButton_Click(object sender, EventArgs e)
        {
            bool isEmail = false;
            if (emailChallengeRadio.Checked)
            {
                isEmail = true;
            }
            //if (RadioVerifyWithPhoneNumber.Checked)
            //    isEmail = false;

            try
            {
                // Note: every request to this endpoint is limited to 60 seconds                 
                if (isEmail)
                {
                    // Send verification code to email
                    var email = await instaApi.RequestVerifyCodeToEmailForChallengeRequireAsync();
                    if (email.Succeeded)
                    {
                        MessageBox.Show($"We sent verify code to this email:\n{email.Value.StepData.ContactPoint}");
                        smsEmailCodePanel.Enabled = true;
                        smsEmailCodePanel.Visible = true;
                        challengeRequiredPanel.Visible = false;
                        challengeRequiredPanel.Enabled = false;

                    }
                    else
                        MessageBox.Show(email.Info.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Send verification code to phone number
                    var phoneNumber = await instaApi.RequestVerifyCodeToSMSForChallengeRequireAsync();
                    if (phoneNumber.Succeeded)
                    {
                        MessageBox.Show($"We sent verify code to this phone number(it's end with this):\n{phoneNumber.Value.StepData.ContactPoint}");
                        smsEmailCodePanel.Enabled = true;
                        smsEmailCodePanel.Visible = true;
                        challengeRequiredPanel.Visible = false;
                        challengeRequiredPanel.Enabled = false;
                    }
                    else
                        MessageBox.Show(phoneNumber.Info.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "EX", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void submitPhoneButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(submitPhoneTextBox.Text) ||
                     string.IsNullOrWhiteSpace(submitPhoneTextBox.Text))
                {
                    MessageBox.Show("Please type a valid phone number(with country code).\r\ni.e: +380996664422", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var phoneNumber = submitPhoneTextBox.Text;
                if (!phoneNumber.StartsWith("+"))
                    phoneNumber = $"+{phoneNumber}";

                var submitPhone = await instaApi.SubmitPhoneNumberForChallengeRequireAsync(phoneNumber);
                if (submitPhone.Succeeded)
                {
                    smsEmailCodePanel.Enabled = true;
                    smsEmailCodePanel.Visible = true;
                    submitPhoneNumberPanel.Enabled = false;
                    submitPhoneNumberPanel.Visible = false;
                }
                else
                    MessageBox.Show(submitPhone.Info.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "EX", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void resendSmsEmailCodeButon_Click(object sender, EventArgs e)
        {
            bool isEmail = false;
            if (emailChallengeRadio.Checked)
            {
                isEmail = true;
            }

            try
            {
                // Note: every request to this endpoint is limited to 60 seconds                 
                if (isEmail)
                {
                    // Send verification code to email
                    var email = await instaApi.RequestVerifyCodeToEmailForChallengeRequireAsync(replayChallenge: true);
                    if (email.Succeeded)
                    {
                        MessageBox.Show($"We sent verification code one more time\r\nto this email:\n{email.Value.StepData.ContactPoint}");
                        smsEmailCodePanel.Enabled = true;
                        smsEmailCodePanel.Visible = true;
                        challengeRequiredPanel.Visible = false;
                        challengeRequiredPanel.Enabled = false;
                    }
                    else
                        MessageBox.Show(email.Info.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Send verification code to phone number
                    var phoneNumber = await instaApi.RequestVerifyCodeToSMSForChallengeRequireAsync(replayChallenge: true);
                    if (phoneNumber.Succeeded)
                    {
                        MessageBox.Show($"We sent verification code one more time\r\nto this phone number(it's end with this):{phoneNumber.Value.StepData.ContactPoint}");
                        smsEmailCodePanel.Enabled = true;
                        smsEmailCodePanel.Visible = true;
                        challengeRequiredPanel.Visible = false;
                        challengeRequiredPanel.Enabled = false;
                    }
                    else
                        MessageBox.Show(phoneNumber.Info.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "EX", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void verifySmsEmailCode_Click(object sender, EventArgs e)
        {
            smsEmailCodeTextBox.Text = smsEmailCodeTextBox.Text.Trim();
            smsEmailCodeTextBox.Text = smsEmailCodeTextBox.Text.Replace(" ", "");
            var regex = new Regex(@"^-*[0-9,\.]+$");
            if (!regex.IsMatch(smsEmailCodeTextBox.Text))
            {
                MessageBox.Show("Verification code is numeric!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (smsEmailCodeTextBox.Text.Length != 6)
            {
                MessageBox.Show("Verification code must be 6 digits!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Note: calling VerifyCodeForChallengeRequireAsync function, 
                // if user has two factor enabled, will wait 15 seconds and it will try to
                // call LoginAsync.

                var verifyLogin = await instaApi.VerifyCodeForChallengeRequireAsync(smsEmailCodeTextBox.Text);
                if (verifyLogin.Succeeded)
                {
                    // You are logged in sucessfully.

                    smsEmailCodePanel.Enabled = challengeRequiredPanel.Enabled = false;
                    smsEmailCodePanel.Visible = challengeRequiredPanel.Visible = false;
                    // Save session
                    SaveSession();

                    this.Visible = false;
                    MainForm mainForm = new MainForm(ref instaApi);
                    mainForm.Show();
                    //this.Close();

                }
                else
                {
                    smsEmailCodePanel.Enabled = challengeRequiredPanel.Enabled = false;
                    smsEmailCodePanel.Visible = challengeRequiredPanel.Visible = false;
                    // Two factor is required
                    if (verifyLogin.Value == InstaLoginResult.TwoFactorRequired)
                    {
                        twoFAPanel.Enabled = true;
                        twoFAPanel.Visible = true;
                    }
                    else
                        MessageBox.Show(verifyLogin.Info.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "EX", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
