using Microsoft.Reporting.WinForms;
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
    public partial class rpt_Stocks : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        string ConString = Utility.Utility.GetConnectionString();
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

        public rpt_Stocks()
        {
            AutoScaleMode = AutoScaleMode.None;
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer1);

            InitializeComponent();
            InitializeForm();
        }
        private void rpt_Stocks_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
          
        }
        public void InitializeForm()
        {
            cmb_company.DisplayMember = "CompanyName";
            cmb_company.ValueMember = "CompanyID";
            cmb_category.DisplayMember = "CategoryName";
            cmb_category.ValueMember = "CategoryID";
            cmb_model.DisplayMember = "ModelName";
            cmb_model.ValueMember = "ModelID";
            FillCompanies();
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
        private void btn_report_Click(object sender, EventArgs e)
        {
            try
            {
                using(conn = new SqlConnection(ConString))
                {
                    //string query = "select c.CategoryName,co.CompanyName,m.ModelName,s.TotalQuantity " +
                    //                " from tbl_Stock s " +
                    //                " inner join tbl_Company co on s.Company_ID = co.CompanyID" +
                    //                " inner join tbl_Category c on s.category_ID = c.CategoryID " +
                    //                "inner join tbl_Model m on s.Model_ID = m.ModelID";
                                    
                    SqlCommand cmd = new SqlCommand("Stp_rptStocks", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Company_ID", cmb_company.SelectedValue.ToString() != "-1" ? (object)cmb_company.SelectedValue : DBNull.Value);
                    cmd.Parameters.AddWithValue("@Category_ID", cmb_category.SelectedValue.ToString() != "-1" ? (object)cmb_category.SelectedValue : DBNull.Value);
                    cmd.Parameters.AddWithValue("@Model_ID", cmb_model.SelectedValue.ToString() != "-1" ? (object)cmb_model.SelectedValue : DBNull.Value);

                    //if (cmb_company.SelectedValue.ToString() != "-1")
                    //{
                    //    cmd.Parameters.AddWithValue("@Company_ID",cmb_company.SelectedValue);
                    //}
                    //else
                    //{
                    //    cmd.Parameters.AddWithValue("@Company_ID",null);
                    //}
                    //if (cmb_category.SelectedValue.ToString() != "-1")
                    //{
                    //    cmd.Parameters.AddWithValue("@Category_ID", cmb_category.SelectedValue);
                    //}
                    //else
                    //{
                    //    cmd.Parameters.AddWithValue("@Category_ID", null);
                    //}
                    //if (cmb_model.SelectedValue.ToString() != "-1")
                    //{
                    //    cmd.Parameters.AddWithValue("@Model_ID", cmb_model.SelectedValue);
                    //}
                    //else
                    //{
                    //    cmd.Parameters.AddWithValue("@Model_ID", null);
                    //}

                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    reportViewer1.LocalReport.DataSources.Clear();
                    ReportDataSource source = new ReportDataSource("DataSet1",dt);
                    reportViewer1.LocalReport.ReportPath = "StocksReport.rdlc";
                    reportViewer1.LocalReport.DataSources.Add(source);
                    reportViewer1.RefreshReport();

                    
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private void cmb_company_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCategories();
        }
        public void FillCategories()
        {
            DataTable data = new DataTable();

            data.Columns.Add("CategoryID", typeof(int));
            data.Columns.Add("CategoryName", typeof(string));

            // Create a default row for 'Select' with a value of -1
            DataRow defaultRow = data.NewRow();
            defaultRow["CategoryID"] = -1;
            defaultRow["CategoryName"] = "Select Category";
            data.Rows.Add(defaultRow);

            using (conn = new SqlConnection(ConString))
            {
                string query = "Select * from tbl_Category where Company_ID = @selectedValue";

                using (cmd = new SqlCommand(query, conn))
                {
                    int s = (int)cmb_company.SelectedValue;
                    cmd.Parameters.AddWithValue("@selectedValue", s);
                    conn.Open();
                    data.Load(cmd.ExecuteReader());
                }
            }

            cmb_category.DataSource = data;
            cmb_category.DisplayMember = "CategoryName";
            cmb_category.ValueMember = "CategoryID";
        }
        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillModels();
        }
        public void FillModels()
        {
            DataTable data = new DataTable();

            data.Columns.Add("ModelID", typeof(int));
            data.Columns.Add("ModelName", typeof(string));

            // Create a default row for 'Select' with a value of -1
            DataRow defaultRow = data.NewRow();
            defaultRow["ModelID"] = -1;
            defaultRow["ModelName"] = "Select Model";
            data.Rows.Add(defaultRow);

            using (conn = new SqlConnection(ConString))
            {
                string query = "Select * from tbl_Model where Category_ID = @selectedValue";

                using (cmd = new SqlCommand(query, conn))
                {
                    int s = (int)cmb_category.SelectedValue;
                    cmd.Parameters.AddWithValue("@selectedValue", s);
                    conn.Open();
                    data.Load(cmd.ExecuteReader());
                }
            }

            cmb_model.DataSource = data;
            cmb_model.DisplayMember = "ModelName";
            cmb_model.ValueMember = "ModelID";
        }
    }
}
