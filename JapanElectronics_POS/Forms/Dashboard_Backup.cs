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
    public partial class Dashboard_Backup : RadForm
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        string ConString = Utility.Utility.GetConnectionString();
        public Dashboard_Backup()
        {
            InitializeComponent();
            InitializeForm();
        }
        private void InitializeForm()
        {
            cmb_company.DisplayMember = "CompanyName";
            cmb_company.ValueMember = "CompanyID";
            cmb_category.DisplayMember = "CategoryName";
            cmb_category.ValueMember = "CategoryID";

            Fill_Companies();
        }
        private void Fill_Companies()
        {
            DataTable data = new DataTable();

            data.Columns.Add("CompanyID", typeof(int));
            data.Columns.Add("CompanyName", typeof(string));

            // Create a default row for 'Select' with a value of -1
            DataRow defaultRow = data.NewRow();
            defaultRow["CompanyID"] = -1;
            defaultRow["CompanyName"] = "-- Select Company --";
            data.Rows.Add(defaultRow);

            using (conn = new SqlConnection(ConString))
            {
                string query = "Select * from tbl_Company";

                using (cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    data.Load(cmd.ExecuteReader());
                }
            }

            cmb_company.DataSource = data;
            cmb_company.DisplayMember = "CompanyName";
            cmb_company.ValueMember = "CompanyID";
        }
        public void Fill_Categories()
        {
            DataTable data = new DataTable();

            data.Columns.Add("CategoryID", typeof(int));
            data.Columns.Add("CategoryName", typeof(string));

            DataRow defaultRow = data.NewRow();
            defaultRow["CategoryID"] = -1;
            defaultRow["CategoryName"] = "-- Select Category --";
            data.Rows.Add(defaultRow);

            using (conn = new SqlConnection(ConString))
            {
                string query = "Select * from tbl_Category where Company_ID = @selectedValue";

                using (cmd = new SqlCommand(query, conn))
                {
                    int s = Convert.ToInt32(cmb_company.SelectedValue);
                    cmd.Parameters.AddWithValue("@selectedValue", s);
                    conn.Open();
                    data.Load(cmd.ExecuteReader());
                }
            }
            cmb_category.DataSource = data;
            cmb_category.DisplayMember = "CategoryName";
            cmb_category.ValueMember = "CategoryID";
        }
        public void Fill_Models()
        {
            DataTable data = new DataTable();

            data.Columns.Add("ModelID", typeof(int));
            data.Columns.Add("ModelName", typeof(string));

            // Create a default row for 'Select' with a value of -1
            DataRow defaultRow = data.NewRow();
            defaultRow["ModelID"] = -1;
            defaultRow["ModelName"] = "-- Select Model --";
            data.Rows.Add(defaultRow);

            using (conn = new SqlConnection(ConString))
            {
                string query = "Select * from tbl_Model where Category_ID = @selectedValue";

                using (cmd = new SqlCommand(query, conn))
                {
                    int s = Convert.ToInt32(cmb_category.SelectedValue);
                    cmd.Parameters.AddWithValue("@selectedValue", s);
                    conn.Open();
                    data.Load(cmd.ExecuteReader());
                }
            }

            cmb_models.DataSource = data;
            cmb_models.DisplayMember = "ModelName";
            cmb_models.ValueMember = "ModelID";
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            dgv_items.Rows.Clear();
            try
            {
                if (cmb_company.SelectedValue != null && (int)cmb_company.SelectedValue == -1)
                {
                    MessageBox.Show("Please select a company to show items in that company.");
                }
                else
                {
                    using (conn = new SqlConnection(ConString))
                    {
                        string q = "Select c.CompanyName,ct.CategoryName,m.modelName,s.TotalQuantity from tbl_Stock " +
                                     " s inner join tbl_Category ct on ct.CategoryID = s.Category_ID " +
                                     " inner join tbl_Company c on c.CompanyID = s.Company_ID " +
                                     " inner join tbl_Model m on m.ModelID = s.Model_ID " +
                                     " where c.CompanyID = @Company_ID ";
                        if (cmb_category.SelectedValue != null && Convert.ToInt32(cmb_category.SelectedValue) != -1)
                        {
                            q += " AND ct.CategoryID = @Category_ID";
                        }
                        if (cmb_models.SelectedValue != null && Convert.ToInt32(cmb_models.SelectedValue) != -1)
                        {
                            q += " AND m.ModelID = @Model_ID";
                        }
                        q += " AND s.TotalQuantity > 0";
                        cmd = new SqlCommand(q, conn);
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Company_ID", cmb_company.SelectedValue);
                        if (cmb_category.SelectedValue != null && Convert.ToInt32(cmb_category.SelectedValue) != -1)
                        {
                            cmd.Parameters.AddWithValue("@Category_ID", cmb_category.SelectedValue);
                        }

                        if (cmb_models.SelectedValue != null && Convert.ToInt32(cmb_models.SelectedValue) != -1)
                        {
                            cmd.Parameters.AddWithValue("@Model_ID", cmb_models.SelectedValue);
                        }

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            // Assuming you have a DataGridView column named "CompanyName"
                            while (reader.Read())
                            {
                                dgv_items.Rows.Add(reader["CompanyName"], reader["CategoryName"], reader["ModelName"], reader["TotalQuantity"]);
                            }
                        }
                    }
                    cmb_company.SelectedValue = "-1";
                    cmb_category.SelectedValue = "-1";
                    cmb_models.SelectedValue = "-1";
                }
            }
            catch (Exception ex)
            {   
                MessageBox.Show("Error: " + ex.Message);
            }
        }   
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmb_company_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Fill_Categories();
        }
        private void cmb_category_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Fill_Models();
        }

    }
}
