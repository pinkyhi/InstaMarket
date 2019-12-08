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
    public partial class DimensionSubForm : Form
    {
        bool isNewElement;
        InstaMarketDbContext dbContext;
        Dimension dimension;
        public DimensionSubForm(ref InstaMarketDbContext dbContext, ref Dimension dimension, bool isNewElement)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.dimension = dimension;
            this.isNewElement = isNewElement;
            if (!isNewElement)
            {
                dimensionIdLabel.Text += dimension.Dimension_Id;
                dimensionMeasureTextBox.Text = dimension.Measure == null ? "" : dimension.Measure;
                dimensionAmountTextBox.Text = dimension.Amount;
            }
        }

        private void saveDimensionButton_Click(object sender, EventArgs e)
        {
            dimension.Measure = dimensionMeasureTextBox.Text;
            dimension.Amount = dimensionAmountTextBox.Text;
            if (isNewElement)
            {
                dbContext.Dimensions.Add(dimension);
            }
            dbContext.SaveChanges();
            this.Close();
        }
    }
}
