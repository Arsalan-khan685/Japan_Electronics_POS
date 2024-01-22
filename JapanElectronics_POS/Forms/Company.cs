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
    public partial class Company : RadForm
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        string ConString = Utility.Utility.GetConnectionString();
        public Company()
        {
            InitializeComponent();
            dgvCompany.Columns["CompanyID"].IsVisible = false;
        }
        private void Company_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            GetAllCompanies();
        }
        public void GetAllCompanies()
        {
            dgvCompany.Rows.Clear();
            
            DataTable data = new DataTable();
            using (conn = new SqlConnection(ConString))
            {
                string query = "select CompanyID,CompanyName from tbl_Company";
                using (cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        { 
                            dgvCompany.Rows.Add(reader["companyid"], reader["companyname"]);
                        }
                    }
                }
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_companyname.Text == "")
                {
                    MessageBox.Show("Enter Company Name");
                }
                else
                {
                    using (conn = new SqlConnection(ConString))
                    {
                        string query = "Insert into tbl_Company(CompanyName,CreatedBy,CreatedDate) Values(@CompanyName,@CreatedBy,@CreatedDate)";
                        using (cmd = new SqlCommand(query, conn))
                        {
                            conn.Open();
                            cmd.Parameters.AddWithValue("@CompanyName", txt_companyname.Text);
                            cmd.Parameters.AddWithValue("@CreatedBy", AppSettings.AdminId);
                            cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    txt_companyname.Text = "";
                    GetAllCompanies();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCompany_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GridViewRowInfo selectedRow = dgvCompany.Rows[e.RowIndex];
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Call the method to delete the record
                    DeleteRecord(selectedRow);
                    GetAllCompanies();
                }
            }
        }
        private void DeleteRecord(GridViewRowInfo row)
        {
            try
            {
                int companyIdToDelete = Convert.ToInt32(row.Cells["CompanyID"].Value); // Adjust the column name

                using (conn = new SqlConnection(ConString))
                {
                    string query = "Delete from tbl_Company where CompanyID = '" + companyIdToDelete + "' ";
                    cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Company Deleted Succesfully");
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
