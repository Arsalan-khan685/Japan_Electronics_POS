using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace JapanElectronics_POS.Forms
{
    public partial class CustomerBill : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        string ConString = Utility.Utility.GetConnectionString();
        public CustomerBill()
        {
            InitializeComponent();
            FillModels();
            txt_cnic.KeyPress += Txt_cnic_KeyPress;
            txt_qty.KeyPress += Txt_qty_KeyPress;
            txt_price.KeyPress += Txt_price_KeyPress;
            txt_totalprice.KeyPress += Txt_totalprice_KeyPress;
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
        private void Txt_price_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CustomerBill_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
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
        
        Bitmap bitmap;

        private void btn_print_Click(object sender, EventArgs e)
        {
            // Initialize the bitmap
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

    }
}
