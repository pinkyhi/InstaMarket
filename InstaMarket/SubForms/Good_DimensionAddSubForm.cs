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
    public partial class Good_DimensionAddSubForm : Form
    {
        InstaMarketDbContext dbContext;
        public Good_DimensionAddSubForm(ref InstaMarketDbContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            vendorDimensionsDataGridView.DataSource = dbContext.Dimensions.Local.ToBindingList();
            vendorGoodsDataGridView.DataSource = dbContext.Goods.Local.ToBindingList();
        }

        private void boundVendorCodesButton_Click(object sender, EventArgs e)
        {
            var dimensionsRows = vendorDimensionsDataGridView.SelectedRows;
            var goodsRows = vendorGoodsDataGridView.SelectedRows;
            for(int i = 0; i < dimensionsRows.Count; i++)
            {
                for (int j = 0; j < goodsRows.Count; j++)
                {
                    Good tg = (Good)goodsRows[j].DataBoundItem;
                    Dimension td = (Dimension)dimensionsRows[i].DataBoundItem;
                    if (dbContext.Good_Dimensions.FirstOrDefault(gd=>gd.Good_Id==tg.Good_Id && gd.Dimension_Id == td.Dimension_Id) == null)
                    {
                        dbContext.Good_Dimensions.Add(new Good_Dimension { Good_Id = tg.Good_Id, Dimension_Id = td.Dimension_Id, Price = 9999999, Available = 0 });
                    }
                }
            }
            dbContext.SaveChanges();
            this.Close();
        }
    }
}
