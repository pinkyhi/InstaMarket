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
    public partial class GoodSubForm : Form
    {
        bool isNewElement;
        InstaMarketDbContext dbContext;
        Good good;
        public GoodSubForm(ref InstaMarketDbContext dbContext, ref Good good, bool isNewElement)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.good = good;
            this.isNewElement = isNewElement;
            if (!isNewElement)
            {
                goodIdLabel.Text += good.Good_Id;
                descriptionRichTextBox.Text = good.Description==null ? "" : good.Description;
                goodNameTextBox.Text = good.Name;
            }
        }

        private void saveGoodButton_Click(object sender, EventArgs e)
        {
            good.Description = descriptionRichTextBox.Text;
            good.Name = goodNameTextBox.Text;
            if (isNewElement)
            {
                dbContext.Goods.Add(good);
            }
            dbContext.SaveChanges();
            this.Close();
        }
    }
}
