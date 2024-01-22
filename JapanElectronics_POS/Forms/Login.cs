using JapanElectronics_POS.Forms;
using JapanElectronics_POS.Utility;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace JapanElectronics_POS
{
    public partial class Login : RadForm
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
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
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            AppSettings.AdminId = GetAdminID(txt_adminname.Text);
                            AppSettings.AdminName = txt_adminname.Text;
                            MessageBox.Show("You are Succesfully Login ");
                            this.Hide();
                            MainForm form = new MainForm();
                            form.Show();
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
        private int GetAdminID(string adminName)
        {
            int adminId = 0;
            try
            {
                conn = new SqlConnection(ConString);
                string query = "Select AdminID From tbl_Admin Where AdminName = @AdminName ";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AdminName", adminName);
                conn.Open();
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        adminId = Convert.ToInt32(reader["AdminID"]);
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
            return adminId;
        }
    }
}
