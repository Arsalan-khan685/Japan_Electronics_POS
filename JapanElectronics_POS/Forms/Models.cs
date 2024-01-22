using JapanElectronics_POS.Utility;
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
    public partial class Models : RadForm
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        string ConString = Utility.Utility.GetConnectionString();
        public Models()
        {
            InitializeComponent();
            InitializeForm();
            dgv_models.Columns["ModelID"].IsVisible = false;
        }
        private void Models_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        public void InitializeForm()
        {
            cmb_company.DisplayMember = "CompanyName";
            cmb_company.ValueMember = "CompanyID";
            cmb_category.DisplayMember = "CategoryName";
            cmb_category.ValueMember = "CategoryID";

            Fill_Companies();
            GetAllModels();
        }
        public void Fill_Companies()
        {
            DataTable data = new DataTable();

            data.Columns.Add("CompanyID", typeof(int));
            data.Columns.Add("CompanyName", typeof(string));

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

            // Create a default row for 'Select' with a value of -1
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
                    cmd.Parameters.AddWithValue("@selectedValue",s);
                    conn.Open();
                    data.Load(cmd.ExecuteReader());                  
                }
            }

            cmb_category.DataSource = data;
            cmb_category.DisplayMember = "CategoryName";
            cmb_category.ValueMember = "CategoryID";
        }      
        public void GetAllModels()
        {
            dgv_models.Rows.Clear();
            DataTable data = new DataTable();
            using (conn = new SqlConnection(ConString))
            {
                string query = "select tm.ModelID,tm.ModelName,tc.CategoryName,tco.CompanyName from tbl_Model tm" +
                                " inner join tbl_Category tc on tm.Category_ID=tc.CategoryID" +
                                " inner join tbl_Company tco on tm.Company_ID = tco.CompanyID";
                using (cmd = new SqlCommand(query, conn))
                    conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dgv_models.Rows.Add(reader["ModelID"],reader["CompanyName"], reader["CategoryName"], reader["ModelName"]);
                    }
                }
            }
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_model.Text == "")
                {
                    MessageBox.Show("Enter Model Name");
                }
                else if (cmb_company.SelectedValue != null && (int)cmb_company.SelectedValue == -1)
                {
                    MessageBox.Show("Please select a company.");
                }
                else if (cmb_category.SelectedValue != null && (int)cmb_category.SelectedValue == -1)
                {
                    MessageBox.Show("Please select a category.");
                }
                else
                {
                    using (conn = new SqlConnection(ConString))
                    {
                        string query = "Insert into tbl_Model (ModelName,Category_ID,Company_ID,CreatedBy,CreatedDate) " +
                                        " Values (@ModelName, @Category_ID, @Company_ID,@CreatedBy,@CreatedDate ) ";
                        using (cmd = new SqlCommand(query, conn)) 
                        {
                            conn.Open();
                            cmd.Parameters.AddWithValue("@ModelName", txt_model.Text);
                            cmd.Parameters.AddWithValue("@Category_ID", cmb_category.SelectedValue);
                            cmd.Parameters.AddWithValue("@Company_ID", cmb_company.SelectedValue);
                            cmd.Parameters.AddWithValue("@CreatedBy", AppSettings.AdminId);
                            cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    txt_model.Text = "";
                    GetAllModels();
                    Fill_Companies();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        private void cmb_company_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Fill_Categories();
        }
        private void dgv_models_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GridViewRowInfo selectedRow = dgv_models.Rows[e.RowIndex];
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Call the method to delete the record
                    DeleteRecord(selectedRow);
                    GetAllModels();
                }
            }
        }
        private void DeleteRecord(GridViewRowInfo row)
        {
            try
            {
                int modelIdToDelete = Convert.ToInt32(row.Cells["ModelID"].Value); // Adjust the column name

                using (conn = new SqlConnection(ConString))
                {
                    string query = "Delete from tbl_Model where ModelID = '" + modelIdToDelete + "' ";
                    cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Model Deleted Succesfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
