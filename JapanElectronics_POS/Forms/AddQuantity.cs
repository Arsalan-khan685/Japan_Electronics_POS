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
    public partial class AddQuantity : RadForm
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        string ConString = Utility.Utility.GetConnectionString();
        public AddQuantity()
        {
            AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
            InitializeForm();
            txt_quantity.KeyPress += Txt_quantity_KeyPress;
            txt_unitprice.KeyPress += Txt_unitprice_KeyPress;
            txt_totalprice.KeyPress += Txt_totalprice_KeyPress;
            txt_creationdate.Text = DateTime.Now.ToString();
        }
        private void Txt_totalprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
            // Ensure that only one decimal point is allowed
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void Txt_unitprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
            // Ensure that only one decimal point is allowed
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void Txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }
        public void InitializeForm()
        {
            cmb_company.DisplayMember = "CompanyName";
            cmb_company.ValueMember = "CompanyID";
            cmb_category.DisplayMember = "CategoryName";
            cmb_category.ValueMember = "CategoryID";

            Fill_Companies();
        }
        private void AddQuantity_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        public void Fill_Companies()
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

            cmb_model.DataSource = data;
            cmb_model.DisplayMember = "ModelName";
            cmb_model.ValueMember = "ModelID";
        }
        
        private void cmb_company_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Fill_Categories();
        }
        private void cmb_category_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Fill_Models();
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
            if (txt_quantity.Text != "")
            {
                decimal uprice = Convert.ToDecimal(txt_unitprice.Text);
                int qty = Convert.ToInt32(txt_quantity.Text);
                txt_totalprice.Text = Convert.ToString(uprice * qty);
            }
            else
            {
                txt_totalprice.Text = txt_unitprice.Text;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_unitprice.Text == "")
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
                else if (cmb_model.SelectedValue != null && (int)cmb_model.SelectedValue == -1)
                {
                    MessageBox.Show("Please select a Model.");
                }
                else
                {
                    using (conn = new SqlConnection(ConString))
                    {
                        using (cmd = new SqlCommand("Stp_QuantityInsertion", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Company_ID", cmb_company.SelectedValue);
                            cmd.Parameters.AddWithValue("@Category_ID", cmb_category.SelectedValue);
                            cmd.Parameters.AddWithValue("@Model_ID", cmb_model.SelectedValue);
                            cmd.Parameters.AddWithValue("@UnitPrice", txt_unitprice.Text);
                            cmd.Parameters.AddWithValue("@Quantity", txt_quantity.Text);
                            cmd.Parameters.AddWithValue("@TotalPrice", txt_totalprice.Text);
                            if (DateTime.TryParse(txt_creationdate.Text, out DateTime creationDate))
                            {
                                cmd.Parameters.AddWithValue("@CreationDate", creationDate.ToString("yyyy-MM-dd"));
                            }
                            else
                            {
                                MessageBox.Show("Invalid Date Format");
                                return;
                            }
                            cmd.Parameters.AddWithValue("@AdminId", AppSettings.AdminId);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Quantity Added Succesfully");
                            txt_unitprice.Text = "";
                            txt_quantity.Text = "";
                            txt_totalprice.Text = "";
                            Fill_Companies();
                        }
                    }
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

        private void btn_back_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
