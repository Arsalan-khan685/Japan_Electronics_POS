using JapanElectronics_POS.Forms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace JapanElectronics_POS
{
    public partial class Login : RadForm
    {
        public string ConString = Utility.Utility.GetConnectionString();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_adminname.Text != "" && txt_password.Text != "")
            {
                SqlConnection conn = null;
                SqlCommand cmd = null;
                using (conn = new SqlConnection(ConString))
                {
                    conn.Open();
                    string query = "Select Count(*) from tbl_Admin where AdminName=@Admin and Password=@Password";
                    using (cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Admin",txt_adminname.Text);
                        cmd.Parameters.AddWithValue("@Password",txt_password.Text);
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Login Succesful");
                            this.Hide();
                            Form1 form = new Form1();
                            form.Show();
                          //  Dashboard dashboard = new Dashboard();
                          //  dashboard.Show();
                        }
                        else 
                        {
                            MessageBox.Show("Invalid UserName or Password");
                        }
                    }    
                }
            }
            else
            {
                 MessageBox.Show("Enter User name and password");
            }
        }

    }
}
