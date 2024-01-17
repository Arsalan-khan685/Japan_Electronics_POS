﻿using System;
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
    public partial class Category : RadForm
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        string ConString = Utility.Utility.GetConnectionString();
        public Category()
        {
            InitializeComponent();

            // dgv_category.AutoGenerateColumns = false;
            // For Suggestion and Appending of Dropdown
            // Assuming cmb_company is the name of your ComboBox control
            // cmb_company.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            // cmb_company.AutoCompleteSource = AutoCompleteSource.CustomSource;
            // cmb_company.TextChanged += cmb_company_TextChanged;
            // Initialize AutoCompleteCustomSource
            // InitializeAutoComplete();
        }

        //  For Suggestion and Appending of Dropdown
        //private List<string> companyNames = new List<string>();
        //private void InitializeAutoComplete()
        //{
        //    using (conn = new SqlConnection(ConString))
        //    {
        //        string query = "Select CompanyName from tbl_Company";
        //        using (cmd = new SqlCommand(query, conn))
        //        {
        //            conn.Open();
        //            SqlDataReader reader = cmd.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                string companyName = reader["CompanyName"].ToString();
        //                companyNames.Add(companyName);
        //            }
        //        }
        //    }

        //    // Set the AutoCompleteCustomSource
        //    cmb_company.AutoCompleteCustomSource.AddRange(companyNames.ToArray());
        //}
        //private void cmb_company_TextChanged(object sender, EventArgs e)
        //{
        //    string searchString = cmb_company.Text;

        //    // You can still filter the AutoCompleteCustomSource directly
        //    var filteredData = companyNames
        //        .Where(company => company.ToLower().Contains(searchString.ToLower()))
        //        .ToArray();

        //    cmb_company.AutoCompleteCustomSource.Clear();
        //    cmb_company.AutoCompleteCustomSource.AddRange(filteredData);
        //}

        private void Category_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            FillCompanies();
            GetAllCategories();
        }
        public void FillCompanies()
        {
            DataTable data = new DataTable();

            data.Columns.Add("CompanyID", typeof(int));
            data.Columns.Add("CompanyName", typeof(string));

            // Create a default row for 'Select' with a value of -1
            DataRow defaultRow = data.NewRow();
            defaultRow["CompanyID"] = -1;
            defaultRow["CompanyName"] = "Select";
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
        public void GetAllCategories()
        {
            dgv_category.Rows.Clear();
            DataTable data = new DataTable();
            using (conn = new SqlConnection(ConString))
            {
                string query = "select tco.CompanyName,tc.CategoryName from tbl_category tc" +
                                " join tbl_Company tco on tc.Company_ID = tco.CompanyID";
                using (cmd = new SqlCommand(query, conn))
                    conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    // Assuming you have a DataGridView column named "CompanyName"
                    while (reader.Read())
                    {
                        dgv_category.Rows.Add(reader["CompanyName"], reader["CategoryName"]);
                    }
                }
            }
        }

        //private void btn_Save_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (txt_category.Text == "")
        //        {
        //            MessageBox.Show("Enter Category Name");
        //        }
        //        else if (cmb_company.SelectedValue != null && (int)cmb_company.SelectedValue == -1)
        //        {
        //            MessageBox.Show("Please select a company.");
        //        }
        //        else
        //        {
        //            using (conn = new SqlConnection(ConString))
        //            {
        //                string query = "Insert into tbl_Category(CategoryName,Company_ID) Values(@CatName,@Company_ID)";
        //                using (cmd = new SqlCommand(query, conn))
        //                {
        //                    conn.Open();
        //                    cmd.Parameters.AddWithValue("@CatName", txt_category.Text);
        //                    cmd.Parameters.AddWithValue("@Company_ID", cmb_company.SelectedValue);

        //                    cmd.ExecuteNonQuery();
        //                }
        //            }
        //            txt_category.Text = "";
        //            cmb_company.SelectedIndex = -1;
        //            GetAllCategories();
        //            FillCompanies();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }           
        //}
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
         //   Dashboard dashboard = new Dashboard();
         //   dashboard.Show();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_category.Text == "")
                {
                    MessageBox.Show("Enter Category Name");
                }
                else if (cmb_company.SelectedValue != null && (int)cmb_company.SelectedValue == -1)
                {
                    MessageBox.Show("Please select a company.");
                }
                else
                {
                    using (conn = new SqlConnection(ConString))
                    {
                        string q = "Insert into tbl_Category(Company_ID,CategoryName) VALUES (@CompanyID,@Category)";
                        cmd = new SqlCommand(q, conn);
                        cmd.Parameters.AddWithValue("@CompanyID", cmb_company.SelectedValue);
                        cmd.Parameters.AddWithValue("@Category", txt_category.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        txt_category.Text = "";
                        cmb_company.SelectedIndex = -1;
                        GetAllCategories();
                        FillCompanies();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              //  throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
