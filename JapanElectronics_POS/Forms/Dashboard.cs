using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapanElectronics_POS.Forms
{
    public partial class Dashboard : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        string ConString = Utility.Utility.GetConnectionString();
        public Dashboard()
        {
            AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
        //    this.ControlBox = false;
            //   Models();
        }

   
        private void Dashboard_Load(object sender, EventArgs e)
        {

            btn_haier.Click += Company_Click;
            btn_dawlance.Click += Company_Click;
            btn_pel.Click += Company_Click;
            btn_other.Click += Company_Click;
        }

        private void Company_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Load and display data from the database for the selected category
            LoadDataIntoPanel(clickedButton.Text);
        }

        private void LoadDataIntoPanel(string category)
        {
            int CatId = 0;
            if (category == "Haier")
            {
                CatId = 1;
            }
            else if (category == "Dawlance")
            {
                CatId = 2;
            }
            else if (category == "Other")
            {
                CatId = 3;
            }


            // Replace the connection string with your actual database connection string
          
            string query = $"SELECT CategoryID,CategoryName FROM tbl_Category WHERE CategoryID = '{CatId}'";

            using (SqlConnection conn = new SqlConnection(ConString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Create and add buttons based on the data to pnl_cat
                    foreach (DataRow row in dataTable.Rows)
                    {
                        Button categoryButton = new Button();
                        categoryButton.Text = row["CategoryName"].ToString(); // Replace "ColumnName" with your actual column name
                        categoryButton.Width = 150;
                        categoryButton.Height = 30;
                    }
                }
            }

        }

    }
}

