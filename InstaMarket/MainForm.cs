using InstagramApiSharp;
using InstagramApiSharp.API;
using InstagramApiSharp.Classes.Models;
using InstaMarket.DAO;
using InstaMarket.SubForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaMarket
{
    public partial class MainForm : Form
    {
        public IInstaApi instaApi;

        public static InstaMarketDbContext dbContext;


        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(ref IInstaApi InstaApi)
        {
            InitializeComponent();
            instaApi = InstaApi;
            dbContext = new InstaMarketDbContext();

            List<Model.Good> goods = dbContext.Goods.ToList();
            List<Model.Dimension> dimensions = dbContext.Dimensions.ToList();
            List<Model.Good_Dimension> good_Dimensions = dbContext.Good_Dimensions.ToList();
            List<Model.Good_Dimension_Publication> good_Dimension_Publications = dbContext.Good_Dimension_Publications.ToList();
            List<Model.Shop> shops = dbContext.Shops.ToList();
            List<Model.Publication> publications = dbContext.Publications.ToList();
            List<Model.Order> orders = dbContext.Orders.ToList();
            List<Model.Order_Status> order_Statuses = dbContext.Order_Statuses.ToList();
            List<Model.Receipt> receipts = dbContext.Receipts.ToList();
            List<Model.Delivery> deliveries = dbContext.Deliveries.ToList();
            List<Model.Publication_Image> publication_Images = dbContext.Publication_Images.ToList();
            List<Model.Publication_Video> publication_Videos = dbContext.Publication_Videos.ToList();
            List<Model.Chat> chats = dbContext.Chats.ToList();
            List<Model.Chat_Status> chat_Statuses = dbContext.Chat_Statuses.ToList();
            List<Model.User> users = dbContext.Users.ToList();
            List<Model.Comment> comments = dbContext.Comments.ToList();

            // Order panel
            var orderStatuses = dbContext.Order_Statuses.ToList();
            orderStatuses.Add(new Model.Order_Status { Order_Status_Id = 0, Name = "All" });
            orderPanelOrderStatusComboBox.DataSource = orderStatuses;
            orderPanelOrderStatusComboBox.SelectedItem = orderStatuses.First(os => os.Order_Status_Id == 0);

            // Publication panel
            publicationComboBox.SelectedIndex = 0;






        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            tableNameLable.Text = "Goods";
            goodBindingSource.DataSource = dbContext.Goods.Local.ToBindingList();
            mainFormGridView.DataSource = goodBindingSource;
            mainBindingNavigator.BindingSource = goodBindingSource;    // Init DataSource


            //var desireUsername = "pinky_hi";
            //var userDir = await instaApi.UserProcessor.GetUserAsync(desireUsername);
            //var result = await instaApi.DiscoverProcessor.GetRecentSearchesAsync();
            //var collections = await instaApi.CollectionProcessor.GetCollectionsAsync(InstagramApiSharp.PaginationParameters.MaxPagesToLoad(5));
            //Console.WriteLine($"Loaded {collections.Value.Items.Count} collections for current user");
            //var userId = userDir.Value.Pk.ToString();
            //var directText = await InstaApi.MessagingProcessor.ShareMediaToUserAsync("2079143941534031054", InstaMediaType.Image, null, userDir.Value.Pk);     
            //var userMedias = await instaApi.UserProcessor
             //.GetUserMediaAsync("pinky_hi", PaginationParameters.MaxPagesToLoad(6));
            //var commentResult = await instaApi.CommentProcessor.GetMediaCommentsAsync("1682037438706437460", PaginationParameters.MaxPagesToLoad(5));
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void goodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewOrderFromSelectedVendorCodesButton.Visible = false;
            publicationPanel.Visible = false;
            orderPanel.Visible = false;
            goodDimensionPanel.Visible = false;
            bindingNavigatorDeleteItem.Visible = true;
            bindingNavigatorOrderDeleteButton.Visible = false;
            indexNewPublicationsToolStripMenuItem.Visible = false;
            addToolStripMenuItem.Visible = true;
            editToolStripMenuItem.Visible = true;
            dbContext.SaveChanges();
            tableNameLable.Text = "Goods";
            goodBindingSource.DataSource = dbContext.Goods.Local.ToBindingList();
            mainFormGridView.DataSource = goodBindingSource;
            mainBindingNavigator.BindingSource = goodBindingSource;
        }

        private void dimensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewOrderFromSelectedVendorCodesButton.Visible = false;
            publicationPanel.Visible = false;
            orderPanel.Visible = false;
            goodDimensionPanel.Visible = false;
            bindingNavigatorDeleteItem.Visible = true;
            bindingNavigatorOrderDeleteButton.Visible = false;
            indexNewPublicationsToolStripMenuItem.Visible = false;
            addToolStripMenuItem.Visible = true;
            editToolStripMenuItem.Visible = true;
            dbContext.SaveChanges();
            tableNameLable.Text = "Dimensions";
            dimensionBindingSource.DataSource = dbContext.Dimensions.Local.ToBindingList();
            mainFormGridView.DataSource = dimensionBindingSource;
            mainBindingNavigator.BindingSource = dimensionBindingSource;
        }

        private void vendorCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewOrderFromSelectedVendorCodesButton.Visible = true;
            publicationPanel.Visible = false;
            orderPanel.Visible = false;
            goodDimensionPanel.Visible = true;
            bindingNavigatorDeleteItem.Visible = true;
            bindingNavigatorOrderDeleteButton.Visible = false;
            indexNewPublicationsToolStripMenuItem.Visible = false;
            addToolStripMenuItem.Visible = true;
            editToolStripMenuItem.Visible = true;
            dbContext.SaveChanges();
            tableNameLable.Text = "Vendor codes";
            goodDimensionBindingSource.DataSource = dbContext.Good_Dimensions.Local.ToBindingList();
            mainFormGridView.DataSource = goodDimensionBindingSource;
            mainBindingNavigator.BindingSource = goodDimensionBindingSource;
        }

        private void shopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewOrderFromSelectedVendorCodesButton.Visible = false;
            publicationPanel.Visible = false;
            orderPanel.Visible = false;
            goodDimensionPanel.Visible = false;
            bindingNavigatorDeleteItem.Visible = true;
            bindingNavigatorOrderDeleteButton.Visible = false;
            indexNewPublicationsToolStripMenuItem.Visible = false;
            addToolStripMenuItem.Visible = true;
            editToolStripMenuItem.Visible = false;
            dbContext.SaveChanges();
            tableNameLable.Text = "Shops";
            shopBindingSource.DataSource = dbContext.Shops.Local.ToBindingList();
            mainFormGridView.DataSource = shopBindingSource;
            mainFormGridView.Columns["Image"].Visible = false;
            mainBindingNavigator.BindingSource = shopBindingSource;
        }

        private void publicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewOrderFromSelectedVendorCodesButton.Visible = false;
            publicationPanel.Visible = true;
            orderPanel.Visible = false;
            goodDimensionPanel.Visible = false;
            bindingNavigatorDeleteItem.Visible = true;
            bindingNavigatorOrderDeleteButton.Visible = false;
            indexNewPublicationsToolStripMenuItem.Visible = true;
            addToolStripMenuItem.Visible = false;
            editToolStripMenuItem.Visible = true;
            dbContext.SaveChanges();
            tableNameLable.Text = "Publications";
            publicationBindingSource.DataSource = dbContext.Publications.Local.ToBindingList();
            mainFormGridView.DataSource = publicationBindingSource;
            mainBindingNavigator.BindingSource = publicationBindingSource;
        }

        private void deliveriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewOrderFromSelectedVendorCodesButton.Visible = false;
            publicationPanel.Visible = false;
            orderPanel.Visible = false;
            goodDimensionPanel.Visible = false;
            bindingNavigatorDeleteItem.Visible = true;
            bindingNavigatorOrderDeleteButton.Visible = false;
            indexNewPublicationsToolStripMenuItem.Visible = false;
            addToolStripMenuItem.Visible = true;
            editToolStripMenuItem.Visible = true;
            dbContext.SaveChanges();
            tableNameLable.Text = "Deliveries";
            deliveryBindingSource.DataSource = dbContext.Deliveries.Local.ToBindingList();
            mainFormGridView.DataSource = deliveryBindingSource;
            mainBindingNavigator.BindingSource = deliveryBindingSource;
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewOrderFromSelectedVendorCodesButton.Visible = false;
            publicationPanel.Visible = false;
            orderPanel.Visible = true;
            goodDimensionPanel.Visible = false;
            bindingNavigatorDeleteItem.Visible = false;
            bindingNavigatorOrderDeleteButton.Visible = true;
            indexNewPublicationsToolStripMenuItem.Visible = false;
            addToolStripMenuItem.Visible = true;
            editToolStripMenuItem.Visible = true;
            dbContext.SaveChanges();
            tableNameLable.Text = "Orders";
            orderBindingSource.DataSource = dbContext.Orders.Local.ToBindingList();
            mainFormGridView.DataSource = orderBindingSource;
            mainBindingNavigator.BindingSource = orderBindingSource;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tableNameLable.Text.Equals("Goods"))
            {
                Model.Good good = new Model.Good();
                GoodSubForm goodSubForm = new GoodSubForm(ref dbContext, ref good, true);
                goodSubForm.Show();
            }
            else if (tableNameLable.Text.Equals("Dimensions"))
            {
                Model.Dimension dimension = new Model.Dimension();
                DimensionSubForm dimensionSubForm = new DimensionSubForm(ref dbContext, ref dimension, true);
                dimensionSubForm.Show();
            }
            else if (tableNameLable.Text.Equals("Vendor codes"))
            {
                Good_DimensionAddSubForm good_DimensionAddSubForm = new Good_DimensionAddSubForm(ref dbContext);
                good_DimensionAddSubForm.Show();
            }
            else if (tableNameLable.Text.Equals("Shops"))
            {
                Model.Shop shop = new Model.Shop();
                ShopAddSubForm shopSubForm = new ShopAddSubForm(ref dbContext, ref shop, ref instaApi);
                shopSubForm.Show();
            }
            else if (tableNameLable.Text.Equals("Deliveries"))
            {
                Model.Delivery delivery = new Model.Delivery();
                DeliverySubForm deliverySubForm = new DeliverySubForm(ref dbContext, ref delivery, true);
                deliverySubForm.Show();
            }
            else if (tableNameLable.Text.Equals("Orders"))
            {
                Model.Order order = new Model.Order { Receipts = new List<Model.Receipt>(), Date = DateTime.Now };
                OrderSubForm orderSubForm = new OrderSubForm(ref dbContext, ref order, true);
                orderSubForm.Show();
            }
        }
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
        }

        private async void indexNewPublicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tableNameLable.Text.Equals("Publications"))
            {
                List<Model.Shop> shops = dbContext.Shops.ToList();

                foreach (Model.Shop shop in shops)
                {
                    var userMedias = await instaApi.UserProcessor
                     .GetUserMediaAsync(shop.Name, PaginationParameters.MaxPagesToLoad(100));       // Max posts to load
                    var userPosts = userMedias.Value;
                    foreach (var post in userPosts)
                    {
                        if (dbContext.Publications.FirstOrDefault(p => p.Publication_Id.Equals(post.Pk)) == null)
                        {
                            Model.Publication publicationToAdd = new Model.Publication { Publication_Id = post.Pk, Publication_Images = new List<Model.Publication_Image>(), Publication_Videos = new List<Model.Publication_Video>(), Date = post.TakenAt, Shop_Id = shop.Shop_Id };
                            if (post.MediaType == InstagramApiSharp.Classes.Models.InstaMediaType.Carousel)
                            {
                                foreach (var media in post.Carousel)
                                {
                                    if (media.MediaType == InstagramApiSharp.Classes.Models.InstaMediaType.Image)
                                    {
                                        publicationToAdd.Publication_Images.Add(new Model.Publication_Image { Path = media.Images[0].Uri, Publication_Id = publicationToAdd.Publication_Id });
                                    }
                                    else if (media.MediaType == InstagramApiSharp.Classes.Models.InstaMediaType.Video)
                                    {
                                        publicationToAdd.Publication_Videos.Add(new Model.Publication_Video { Path = media.Videos[0].Uri, Publication_Id = publicationToAdd.Publication_Id });
                                    }
                                }
                            }
                            else if (post.MediaType == InstagramApiSharp.Classes.Models.InstaMediaType.Image)
                            {
                                publicationToAdd.Publication_Images.Add(new Model.Publication_Image { Path = post.Images[0].Uri, Publication_Id = publicationToAdd.Publication_Id });
                            }
                            else if (post.MediaType == InstagramApiSharp.Classes.Models.InstaMediaType.Video)
                            {
                                publicationToAdd.Publication_Videos.Add(new Model.Publication_Video { Path = post.Videos[0].Uri, Publication_Id = publicationToAdd.Publication_Id });
                            }
                            dbContext.Publications.Add(publicationToAdd);
                        }
                        else
                        {
                            continue;
                        }

                    }

                    dbContext.SaveChanges();
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tableNameLable.Text.Equals("Goods"))
            {
                Model.Good good = mainFormGridView.SelectedRows.Count == 0 ? null : (Model.Good)mainFormGridView.SelectedRows[0].DataBoundItem;
                if (good == null)
                {
                    MessageBox.Show("You should to select at least one row");
                }
                else
                {
                    GoodSubForm goodSubForm = new GoodSubForm(ref dbContext, ref good, false);
                    goodSubForm.Show();
                }
            }
            else if (tableNameLable.Text.Equals("Dimensions"))
            {
                Model.Dimension dimension = mainFormGridView.SelectedRows.Count == 0 ? null : (Model.Dimension)mainFormGridView.SelectedRows[0].DataBoundItem;
                if (dimension == null)
                {
                    MessageBox.Show("You should to select at least one row");
                }
                else
                {
                    DimensionSubForm dimensionSubForm = new DimensionSubForm(ref dbContext, ref dimension, false);
                    dimensionSubForm.Show();
                }
            }
            else if (tableNameLable.Text.Equals("Vendor codes"))
            {
                Model.Good_Dimension good_dimension = mainFormGridView.SelectedRows.Count == 0 ? null : (Model.Good_Dimension)mainFormGridView.SelectedRows[0].DataBoundItem;
                if (good_dimension == null)
                {
                    MessageBox.Show("You should to select at least one row");
                }
                else
                {
                    GoodDimensionEditSubForm good_dimensionSubForm = new GoodDimensionEditSubForm(ref dbContext, ref good_dimension);
                    good_dimensionSubForm.Show();
                }
            }
            else if (tableNameLable.Text.Equals("Publications"))
            {
                Model.Publication publication = mainFormGridView.SelectedRows.Count == 0 ? null : (Model.Publication)mainFormGridView.SelectedRows[0].DataBoundItem;
                if (publication == null)
                {
                    MessageBox.Show("You should to select at least one row");
                }
                else
                {
                    PublicationSubForm publicationSubForm = new PublicationSubForm(ref dbContext, ref publication);
                    publicationSubForm.Show();
                }
            }
            else if (tableNameLable.Text.Equals("Deliveries"))
            {
                Model.Delivery delivery = mainFormGridView.SelectedRows.Count == 0 ? null : (Model.Delivery)mainFormGridView.SelectedRows[0].DataBoundItem;
                if (delivery == null)
                {
                    MessageBox.Show("You should to select at least one row");
                }
                else
                {
                    DeliverySubForm deliverySubForm = new DeliverySubForm(ref dbContext, ref delivery, false);
                    deliverySubForm.Show();
                }
            }
            else if (tableNameLable.Text.Equals("Orders"))
            {
                Model.Order order = mainFormGridView.SelectedRows.Count == 0 ? null : (Model.Order)mainFormGridView.SelectedRows[0].DataBoundItem;
                if (order == null)
                {
                    MessageBox.Show("You should to select at least one row");
                }
                else
                {
                    OrderSubForm orderSubForm = new OrderSubForm(ref dbContext, ref order, false);
                    orderSubForm.Show();
                }
            }
        }

        private void bindingNavigatorOrderDeleteButton_Click(object sender, EventArgs e)
        {
            if (tableNameLable.Text.Equals("Orders"))
            {
                Model.Order order = mainFormGridView.SelectedRows.Count == 0 ? null : (Model.Order)mainFormGridView.SelectedRows[0].DataBoundItem;
                if (order == null)
                {
                    MessageBox.Show("You should to select at least one row");
                    return;
                }
                else
                {
                    foreach (Model.Receipt r in order.Receipts)
                    {
                        try
                        {
                            dbContext.Good_Dimensions.Find(r.Good_Dimension_Id).Available += r.Amount;
                        }
                        catch { MessageBox.Show("Trouble with recover available items for unit\nVendor code: " + r.Good_Dimension_Id); }    // No DB problems cathching
                    }

                }

                dbContext.Orders.Remove(order);
                dbContext.SaveChanges();
            }

        }

        private void voluntarySqlRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VoluntarySqlRequestForm form = new VoluntarySqlRequestForm();
            form.Show();
        }

        private void salesStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveReportFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                // Получаем выбранный файл
                string writePath = saveReportFileDialog.FileName;
                string text = "            SALES FOR EACH DAY REPORT\n________________________________________________\n\n";


                var writeParts = dbContext.Orders.OrderBy(o => o.Date)
                    .GroupBy(o => o.Date.Date)
                    .Select(go => new
                    {
                        Date = go.Key,
                        Count = go.Count(),
                        Sum = go.Sum(x => Convert.ToInt32(x.Full_Price))
                    });




                foreach (var part in writeParts)
                {
                    text += part.Date + ":\n " + "    Count: " + part.Count + "\n     FullPrice=" + part.Sum + "\n";
                }
                text += "\n\nDate of report: " + DateTime.Now;

                try
                {
                    using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        // Searchs and filtering
        //
        // Good_Dimension

        private void goodDimensionPanelChanging(object sender, EventArgs e)
        {
            if (goodDimensionSearchTextBox.Text != null && !goodDimensionSearchTextBox.Text.Equals(""))
            {
                if (goodDimensionByGoodNameRadio.Checked)
                {
                    if (putOnPriceFiltering.Checked == true)
                    {
                        goodDimensionBindingSource.DataSource = dbContext.Good_Dimensions.Local.ToBindingList().Where(gd => gd.Good.Name.ToLower().Contains(goodDimensionSearchTextBox.Text.ToLower())).Where(gd => gd.Price >= fromPriceFilteringNumeric.Value && gd.Price <= toPriceFilteringNumeric.Value);
                        mainFormGridView.DataSource = goodDimensionBindingSource;
                        mainBindingNavigator.BindingSource = goodDimensionBindingSource;
                    }
                    else
                    {
                        goodDimensionBindingSource.DataSource = dbContext.Good_Dimensions.Local.ToBindingList().Where(gd => gd.Good.Name.ToLower().Contains(goodDimensionSearchTextBox.Text.ToLower()));
                        mainFormGridView.DataSource = goodDimensionBindingSource;
                        mainBindingNavigator.BindingSource = goodDimensionBindingSource;
                    }
                }
                else if (goodDimensionByDimensionNameRadio.Checked)
                {
                    if (putOnPriceFiltering.Checked == true)
                    {
                        goodDimensionBindingSource.DataSource = dbContext.Good_Dimensions.Local.ToBindingList().Where(gd => gd.Dimension.Amount.ToLower().Contains(goodDimensionSearchTextBox.Text.ToLower())).Where(gd => gd.Price >= fromPriceFilteringNumeric.Value && gd.Price <= toPriceFilteringNumeric.Value);
                        mainFormGridView.DataSource = goodDimensionBindingSource;
                        mainBindingNavigator.BindingSource = goodDimensionBindingSource;
                    }
                    else
                    {
                        goodDimensionBindingSource.DataSource = dbContext.Good_Dimensions.Local.ToBindingList().Where(gd => gd.Dimension.Amount.ToLower().Contains(goodDimensionSearchTextBox.Text.ToLower()));
                        mainFormGridView.DataSource = goodDimensionBindingSource;
                        mainBindingNavigator.BindingSource = goodDimensionBindingSource;
                    }
                }
                else if (goodDimensionByVendorCodeRadio.Checked)
                {
                    if (putOnPriceFiltering.Checked == true)
                    {
                        goodDimensionBindingSource.DataSource = dbContext.Good_Dimensions.Local.ToBindingList().Where(gd => gd.Good_Dimension_Id.ToString().Contains(goodDimensionSearchTextBox.Text)).Where(gd => gd.Price >= fromPriceFilteringNumeric.Value && gd.Price <= toPriceFilteringNumeric.Value);
                        mainFormGridView.DataSource = goodDimensionBindingSource;
                        mainBindingNavigator.BindingSource = goodDimensionBindingSource;
                    }
                    else
                    {
                        goodDimensionBindingSource.DataSource = dbContext.Good_Dimensions.Local.ToBindingList().Where(gd => gd.Good_Dimension_Id.ToString().Contains(goodDimensionSearchTextBox.Text));
                        mainFormGridView.DataSource = goodDimensionBindingSource;
                        mainBindingNavigator.BindingSource = goodDimensionBindingSource;
                    }
                }
            }
            else
            {
                if (putOnPriceFiltering.Checked == true)
                {
                    goodDimensionBindingSource.DataSource = dbContext.Good_Dimensions.Local.ToBindingList().Where(gd=>gd.Price>=fromPriceFilteringNumeric.Value && gd.Price<= toPriceFilteringNumeric.Value);
                    mainFormGridView.DataSource = goodDimensionBindingSource;
                    mainBindingNavigator.BindingSource = goodDimensionBindingSource;
                }
                else
                {
                    goodDimensionBindingSource.DataSource = dbContext.Good_Dimensions.Local.ToBindingList();
                    mainFormGridView.DataSource = goodDimensionBindingSource;
                    mainBindingNavigator.BindingSource = goodDimensionBindingSource;
                }
            }
        }


        // Order panel

        private void orderPanelChanging(object sender, EventArgs e)
        {
            if (((Model.Order_Status)orderPanelOrderStatusComboBox.SelectedItem).Order_Status_Id != 0)
            {
                if (orderSearchTextBox.Text != null && !orderSearchTextBox.Text.Equals(""))
                {
                    if (orderByEmailRadio.Checked)
                    {
                        orderBindingSource.DataSource = dbContext.Orders.Local.ToBindingList().Where(o => o.Order_Status_Id == ((Model.Order_Status)orderPanelOrderStatusComboBox.SelectedItem).Order_Status_Id).Where(o => o.Email == null ? false : o.Email.ToLower().Contains(orderSearchTextBox.Text.ToLower()));
                    }
                    else if (orderByPhoneRadio.Checked)
                    {
                        orderBindingSource.DataSource = dbContext.Orders.Local.ToBindingList().Where(o => o.Order_Status_Id == ((Model.Order_Status)orderPanelOrderStatusComboBox.SelectedItem).Order_Status_Id).Where(o => o.Phone_Number.Contains(orderSearchTextBox.Text));
                    }
                    else if (orderByUsernameRadio.Checked)
                    {
                        orderBindingSource.DataSource = dbContext.Orders.Local.ToBindingList().Where(o => o.Order_Status_Id == ((Model.Order_Status)orderPanelOrderStatusComboBox.SelectedItem).Order_Status_Id).Where(o => o.User == null ? false : o.User.User_Name.ToLower().Contains(orderSearchTextBox.Text.ToLower()));
                    }
                }
                else
                {
                    orderBindingSource.DataSource = dbContext.Orders.Local.ToBindingList().Where(o => o.Order_Status_Id == ((Model.Order_Status)orderPanelOrderStatusComboBox.SelectedItem).Order_Status_Id);
                }
            }
            else
            {
                if (orderSearchTextBox.Text != null && !orderSearchTextBox.Text.Equals(""))
                {
                    if (orderByEmailRadio.Checked)
                    {
                        orderBindingSource.DataSource = dbContext.Orders.Local.ToBindingList().Where(o => o.Email == null ? false : o.Email.ToLower().Contains(orderSearchTextBox.Text.ToLower()));
                    }
                    else if (orderByPhoneRadio.Checked)
                    {
                        orderBindingSource.DataSource = dbContext.Orders.Local.ToBindingList().Where(o => o.Phone_Number.Contains(orderSearchTextBox.Text));
                    }
                    else if (orderByUsernameRadio.Checked)
                    {
                        orderBindingSource.DataSource = dbContext.Orders.Local.ToBindingList().Where(o => o.User == null ? false : o.User.User_Name.ToLower().Contains(orderSearchTextBox.Text.ToLower()));
                    }
                }
                else
                {
                    orderBindingSource.DataSource = dbContext.Orders.Local.ToBindingList();
                }
            }

            mainFormGridView.DataSource = orderBindingSource;
            mainBindingNavigator.BindingSource = orderBindingSource;
        }


        // Publication panel
        private void publicationPanelChanging(object sender, EventArgs e)
        {
            if (!publicationComboBox.SelectedItem.Equals("All"))
            {
                if (publicationSearchTextBox.Text != null && !publicationSearchTextBox.Text.Equals(""))
                {
                    if (publicationByShopRadio.Checked)
                    {
                        if (publicationComboBox.SelectedIndex == 1)
                        {
                            publicationBindingSource.DataSource = dbContext.Publications.Local.ToBindingList().Where(p => p.Good_Dimension_Publications != null && p.Good_Dimension_Publications.Count > 0).Where(p => p.Shop.Name == null ? false : p.Shop.Name.ToLower().Contains(publicationSearchTextBox.Text.ToLower()));
                        }
                        else if (publicationComboBox.SelectedIndex == 2)
                        {
                            publicationBindingSource.DataSource = dbContext.Publications.Local.ToBindingList().Where(p => p.Good_Dimension_Publications == null || p.Good_Dimension_Publications.Count == 0).Where(p => p.Shop.Name == null ? false : p.Shop.Name.ToLower().Contains(publicationSearchTextBox.Text.ToLower()));
                        }
                    }
                    else if (publicationByVendorCodeRadio.Checked)
                    {
                        if (publicationComboBox.SelectedIndex == 1)
                        {
                            publicationBindingSource.DataSource = dbContext.Publications.Local.ToBindingList().Where(p => p.Good_Dimension_Publications != null && p.Good_Dimension_Publications.Count > 0).Where(p => p.Good_Dimension_Publications == null ? false : (p.Good_Dimension_Publications.FirstOrDefault(gdp => gdp.Good_Dimension.ToString().ToLower().Contains(publicationSearchTextBox.Text.ToLower())) != null || p.Good_Dimension_Publications.FirstOrDefault(gdp => gdp.Good_Dimension_Id.ToString().ToLower().Contains(publicationSearchTextBox.Text.ToLower())) != null));
                        }
                        else if (publicationComboBox.SelectedIndex == 2)
                        {
                            publicationBindingSource.DataSource = dbContext.Publications.Local.ToBindingList().Where(p => p.Good_Dimension_Publications == null || p.Good_Dimension_Publications.Count == 0).Where(p => p.Good_Dimension_Publications == null ? false : (p.Good_Dimension_Publications.FirstOrDefault(gdp => gdp.Good_Dimension.ToString().ToLower().Contains(publicationSearchTextBox.Text.ToLower())) != null || p.Good_Dimension_Publications.FirstOrDefault(gdp => gdp.Good_Dimension_Id.ToString().ToLower().Contains(publicationSearchTextBox.Text.ToLower())) != null));
                        }
                    }
                }
                else
                {
                    if (publicationComboBox.SelectedIndex == 1)
                    {
                        publicationBindingSource.DataSource = dbContext.Publications.Local.ToBindingList().Where(p => p.Good_Dimension_Publications != null && p.Good_Dimension_Publications.Count > 0);
                    }
                    else if (publicationComboBox.SelectedIndex == 2)
                    {
                        publicationBindingSource.DataSource = dbContext.Publications.Local.ToBindingList().Where(p => p.Good_Dimension_Publications == null || p.Good_Dimension_Publications.Count == 0);
                    }
                }
            }
            else
            {
                if (publicationSearchTextBox.Text != null && !publicationSearchTextBox.Text.Equals(""))
                {
                    if (publicationByShopRadio.Checked)
                    {
                        publicationBindingSource.DataSource = dbContext.Publications.Local.ToBindingList().Where(p => p.Shop.Name == null ? false : p.Shop.Name.ToLower().Contains(publicationSearchTextBox.Text.ToLower()));
                    }
                    else if (publicationByVendorCodeRadio.Checked)
                    {
                        publicationBindingSource.DataSource = dbContext.Publications.Local.ToBindingList().Where(p => p.Good_Dimension_Publications == null ? false : (p.Good_Dimension_Publications.FirstOrDefault(gdp => gdp.Good_Dimension.ToString().ToLower().Contains(publicationSearchTextBox.Text.ToLower())) != null || p.Good_Dimension_Publications.FirstOrDefault(gdp => gdp.Good_Dimension_Id.ToString().ToLower().Contains(publicationSearchTextBox.Text.ToLower())) != null));
                    }
                }
                else
                {
                    publicationBindingSource.DataSource = dbContext.Publications.Local.ToBindingList();
                }
            }

            mainFormGridView.DataSource = publicationBindingSource;
            mainBindingNavigator.BindingSource = publicationBindingSource;
        }


        // Order receipt
        private void orderPanelSaveReceipt_Click(object sender, EventArgs e)
        {
            if (saveReportFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                // Получаем выбранный файл
                string writePath = saveReportFileDialog.FileName;
                string text = "            RECEIPT\n___________________________________________\n";

                Model.Order order = mainFormGridView.SelectedRows.Count == 0 ? null : (Model.Order)mainFormGridView.SelectedRows[0].DataBoundItem;
                if (order == null)
                {
                    MessageBox.Show("You should to select at least one row");
                    return;
                }
                text += "    Order№" + order.Order_Id + "\n    Date of order " + order.Date + "\n    Client: " + order.First_Name + " " + order.Last_Name + "\n\n";

                int posIndex = 1;
                foreach (var part in order.Receipts)
                {
                    string goodDimension = part.Good_Dimension.ToString();
                    text += posIndex + ". " + goodDimension + "    Count: " + part.Amount + "    Price=" + part.Position_Price + "\n";
                }
                text += "\n                         Full price: " + order.Full_Price+"\n____________________________________________\n";
                text += "    Date of receipt: " + DateTime.Now;

                try
                {
                    using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void putOnBotButton_Click(object sender, EventArgs e)
        {
            putOnBotButton.Enabled = false;
            ClientApiHandler cah = new ClientApiHandler(ref instaApi, ref dbContext, 3000);
            Thread cahThread = new Thread(new ThreadStart(cah.Start));
            cahThread.Start();
            MessageBox.Show("Bot is put on");
        }

        private void createNewOrderFromSelectedVendorCodesButton_Click(object sender, EventArgs e)
        {
            if (mainFormGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("You should to choose at least one row");
                return;
            }
            List<Model.Good_Dimension> vendorCodes = new List<Model.Good_Dimension>();
            for(int i = 0; i < mainFormGridView.SelectedRows.Count; i++)
            {
                vendorCodes.Add((Model.Good_Dimension)mainFormGridView.SelectedRows[i].DataBoundItem);
            }


            Model.Order order = new Model.Order { Receipts = new List<Model.Receipt>(), Date = DateTime.Now };
            OrderSubForm orderSubForm = new OrderSubForm(ref dbContext, ref order, true);
            foreach (var x in vendorCodes)
            {
                orderSubForm.addNewReceipt(x.Good_Dimension_Id);
            }
            orderSubForm.Show();


        }
    }
}
