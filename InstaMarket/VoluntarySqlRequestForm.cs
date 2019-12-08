using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaMarket
{
    public partial class VoluntarySqlRequestForm : Form
    {
        public VoluntarySqlRequestForm()
        {
            InitializeComponent();
        }

        private void doSqlButton_Click(object sender, EventArgs e)
        {
            try
            {
                string request = " "+sqlRequestRichTextBox.Text.ToLower();

                if (!request.Contains(" drop "))
                {
                    MySqlConnection sqlconn = new MySqlConnection(ConfigurationManager.ConnectionStrings["InstaMarketDatabase"].ConnectionString);
                sqlconn.Open();

                    MySqlDataAdapter oda = new MySqlDataAdapter(sqlRequestRichTextBox.Text, sqlconn);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    voluntaryDataGridView.DataSource = dt;
                    sqlconn.Close();
                }
                else
                {
                    MessageBox.Show("Found forbidden 'DROP' expression");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            sqlRequestRichTextBox.Text = "";
        }

        private void schemaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can see DB screnshots in schema folder.\nIt is in application folder.");
        }
    }
}
