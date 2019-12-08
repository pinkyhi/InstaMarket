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
    public partial class DeliverySubForm : Form
    {
        bool isNewElement;
        InstaMarketDbContext dbContext;
        Delivery delivery;
        public DeliverySubForm(ref InstaMarketDbContext dbContext, ref Delivery delivery, bool isNewElement)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.delivery = delivery;
            this.isNewElement = isNewElement;
            if (!isNewElement)
            {
                deliveryIdLabel.Text += delivery.Delivery_Id;
                deliveryNameTextBox.Text = delivery.Name;
                deliveryCityTextBox.Text = delivery.City;
                deliveryNumberNumericUpDown.Value = delivery.Num;
            }
        }


        private void saveDimensionButton_Click(object sender, EventArgs e)
        {
            delivery.Name = deliveryNameTextBox.Text;
            delivery.City = deliveryCityTextBox.Text;
            delivery.Num = Convert.ToInt32(deliveryNumberNumericUpDown.Value);
            if (isNewElement)
            {
                dbContext.Deliveries.Add(delivery);
            }
            dbContext.SaveChanges();
            this.Close();
        }
    }
}
