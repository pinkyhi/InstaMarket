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
    public partial class GoodDimensionEditSubForm : Form
    {
        InstaMarketDbContext dbContext;
        Good_Dimension good_dimension;
        public GoodDimensionEditSubForm(ref InstaMarketDbContext dbContext, ref Good_Dimension good_dimension)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.good_dimension = good_dimension;

            goodDimensionIdLabel.Text += good_dimension.Good_Dimension_Id;
            goodIdLabel.Text += good_dimension.Good_Id;
            goodLabel.Text += good_dimension.Good.ToString();
            dimensionIdLabel.Text += good_dimension.Dimension_Id;
            dimensionLabel.Text += good_dimension.Dimension.ToString();
            priceNumericUpDown.Value = good_dimension.Price;
            amountNumericUpDown.Value = good_dimension.Available;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            good_dimension.Available = Convert.ToInt32(amountNumericUpDown.Value);
            good_dimension.Price = priceNumericUpDown.Value;
            dbContext.SaveChanges();
            this.Close();
        }
    }
}
