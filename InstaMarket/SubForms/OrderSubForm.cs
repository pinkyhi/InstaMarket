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
    public partial class OrderSubForm : Form
    {
        bool isNewElement;
        InstaMarketDbContext dbContext;
        Order order;
        List<ReceiptChange> changes;
        public OrderSubForm(ref InstaMarketDbContext dbContext, ref Order order, bool isNewElement)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.isNewElement = isNewElement;
            this.dbContext = dbContext;
            this.order = order;

            changes = new List<ReceiptChange>();
            
            dateLabel.Text += " "+order.Date;
            fullPriceLabel.Text = "Full price: " + order.Receipts.Sum(o => o.Position_Price);
            receiptsDataGridView.DataSource = new BindingList<Receipt>(order.Receipts);

            deliveryLabel.Text += order.Delivery == null ? "" : order.Delivery.ToString();

            orderStatusComboBox.DataSource = dbContext.Order_Statuses.Local.ToBindingList();

            orderDeliveryDataGridView.DataSource = dbContext.Deliveries.Local.ToBindingList();
            orderDeliveryDataGridView.Columns["Delivery_Id"].Visible = false;

            if (order.User != null)
            {
                usernameTextBox.Text = order.User.User_Name;
                usernameTextBox.Enabled = false;
            }

            if (order.Email != null)
            {
                emailTextBox.Text = order.Email;
            }
            if (!isNewElement)
            {
                orderIdLabel.Text += order.Order_Id;
                lastNameTextBox.Text = order.Last_Name;
                nameTextBox.Text = order.First_Name;
                phoneTextBox.Text = order.Phone_Number;
                orderStatusComboBox.SelectedItem = order.Order_Status;
            }
            receiptsDataGridView.Columns["Order"].Visible = false;
            receiptsDataGridView.Columns["Order_Id"].Visible = false;

        }

        private void selectDeliveryButton_Click(object sender, EventArgs e)
        {
            order.Delivery = (Delivery)orderDeliveryDataGridView.SelectedRows[0].DataBoundItem;
            deliveryLabel.Text = "Delivery: " + order.Delivery.ToString();
        }

        public void addNewReceipt(int gdid)
        {
            int good_dimension_id = gdid;
            Good_Dimension good_Dimension = dbContext.Good_Dimensions.Find(good_dimension_id);
            if (good_Dimension == null)
            {
                MessageBox.Show("Any vendor code matches!");
                return;
            }
            if (good_Dimension.Available < 1)
            {
                MessageBox.Show("Available only " + good_Dimension.Available + " units\n with this vendor code");
                return;
            }
            if (order.Receipts.Where(r => r.Good_Dimension_Id == good_dimension_id).Count() == 0)
            {
                good_Dimension.Available -= Convert.ToInt32(addVendorCodeCountNumericUpDown.Value);     // DBCONTEXT CHANGING
                changes.Add(new ReceiptChange(good_Dimension.Good_Dimension_Id, Convert.ToInt32(addVendorCodeCountNumericUpDown.Value), true));
                order.Receipts.Add(new Receipt { Good_Dimension_Id = good_dimension_id, Good_Dimension = good_Dimension, Amount = Convert.ToInt32(addVendorCodeCountNumericUpDown.Value), Order = order, Position_Price = good_Dimension.Price * addVendorCodeCountNumericUpDown.Value });
            }
            else
            {
                good_Dimension.Available -= Convert.ToInt32(addVendorCodeCountNumericUpDown.Value);     // DBCONTEXT CHANGING
                changes.Add(new ReceiptChange(good_Dimension.Good_Dimension_Id, Convert.ToInt32(addVendorCodeCountNumericUpDown.Value), true));
                Receipt receipt = order.Receipts.Where(r => r.Good_Dimension_Id == good_dimension_id).ToList()[0];
                receipt.Amount += Convert.ToInt32(addVendorCodeCountNumericUpDown.Value);
                receipt.Position_Price = good_Dimension.Price * receipt.Amount;
                // TODO: Deleting overflowed vendor codes with canceling
            }
            fullPriceLabel.Text = "Full price: " + order.Receipts.Sum(o => o.Position_Price);
            receiptsDataGridView.DataSource = new BindingList<Receipt>(order.Receipts);
        }
        private void addVendorCodeInCount_Click(object sender, EventArgs e)
        {
            int good_dimension_id = 0;
            try
            {
                good_dimension_id = Convert.ToInt32(vendorCodeTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Wrong vendor code format!");
                return;
            }
            Good_Dimension good_Dimension = dbContext.Good_Dimensions.Find(good_dimension_id);
            if (good_Dimension == null)
            {
                MessageBox.Show("Any vendor code matches!");
                return;
            }
            if (good_Dimension.Available < addVendorCodeCountNumericUpDown.Value)
            {
                MessageBox.Show("Available only " + good_Dimension.Available + " units\n with this vendor code");
                return;
            }
            if (order.Receipts.Where(r => r.Good_Dimension_Id == good_dimension_id).Count() == 0)
            {
                good_Dimension.Available -= Convert.ToInt32(addVendorCodeCountNumericUpDown.Value);     // DBCONTEXT CHANGING
                changes.Add(new ReceiptChange(good_Dimension.Good_Dimension_Id, Convert.ToInt32(addVendorCodeCountNumericUpDown.Value), true));
                order.Receipts.Add(new Receipt { Good_Dimension_Id = good_dimension_id, Good_Dimension = good_Dimension, Amount = Convert.ToInt32(addVendorCodeCountNumericUpDown.Value), Order = order, Position_Price = good_Dimension.Price * addVendorCodeCountNumericUpDown.Value });
            }
            else
            {
                good_Dimension.Available -= Convert.ToInt32(addVendorCodeCountNumericUpDown.Value);     // DBCONTEXT CHANGING
                changes.Add(new ReceiptChange(good_Dimension.Good_Dimension_Id, Convert.ToInt32(addVendorCodeCountNumericUpDown.Value), true));
                Receipt receipt = order.Receipts.Where(r => r.Good_Dimension_Id == good_dimension_id).ToList()[0];
                receipt.Amount += Convert.ToInt32(addVendorCodeCountNumericUpDown.Value);
                receipt.Position_Price = good_Dimension.Price * receipt.Amount;
                // TODO: Deleting overflowed vendor codes with canceling
            }
            fullPriceLabel.Text = "Full price: " + order.Receipts.Sum(o => o.Position_Price);
            receiptsDataGridView.DataSource = new BindingList<Receipt>(order.Receipts);
        }

        private void removeVendoreCodeInCount_Click(object sender, EventArgs e)
        {
            int good_dimension_id = 0;
            try
            {
                good_dimension_id = Convert.ToInt32(vendorCodeTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Wrong vendor code format!");
                return;
            }
            if (order.Receipts.Where(r => r.Good_Dimension_Id == good_dimension_id).Count() == 0)
            {
                MessageBox.Show("In this order is no units with such vendor code");
                return;
            }

            Receipt receipt = order.Receipts.Where(r => r.Good_Dimension_Id == good_dimension_id).ToList()[0];
            if (receipt.Amount < removeVendorCodeCountNumericUpDown.Value)
            {
                removeVendorCodeCountNumericUpDown.Value = receipt.Amount;
            }
            receipt.Amount -= Convert.ToInt32(removeVendorCodeCountNumericUpDown.Value);
            dbContext.Good_Dimensions.Find(receipt.Good_Dimension_Id).Available += Convert.ToInt32(removeVendorCodeCountNumericUpDown.Value);       // DBCONTEXT CHANGING
            changes.Add(new ReceiptChange(receipt.Good_Dimension_Id, Convert.ToInt32(removeVendorCodeCountNumericUpDown.Value), false));
            receipt.Position_Price = receipt.Good_Dimension.Price * receipt.Amount;

            if (receipt.Amount == 0)
            {
                order.Receipts.Remove(receipt);
            }

            fullPriceLabel.Text = "Full price: " + order.Receipts.Sum(o => o.Position_Price);
            receiptsDataGridView.DataSource = new BindingList<Receipt>(order.Receipts);
        }

        private void saveOrderButton_Click(object sender, EventArgs e)
        {
            
            order.Last_Name = lastNameTextBox.Text;
            order.First_Name = nameTextBox.Text;
            order.Phone_Number = phoneTextBox.Text;
            order.Email = emailTextBox.Text == null ? "" : emailTextBox.Text;
            order.Order_Status = (Order_Status)orderStatusComboBox.SelectedItem;
            order.Full_Price = order.Receipts.Sum(o => o.Position_Price);

            if(!order.Last_Name.Equals("") && !order.First_Name.Equals("") && !order.Phone_Number.Equals("") && order.Order_Status!=null && order.Delivery != null && order.Receipts!=null&& order.Receipts.Count!=0)
            {
                if (isNewElement)
                {
                    dbContext.Orders.Add(order);
                }
                try
                {
                    dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Close();

            }
            else
            {
                MessageBox.Show("You should to fill all required field.\nThey stay with '*'");
            }
        }

        private void canelOrderButton_Click(object sender, EventArgs e)
        {
            foreach(ReceiptChange rc in changes)
            {
                if (rc.Add)
                {
                    if (this.order.Receipts.FirstOrDefault(r => r.Good_Dimension_Id == rc.VendorCode).Amount == rc.Amount)
                    {
                        this.order.Receipts.Remove(this.order.Receipts.FirstOrDefault(r => r.Good_Dimension_Id == rc.VendorCode));
                    }
                    else
                    {
                        this.order.Receipts.FirstOrDefault(r => r.Good_Dimension_Id == rc.VendorCode).Amount -= rc.Amount;
                    }
                    dbContext.Good_Dimensions.Find(rc.VendorCode).Available += rc.Amount;
                }
                else
                {
                    
                    if (this.order.Receipts.FirstOrDefault(r => r.Good_Dimension_Id == rc.VendorCode) == null)
                    {
                        this.order.Receipts.Add(new Receipt { Order_Id = this.order.Order_Id, Good_Dimension_Id = rc.VendorCode, Amount = rc.Amount, Position_Price = rc.Amount * dbContext.Good_Dimensions.Find(rc.VendorCode).Price });
                    }
                    else
                    {
                        this.order.Receipts.FirstOrDefault(r => r.Good_Dimension_Id == rc.VendorCode).Amount += rc.Amount;
                    }
                    
                    dbContext.Good_Dimensions.Find(rc.VendorCode).Available -= rc.Amount;
                }
            }
            this.Close();
        }

        private void removeOrderButton_Click(object sender, EventArgs e)
        {
            foreach (Receipt r in order.Receipts)
            {
                try
                {
                    dbContext.Good_Dimensions.Find(r.Good_Dimension_Id).Available += r.Amount;
                }
                catch { MessageBox.Show("Trouble with recover available items for unit\nVendor code: " + r.Good_Dimension_Id); }    // No DB problems cathching
            }
            dbContext.Orders.Remove(order);
        }
    }
    class ReceiptChange
    {
        public ReceiptChange(int vendorCode, int amount, bool add)
        {
            VendorCode = vendorCode;
            Amount = amount;
            Add = add;
        }
        public int VendorCode { get; set; }
        public int Amount { get; set; }
        public bool Add { get; set; }
    }
}
