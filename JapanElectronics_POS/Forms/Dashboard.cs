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
using Telerik.WinControls.UI;

namespace JapanElectronics_POS.Forms
{
    public partial class Dashboard : RadForm
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        string ConString = Utility.Utility.GetConnectionString();
        public Dashboard()
        {
            AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
          
        }

        private void btn_haier_Click(object sender, EventArgs e)
        {
            List<string> categoryNames = new List<string>();
            List<string> modelNames = new List<string>();
            List<int> totalQuantities = new List<int>();

            HashSet<string> uniqueCategories = new HashSet<string>();       // test line

            using (conn = new SqlConnection(ConString))
            {
                string query = "Select ct.CategoryName,s.TotalQuantity,m.modelName from tbl_Stock s inner join tbl_Category ct on ct.CategoryID=s.Category_ID " +
                                "inner join tbl_Company c on c.CompanyID = s.Company_ID " +
                                "inner join tbl_Model m on m.ModelID=s.Model_ID where c.CompanyName = 'Dawlance' -- and s.TotalQuantity > 0 ";

                cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    { 
                        // test lines
                        string categoryName = reader["CategoryName"].ToString();
                        int totalQuantity = (int)reader["TotalQuantity"];
                        string modelName = reader["ModelName"].ToString();

                        // Check if the category is not already in the HashSet
                        if (uniqueCategories.Add(categoryName))
                        {
                            categoryNames.Add(categoryName);
                        }

                        totalQuantities.Add(totalQuantity);
                        modelNames.Add(modelName);

                        /*
                        // Retrieve values from the reader and add them to the lists
                        categoryNames.Add(reader["CategoryName"].ToString());
                        totalQuantities.Add((int)reader["TotalQuantity"]);
                        modelNames.Add(reader["ModelName"].ToString()); */
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        //    radLbl_Haier.Visible = true;
            radLbl_Haier.Text = "Following Categories are present :\n";

            foreach (string categoryName in categoryNames)
            {
                radLbl_Haier.Text += categoryName + "\n";
            }
        //    radLbl_Models.Visible = true;
            radLbl_Models.Text = "Following Models are present : \n";

            foreach (string models in modelNames)
            {
                radLbl_Models.Text += models + "\n";
            }
        }

        private void btn_dawlance_Click(object sender, EventArgs e)
        {
            radLbl_Haier.Visible = true;
            radLbl_Haier.Text = "Dawlance Click";
        }

        private void btn_pel_Click(object sender, EventArgs e)
        {
            radLbl_Haier.Visible = true;
            radLbl_Haier.Text = "PEL Click";
        }

        private void btn_other_Click(object sender, EventArgs e)
        {
            radLbl_Haier.Visible = true;
            radLbl_Haier.Text = "Others Click";
        }
    }
}

