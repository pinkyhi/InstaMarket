using InstagramApiSharp.Classes.Models;
using InstaMarket.DAO;
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
    public partial class ShopConfirmationSubForm : Form
    {
        InstaMarketDbContext dbContext;
        InstaUser shop;
        ShopAddSubForm parentForm;
        public ShopConfirmationSubForm(ref InstaMarketDbContext dbContext, InstaUser shop, ShopAddSubForm parentForm)
        {
            InitializeComponent();
            this.shop = shop;
            this.dbContext = dbContext;
            this.parentForm = parentForm;
            shopPictureBox.ImageLocation = shop.ProfilePicture;
            usernameLabel.Text = shop.UserName;
            fullNameLabel.Text = shop.FullName == null? "" : shop.FullName;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                dbContext.Shops.Add(new Model.Shop { Shop_Id = shop.Pk, Name = shop.UserName, Image=shop.ProfilePicUrl });
                dbContext.SaveChanges();
                MessageBox.Show("OK! Shop is added");
                parentForm.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
