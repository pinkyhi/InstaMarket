using InstagramApiSharp.API;
using InstaMarket.DAO;
using InstaMarket.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaMarket.SubForms
{
    public partial class ShopAddSubForm : Form
    {
        IInstaApi instaApi;
        InstaMarketDbContext dbContext;
        Shop shop;

        public ShopAddSubForm(ref InstaMarketDbContext dbContext, ref Shop shop, ref IInstaApi instaApi)
        {
            InitializeComponent();
            this.instaApi = instaApi;
            this.dbContext = dbContext;
            this.shop = shop;
        }

        private async void findAccountButton_Click(object sender, EventArgs e)
        {
            try
            {
                var user = await instaApi.UserProcessor.GetUserAsync(shopAccountNameTextBox.Text);
                if(user.Info.ResponseType!= InstagramApiSharp.Classes.ResponseType.OK)
                {
                    MessageBox.Show(user.Info.Message);
                    return;
                }
                if (user.Value.IsPrivate)
                {
                    MessageBox.Show("Shop can't have private account!");
                    return;
                }
                if (dbContext.Shops.FirstOrDefault(s => s.Shop_Id == user.Value.Pk) == null)
                {
                    ShopConfirmationSubForm shopConfirmationSubForm = new ShopConfirmationSubForm(ref dbContext, user.Value, this);
                    shopConfirmationSubForm.Show();
                }
                else
                {
                    MessageBox.Show("This shop is already attached");
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
