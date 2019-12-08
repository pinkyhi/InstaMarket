namespace InstaMarket
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botPhoneTextBox = new System.Windows.Forms.TextBox();
            this.botNameLabel = new System.Windows.Forms.Label();
            this.botPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.twoFALabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.twoFAPanel = new System.Windows.Forms.Panel();
            this.backFromTwoFAButton = new System.Windows.Forms.Button();
            this.authTwoFAButton = new System.Windows.Forms.Button();
            this.twoFATextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.challengeRequiredPanel = new System.Windows.Forms.Panel();
            this.phoneChallengeRadio = new System.Windows.Forms.RadioButton();
            this.emailChallengeRadio = new System.Windows.Forms.RadioButton();
            this.backFromChallengeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sendChallengeCodeButton = new System.Windows.Forms.Button();
            this.submitPhoneNumberPanel = new System.Windows.Forms.Panel();
            this.backFromSubmitPhoneButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.submitPhoneButton = new System.Windows.Forms.Button();
            this.submitPhoneTextBox = new System.Windows.Forms.TextBox();
            this.smsEmailCodePanel = new System.Windows.Forms.Panel();
            this.backFromSmsEmailCode = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.resendSmsEmailCodeButon = new System.Windows.Forms.Button();
            this.verifySmsEmailCode = new System.Windows.Forms.Button();
            this.smsEmailCodeTextBox = new System.Windows.Forms.TextBox();
            this.loginPanel.SuspendLayout();
            this.twoFAPanel.SuspendLayout();
            this.challengeRequiredPanel.SuspendLayout();
            this.submitPhoneNumberPanel.SuspendLayout();
            this.smsEmailCodePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // botPhoneTextBox
            // 
            this.botPhoneTextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.botPhoneTextBox.Location = new System.Drawing.Point(138, 9);
            this.botPhoneTextBox.Name = "botPhoneTextBox";
            this.botPhoneTextBox.Size = new System.Drawing.Size(201, 32);
            this.botPhoneTextBox.TabIndex = 0;
            this.botPhoneTextBox.Text = "+380932647971";
            // 
            // botNameLabel
            // 
            this.botNameLabel.AutoSize = true;
            this.botNameLabel.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botNameLabel.Location = new System.Drawing.Point(18, 12);
            this.botNameLabel.Name = "botNameLabel";
            this.botNameLabel.Size = new System.Drawing.Size(114, 29);
            this.botNameLabel.TabIndex = 1;
            this.botNameLabel.Text = "BotName";
            // 
            // botPasswordTextBox
            // 
            this.botPasswordTextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.botPasswordTextBox.Location = new System.Drawing.Point(138, 47);
            this.botPasswordTextBox.Name = "botPasswordTextBox";
            this.botPasswordTextBox.Size = new System.Drawing.Size(201, 32);
            this.botPasswordTextBox.TabIndex = 1;
            this.botPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "BotName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // twoFALabel
            // 
            this.twoFALabel.AutoSize = true;
            this.twoFALabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.twoFALabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoFALabel.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoFALabel.Location = new System.Drawing.Point(23, 5);
            this.twoFALabel.Name = "twoFALabel";
            this.twoFALabel.Size = new System.Drawing.Size(235, 31);
            this.twoFALabel.TabIndex = 1;
            this.twoFALabel.Text = "2FA Authorization";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.Location = new System.Drawing.Point(138, 85);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(201, 32);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.botNameLabel);
            this.loginPanel.Controls.Add(this.botPasswordTextBox);
            this.loginPanel.Controls.Add(this.botPhoneTextBox);
            this.loginPanel.Location = new System.Drawing.Point(55, 169);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(357, 175);
            this.loginPanel.TabIndex = 3;
            // 
            // twoFAPanel
            // 
            this.twoFAPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoFAPanel.Controls.Add(this.backFromTwoFAButton);
            this.twoFAPanel.Controls.Add(this.twoFALabel);
            this.twoFAPanel.Controls.Add(this.authTwoFAButton);
            this.twoFAPanel.Controls.Add(this.twoFATextBox);
            this.twoFAPanel.Enabled = false;
            this.twoFAPanel.Location = new System.Drawing.Point(420, 169);
            this.twoFAPanel.Name = "twoFAPanel";
            this.twoFAPanel.Size = new System.Drawing.Size(284, 174);
            this.twoFAPanel.TabIndex = 4;
            this.twoFAPanel.Visible = false;
            // 
            // backFromTwoFAButton
            // 
            this.backFromTwoFAButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.backFromTwoFAButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backFromTwoFAButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backFromTwoFAButton.Location = new System.Drawing.Point(42, 122);
            this.backFromTwoFAButton.Name = "backFromTwoFAButton";
            this.backFromTwoFAButton.Size = new System.Drawing.Size(201, 25);
            this.backFromTwoFAButton.TabIndex = 2;
            this.backFromTwoFAButton.Text = "Back";
            this.backFromTwoFAButton.UseVisualStyleBackColor = false;
            this.backFromTwoFAButton.Click += new System.EventHandler(this.backToLoginPanel);
            // 
            // authTwoFAButton
            // 
            this.authTwoFAButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.authTwoFAButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.authTwoFAButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authTwoFAButton.Location = new System.Drawing.Point(42, 84);
            this.authTwoFAButton.Name = "authTwoFAButton";
            this.authTwoFAButton.Size = new System.Drawing.Size(201, 32);
            this.authTwoFAButton.TabIndex = 2;
            this.authTwoFAButton.Text = "Auth";
            this.authTwoFAButton.UseVisualStyleBackColor = false;
            this.authTwoFAButton.Click += new System.EventHandler(this.sendTowFACodeButton_Click);
            // 
            // twoFATextBox
            // 
            this.twoFATextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoFATextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.twoFATextBox.Location = new System.Drawing.Point(39, 46);
            this.twoFATextBox.Name = "twoFATextBox";
            this.twoFATextBox.Size = new System.Drawing.Size(208, 32);
            this.twoFATextBox.TabIndex = 0;
            this.twoFATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.GreenYellow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 32);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.label3.Size = new System.Drawing.Size(488, 100);
            this.label3.TabIndex = 5;
            this.label3.Text = "InstaMarket   ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGreen;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(468, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 53);
            this.label4.TabIndex = 6;
            this.label4.Text = "bot";
            // 
            // challengeRequiredPanel
            // 
            this.challengeRequiredPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.challengeRequiredPanel.Controls.Add(this.phoneChallengeRadio);
            this.challengeRequiredPanel.Controls.Add(this.emailChallengeRadio);
            this.challengeRequiredPanel.Controls.Add(this.backFromChallengeButton);
            this.challengeRequiredPanel.Controls.Add(this.label5);
            this.challengeRequiredPanel.Controls.Add(this.sendChallengeCodeButton);
            this.challengeRequiredPanel.Enabled = false;
            this.challengeRequiredPanel.Location = new System.Drawing.Point(420, 169);
            this.challengeRequiredPanel.Name = "challengeRequiredPanel";
            this.challengeRequiredPanel.Size = new System.Drawing.Size(284, 174);
            this.challengeRequiredPanel.TabIndex = 4;
            this.challengeRequiredPanel.Visible = false;
            // 
            // phoneChallengeRadio
            // 
            this.phoneChallengeRadio.AutoSize = true;
            this.phoneChallengeRadio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneChallengeRadio.Location = new System.Drawing.Point(42, 64);
            this.phoneChallengeRadio.Name = "phoneChallengeRadio";
            this.phoneChallengeRadio.Size = new System.Drawing.Size(89, 22);
            this.phoneChallengeRadio.TabIndex = 3;
            this.phoneChallengeRadio.TabStop = true;
            this.phoneChallengeRadio.Text = "To phone";
            this.phoneChallengeRadio.UseVisualStyleBackColor = true;
            this.phoneChallengeRadio.Visible = false;
            // 
            // emailChallengeRadio
            // 
            this.emailChallengeRadio.AutoSize = true;
            this.emailChallengeRadio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailChallengeRadio.Location = new System.Drawing.Point(42, 39);
            this.emailChallengeRadio.Name = "emailChallengeRadio";
            this.emailChallengeRadio.Size = new System.Drawing.Size(84, 22);
            this.emailChallengeRadio.TabIndex = 3;
            this.emailChallengeRadio.TabStop = true;
            this.emailChallengeRadio.Text = "To email";
            this.emailChallengeRadio.UseVisualStyleBackColor = true;
            this.emailChallengeRadio.Visible = false;
            // 
            // backFromChallengeButton
            // 
            this.backFromChallengeButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.backFromChallengeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backFromChallengeButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backFromChallengeButton.Location = new System.Drawing.Point(42, 128);
            this.backFromChallengeButton.Name = "backFromChallengeButton";
            this.backFromChallengeButton.Size = new System.Drawing.Size(201, 25);
            this.backFromChallengeButton.TabIndex = 2;
            this.backFromChallengeButton.Text = "Back";
            this.backFromChallengeButton.UseVisualStyleBackColor = false;
            this.backFromChallengeButton.Click += new System.EventHandler(this.backToLoginPanel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Send verification to";
            // 
            // sendChallengeCodeButton
            // 
            this.sendChallengeCodeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sendChallengeCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendChallengeCodeButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendChallengeCodeButton.Location = new System.Drawing.Point(42, 90);
            this.sendChallengeCodeButton.Name = "sendChallengeCodeButton";
            this.sendChallengeCodeButton.Size = new System.Drawing.Size(201, 32);
            this.sendChallengeCodeButton.TabIndex = 2;
            this.sendChallengeCodeButton.Text = "Send Code";
            this.sendChallengeCodeButton.UseVisualStyleBackColor = false;
            this.sendChallengeCodeButton.Click += new System.EventHandler(this.sendChallengeCodeButton_Click);
            // 
            // submitPhoneNumberPanel
            // 
            this.submitPhoneNumberPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.submitPhoneNumberPanel.Controls.Add(this.backFromSubmitPhoneButton);
            this.submitPhoneNumberPanel.Controls.Add(this.label6);
            this.submitPhoneNumberPanel.Controls.Add(this.submitPhoneButton);
            this.submitPhoneNumberPanel.Controls.Add(this.submitPhoneTextBox);
            this.submitPhoneNumberPanel.Enabled = false;
            this.submitPhoneNumberPanel.Location = new System.Drawing.Point(420, 169);
            this.submitPhoneNumberPanel.Name = "submitPhoneNumberPanel";
            this.submitPhoneNumberPanel.Size = new System.Drawing.Size(284, 174);
            this.submitPhoneNumberPanel.TabIndex = 4;
            this.submitPhoneNumberPanel.Visible = false;
            // 
            // backFromSubmitPhoneButton
            // 
            this.backFromSubmitPhoneButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.backFromSubmitPhoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backFromSubmitPhoneButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backFromSubmitPhoneButton.Location = new System.Drawing.Point(42, 122);
            this.backFromSubmitPhoneButton.Name = "backFromSubmitPhoneButton";
            this.backFromSubmitPhoneButton.Size = new System.Drawing.Size(201, 25);
            this.backFromSubmitPhoneButton.TabIndex = 2;
            this.backFromSubmitPhoneButton.Text = "Back";
            this.backFromSubmitPhoneButton.UseVisualStyleBackColor = false;
            this.backFromSubmitPhoneButton.Click += new System.EventHandler(this.backToLoginPanel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "Submit phone number";
            // 
            // submitPhoneButton
            // 
            this.submitPhoneButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.submitPhoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitPhoneButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitPhoneButton.Location = new System.Drawing.Point(34, 84);
            this.submitPhoneButton.Name = "submitPhoneButton";
            this.submitPhoneButton.Size = new System.Drawing.Size(222, 32);
            this.submitPhoneButton.TabIndex = 2;
            this.submitPhoneButton.Text = "Submit and send code";
            this.submitPhoneButton.UseVisualStyleBackColor = false;
            this.submitPhoneButton.Click += new System.EventHandler(this.submitPhoneButton_Click);
            // 
            // submitPhoneTextBox
            // 
            this.submitPhoneTextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitPhoneTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.submitPhoneTextBox.Location = new System.Drawing.Point(18, 46);
            this.submitPhoneTextBox.Name = "submitPhoneTextBox";
            this.submitPhoneTextBox.Size = new System.Drawing.Size(249, 32);
            this.submitPhoneTextBox.TabIndex = 0;
            // 
            // smsEmailCodePanel
            // 
            this.smsEmailCodePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smsEmailCodePanel.Controls.Add(this.backFromSmsEmailCode);
            this.smsEmailCodePanel.Controls.Add(this.label7);
            this.smsEmailCodePanel.Controls.Add(this.resendSmsEmailCodeButon);
            this.smsEmailCodePanel.Controls.Add(this.verifySmsEmailCode);
            this.smsEmailCodePanel.Controls.Add(this.smsEmailCodeTextBox);
            this.smsEmailCodePanel.Enabled = false;
            this.smsEmailCodePanel.Location = new System.Drawing.Point(420, 169);
            this.smsEmailCodePanel.Name = "smsEmailCodePanel";
            this.smsEmailCodePanel.Size = new System.Drawing.Size(284, 174);
            this.smsEmailCodePanel.TabIndex = 4;
            this.smsEmailCodePanel.Visible = false;
            // 
            // backFromSmsEmailCode
            // 
            this.backFromSmsEmailCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.backFromSmsEmailCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backFromSmsEmailCode.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backFromSmsEmailCode.Location = new System.Drawing.Point(42, 122);
            this.backFromSmsEmailCode.Name = "backFromSmsEmailCode";
            this.backFromSmsEmailCode.Size = new System.Drawing.Size(201, 25);
            this.backFromSmsEmailCode.TabIndex = 2;
            this.backFromSmsEmailCode.Text = "Back";
            this.backFromSmsEmailCode.UseVisualStyleBackColor = false;
            this.backFromSmsEmailCode.Click += new System.EventHandler(this.backToLoginPanel);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Code from sms/email";
            // 
            // resendSmsEmailCodeButon
            // 
            this.resendSmsEmailCodeButon.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.resendSmsEmailCodeButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resendSmsEmailCodeButon.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resendSmsEmailCodeButon.Location = new System.Drawing.Point(40, 84);
            this.resendSmsEmailCodeButon.Name = "resendSmsEmailCodeButon";
            this.resendSmsEmailCodeButon.Size = new System.Drawing.Size(100, 32);
            this.resendSmsEmailCodeButon.TabIndex = 2;
            this.resendSmsEmailCodeButon.Text = "Resend";
            this.resendSmsEmailCodeButon.UseVisualStyleBackColor = false;
            this.resendSmsEmailCodeButon.Click += new System.EventHandler(this.resendSmsEmailCodeButon_Click);
            // 
            // verifySmsEmailCode
            // 
            this.verifySmsEmailCode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.verifySmsEmailCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.verifySmsEmailCode.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.verifySmsEmailCode.Location = new System.Drawing.Point(145, 84);
            this.verifySmsEmailCode.Name = "verifySmsEmailCode";
            this.verifySmsEmailCode.Size = new System.Drawing.Size(100, 32);
            this.verifySmsEmailCode.TabIndex = 2;
            this.verifySmsEmailCode.Text = "Verify";
            this.verifySmsEmailCode.UseVisualStyleBackColor = false;
            this.verifySmsEmailCode.Click += new System.EventHandler(this.verifySmsEmailCode_Click);
            // 
            // smsEmailCodeTextBox
            // 
            this.smsEmailCodeTextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smsEmailCodeTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.smsEmailCodeTextBox.Location = new System.Drawing.Point(38, 46);
            this.smsEmailCodeTextBox.Name = "smsEmailCodeTextBox";
            this.smsEmailCodeTextBox.Size = new System.Drawing.Size(209, 32);
            this.smsEmailCodeTextBox.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(745, 408);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.smsEmailCodePanel);
            this.Controls.Add(this.submitPhoneNumberPanel);
            this.Controls.Add(this.challengeRequiredPanel);
            this.Controls.Add(this.twoFAPanel);
            this.Controls.Add(this.loginPanel);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.twoFAPanel.ResumeLayout(false);
            this.twoFAPanel.PerformLayout();
            this.challengeRequiredPanel.ResumeLayout(false);
            this.challengeRequiredPanel.PerformLayout();
            this.submitPhoneNumberPanel.ResumeLayout(false);
            this.submitPhoneNumberPanel.PerformLayout();
            this.smsEmailCodePanel.ResumeLayout(false);
            this.smsEmailCodePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox botPhoneTextBox;
        private System.Windows.Forms.Label botNameLabel;
        private System.Windows.Forms.TextBox botPasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label twoFALabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel twoFAPanel;
        private System.Windows.Forms.Button authTwoFAButton;
        private System.Windows.Forms.TextBox twoFATextBox;
        private System.Windows.Forms.Button backFromTwoFAButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel challengeRequiredPanel;
        private System.Windows.Forms.RadioButton phoneChallengeRadio;
        private System.Windows.Forms.RadioButton emailChallengeRadio;
        private System.Windows.Forms.Button backFromChallengeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sendChallengeCodeButton;
        private System.Windows.Forms.Panel submitPhoneNumberPanel;
        private System.Windows.Forms.Button backFromSubmitPhoneButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submitPhoneButton;
        private System.Windows.Forms.TextBox submitPhoneTextBox;
        private System.Windows.Forms.Panel smsEmailCodePanel;
        private System.Windows.Forms.Button backFromSmsEmailCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button verifySmsEmailCode;
        private System.Windows.Forms.TextBox smsEmailCodeTextBox;
        private System.Windows.Forms.Button resendSmsEmailCodeButon;
    }
}