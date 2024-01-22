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
    public partial class Sales_form : RadForm
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        string ConString = Utility.Utility.GetConnectionString();
        public Sales_form()
        {
            AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
            InitializeForm();
            txt_cnic.KeyPress += Txt_cnic_KeyPress;
            txt_quantity.KeyPress += Txt_quantity_KeyPress;
            txt_unitprice.KeyPress += Txt_unitprice_KeyPress;
            txt_totalprice.KeyPress += Txt_totalprice_KeyPress;
            txt_date.Text = DateTime.Now.ToString();
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
        private void Txt_cnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }
        public void InitializeForm()
        {
            cmb_models.DisplayMember = "ModelName";
            cmb_models.ValueMember = "ModelID";
            FillItems();
        }
        public void FillItems()
        {
            DataTable data = new DataTable();

            data.Columns.Add("ModelID", typeof(int));
            data.Columns.Add("ModelName", typeof(string));

            DataRow defaultRow = data.NewRow();
            defaultRow["ModelID"] = -1;
            defaultRow["ModelName"] = "Select Model";
            data.Rows.Add(defaultRow);

            using (conn = new SqlConnection(ConString))
            {
                string query = "Select * from tbl_Model";

                using (cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    data.Load(cmd.ExecuteReader());
                }
            }
            cmb_models.DataSource = data;
            cmb_models.DisplayMember = "ModelName";
            cmb_models.ValueMember = "ModelID";
        }
        public void Clear()
        {
            txt_username.Text = "";
            txt_cnic.Text = "";
            cmb_models.SelectedValue = "-1";
            txt_unitprice.Text = "";
            txt_totalprice.Text = "";
            txt_quantity.Text = "";
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_username.Text == "")
                {
                    MessageBox.Show("Enter Name Please");
                }
                else if (txt_cnic.Text == "")
                {
                    MessageBox.Show("Enter CNIC Please");
                }
                else if (cmb_models.SelectedValue != null && (int)cmb_models.SelectedValue == -1)
                {
                    MessageBox.Show("Please Select a Model");
                }
                else if (txt_unitprice.Text == "")
                {
                    MessageBox.Show("Please Enter Unit Price");
                }
                else if (txt_quantity.Text == "")
                {
                    MessageBox.Show("Please Enter Quantity");
                }
                else
                {
                    using (conn = new SqlConnection(ConString))
                    {
                        SqlCommand cmd = new SqlCommand("Stp_SalesInsertion", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserName", txt_username.Text);
                        cmd.Parameters.AddWithValue("@CNIC", txt_cnic.Text);
                        cmd.Parameters.AddWithValue("@ItemModel", cmb_models.SelectedValue);
                        cmd.Parameters.AddWithValue("@UnitPrice", txt_unitprice.Text);
                        cmd.Parameters.AddWithValue("@Quantity", txt_quantity.Text);
                        cmd.Parameters.AddWithValue("@TotalPrice", txt_totalprice.Text);
                        if (DateTime.TryParse(txt_date.Text, out DateTime salesDate))
                        {
                            cmd.Parameters.AddWithValue("@Date", salesDate.ToString("yyyy-MM-dd"));
                        }
                        else
                        {
                            // Handle invalid date format
                            MessageBox.Show("Invalid date format");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@AdminId",AppSettings.AdminId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        Clear();
                        MessageBox.Show("Record Saved Succesfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Sales_form_Load(object sender, EventArgs e)
        {

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

    }
}
