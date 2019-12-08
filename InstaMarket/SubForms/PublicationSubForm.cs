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
    public partial class PublicationSubForm : Form
    {
        InstaMarketDbContext dbContext;
        Publication publication;
        int imageIndex = 0;
        public PublicationSubForm(ref InstaMarketDbContext dbContext, ref Publication publication)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.publication = publication;
            if(publication.Publication_Images!=null && publication.Publication_Images.Count > 0)
            {
                publicationPictureBox.ImageLocation = publication.Publication_Images[imageIndex].Path;
            }

            if (publication.Good_Dimension_Publications == null)
            {
                publication.Good_Dimension_Publications = new List<Good_Dimension_Publication>();
            }
            if (publication.Publication_Videos == null)
            {
                publication.Publication_Videos = new List<Publication_Video>();
            }
            if (publication.Publication_Images == null)
            {
                publication.Publication_Images = new List<Publication_Image>();
            }

            publicationGoodDimensionsDataGridView.DataSource = new BindingList<Good_Dimension_Publication>(publication.Good_Dimension_Publications);
            publicationGoodDimensionsDataGridView.Columns["Publication"].Visible = false;
            if (publication.Publication_Videos != null)
            {
                foreach (Publication_Video video in publication.Publication_Videos)
                {
                    videosRichTextBox.Text += video.Path + "\n";
                }
            }
        }

        private void goToRightImageButton_Click(object sender, EventArgs e)
        {
            if (publication.Publication_Images.Count != 0)
            {
                if (imageIndex == publication.Publication_Images.Count - 1)
                {
                    imageIndex = 0;
                }
                else
                {
                    imageIndex++;
                }
                publicationPictureBox.ImageLocation = publication.Publication_Images[imageIndex].Path == null ? "" : publication.Publication_Images[imageIndex].Path;
            }
            
        }

        private void goToLeftImageButton_Click(object sender, EventArgs e)
        {
            if (imageIndex == 0)
            {
                imageIndex = publication.Publication_Images.Count - 1;
            }
            else
            {
                imageIndex--;
            }
            publicationPictureBox.ImageLocation = publication.Publication_Images[imageIndex].Path;
        }

        private void addVendorCodeButton_Click(object sender, EventArgs e)
        {
            int vendorCode = 0;
            try
            {
                vendorCode = Convert.ToInt32(vendorCodeTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Wrong vendor code format");
                return;
            }


            Good_Dimension good_Dimension = dbContext.Good_Dimensions.Find(vendorCode);
            if (good_Dimension != null)
            {

                if (publication.Good_Dimension_Publications.FirstOrDefault(gpd => gpd.Good_Dimension_Id == vendorCode) == null)
                {
                    publication.Good_Dimension_Publications.Add(new Good_Dimension_Publication { Good_Dimension_Id = vendorCode, Publication_Id = publication.Publication_Id, Publication = publication, Good_Dimension = good_Dimension });
                    publicationGoodDimensionsDataGridView.DataSource = new BindingList<Good_Dimension_Publication>(publication.Good_Dimension_Publications);
                }
                else
                {
                    MessageBox.Show("This vendor code is already attached");
                }
            }
            else
            {
                MessageBox.Show("Any matches to this vendor code");
            }


        }

        private void deleteVendorCodeButton_Click(object sender, EventArgs e)
        {
            int vendorCode = 0;
            try
            {
                vendorCode = Convert.ToInt32(vendorCodeTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Wrong vendor code format");
                return;
            }
            Good_Dimension_Publication good_Dimension = publication.Good_Dimension_Publications.FirstOrDefault(gdp=>gdp.Good_Dimension_Id==vendorCode);
            if (good_Dimension != null)
            {
                publication.Good_Dimension_Publications.Remove(good_Dimension);
                publicationGoodDimensionsDataGridView.DataSource = new BindingList<Good_Dimension_Publication>(publication.Good_Dimension_Publications);
            }
            else
            {
                MessageBox.Show("Any matches to this vendor code for this publication");
            }
        }

        private void savePublication_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
            this.Close();
        }
    }
}
