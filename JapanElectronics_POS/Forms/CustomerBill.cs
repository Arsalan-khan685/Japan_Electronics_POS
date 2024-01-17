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
using Telerik.WinControls.UI;

namespace JapanElectronics_POS.Forms
{
    public partial class CustomerBill : RadForm
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        string ConString = Utility.Utility.GetConnectionString();
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public CustomerBill()
        {
            AutoScaleMode = AutoScaleMode.None;
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer1);
            InitializeComponent();
            txt_date.Text = DateTime.Now.ToString();
        }

        private void CustomerBill_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
           // this.reportViewer1.RefreshReport();         
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                using (conn = new SqlConnection(ConString))
                {
                    SqlCommand cmd = new SqlCommand("Stp_CustomerBill", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (txt_username.Text == "")
                    {
                        MessageBox.Show("Please Enter Custome Name");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Name", txt_username.Text);
                    }
                    if (!string.IsNullOrEmpty(txt_cnic.Text))
                    {
                        cmd.Parameters.AddWithValue("@CNIC", txt_cnic.Text);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@CNIC", DBNull.Value);
                    }

                    // Check if BillDate is provided, otherwise, pass null
                    if (DateTime.TryParse(txt_date.Text, out DateTime date))
                    {
                        cmd.Parameters.AddWithValue("@BillDate", date);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@BillDate", DBNull.Value);
                    }
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    reportViewer1.LocalReport.DataSources.Clear();
                    ReportDataSource source = new ReportDataSource("DataSet1", dt);
                    reportViewer1.LocalReport.ReportPath = "CustomerBill.rdlc";
                    reportViewer1.LocalReport.DataSources.Add(source);
                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
