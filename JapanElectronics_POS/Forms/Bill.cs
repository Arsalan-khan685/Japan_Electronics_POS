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
    public partial class Bill : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        string ConString = Utility.Utility.GetConnectionString();
        public Bill()
        {
            InitializeComponent();
            InitializeForm();
            FillModels();
            txt_cnic.KeyPress += Txt_cnic_KeyPress;
            txt_qty.KeyPress += Txt_qty_KeyPress;
            txt_price.KeyPress += Txt_price_KeyPress;
            txt_totalprice.KeyPress += Txt_totalprice_KeyPress;
        }
        private void Txt_totalprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleDecimal(sender, e);
        }
        private void Txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleDecimal(sender, e);
        }
        private void HandleDecimal(object sender, KeyPressEventArgs e)
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

        private void Txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleInt(sender,  e);
        }

        private void Txt_cnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleInt(sender, e);
        }
        private void HandleInt(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }
        private void Bill_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        public void FillModels()
        {
            try
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
                    string query = "Select m.ModelID,m.ModelName from tbl_Model m " +
                                    "inner join tbl_Stock s on m.ModelID=s.Model_ID Where s.TotalQuantity > 0";

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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
           
        }

        private void InitializeForm()
        {
          //  GetUserData();
        }
        protected void GetUserData(string name,DateTime date)
        {
            dgv_usersdata.Rows.Clear();
            DataTable data = new DataTable();
            using (conn = new SqlConnection(ConString))
            {
                string query = "select m.ModelName,s.UnitPrice,s.Quantity,s.TotalPrice " +
                                " from tbl_Sales s inner join tbl_Model m on s.Model_ID = m.ModelID" +
                                " Where s.UserName = @name AND CONVERT(DATE, s.SalesDate) = @date";
                using (cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@date", date.Date); // Use only the date part

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        // Assuming you have a DataGridView column named "CompanyName"
                        while (reader.Read())
                        {
                            int rowIndex = dgv_usersdata.Rows.Add();
                            dgv_usersdata.Rows[rowIndex].Cells["ModelName"].Value = reader["ModelName"];
                            dgv_usersdata.Rows[rowIndex].Cells["Price"].Value = reader["UnitPrice"];
                            dgv_usersdata.Rows[rowIndex].Cells["Quantity"].Value = reader["Quantity"];
                            dgv_usersdata.Rows[rowIndex].Cells["TotalPrice"].Value = reader["TotalPrice"];
                        }
                        // Calculate and display the sum in the last row
                        decimal totalSum = dgv_usersdata.Rows.Cast<DataGridViewRow>().Sum(row => Convert.ToDecimal(row.Cells["TotalPrice"].Value));
                        int totalRowIndex = dgv_usersdata.Rows.Add();
                        dgv_usersdata.Rows[totalRowIndex].Cells["ModelName"].Value = "Total";
                        dgv_usersdata.Rows[totalRowIndex].Cells["TotalPrice"].Value = totalSum;
                    }
                }             
            }
        }
        Bitmap bitmap;
        

        private void btn_print_Click_2(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            txt_price.Visible = false;
            txt_qty.Visible = false;
            txt_totalprice.Visible = false;
            btn_save.Visible = false;
            btn_print.Visible = false;
            bitmap = new Bitmap(this.Width, this.Height);

            // Draw the form onto the bitmap
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));

            // Exclude the print button
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.FillRectangle(new SolidBrush(this.BackColor), btn_print.Bounds);
            }

            // Set up the print document
            printDocument1.DefaultPageSettings.Landscape = true;
            printDocument1.PrintPage += (s, ev) =>
            {
                if (bitmap != null)
                {
                    ev.Graphics.DrawImage(bitmap, 0, 0);
                }
            };

            // Show the print preview dialog
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

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
                else if (txt_price.Text == "")
                {
                    MessageBox.Show("Please Enter Unit Price");
                }
                else if (txt_qty.Text == "")
                {
                    MessageBox.Show("Please Enter Quantity");
                }
                else
                {
                    using (conn = new SqlConnection(ConString))
                    {
                        using (SqlCommand cmd = new SqlCommand("Stp_SalesInsertion", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@UserName", txt_username.Text);
                            cmd.Parameters.AddWithValue("@CNIC", txt_cnic.Text);
                            cmd.Parameters.AddWithValue("@ItemModel", cmb_models.SelectedValue);
                            cmd.Parameters.AddWithValue("@UnitPrice", txt_price.Text);
                            cmd.Parameters.AddWithValue("@Quantity", txt_qty.Text);
                            cmd.Parameters.AddWithValue("@TotalPrice", txt_totalprice.Text);

                            if (DateTime.TryParse(txt_date.Text, out DateTime date))
                            {
                                cmd.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd"));
                            }
                            else
                            {
                                // Handle invalid date format
                                MessageBox.Show("Invalid date format");
                                return;
                            }
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            GetUserData(txt_username.Text,date);
                        }
                    }
                    Clear();
                    MessageBox.Show("Record Saved Succesfully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }
        protected void Clear()
        {
            cmb_models.SelectedValue = "-1";
            txt_price.Text = "";
            txt_qty.Text = "";
            txt_totalprice.Text = "";
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text != "")
            {
                decimal uprice = Convert.ToDecimal(txt_price.Text);
                int qty = Convert.ToInt32(txt_qty.Text);
                txt_totalprice.Text = Convert.ToString(uprice * qty);
            }
            else
            {
                txt_totalprice.Text = txt_price.Text;
            }
        }

        
    }

}
