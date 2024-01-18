using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Cryptography;

namespace Inventory
{
    public partial class LoginForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        private const string UsersTableName = "UserTbl";
        private const string UsernameColumn = "Uname";
        private const string PasswordColumn = "Upassword";

        public LoginForm()
        {
            InitializeComponent();
        }


        #region LoginSystem


        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }



        private void LOGIN_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string hashedPassword = HashPassword(PasswordTB.Text);

                string query = $"SELECT COUNT(*) FROM {UsersTableName} WHERE {UsernameColumn}=@username AND {PasswordColumn}=@password";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", Username_TB.Text);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);

                    int userCount = (int)cmd.ExecuteScalar();

                    if (userCount == 1)
                    {
                        Loading_Form loadForm = new Loading_Form();
                        this.Hide();
                        loadForm.ShowDialog(); 
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password");
                    }
                }
            }
        }


        #endregion



        #region Buttons

        private void Password_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTB.UseSystemPasswordChar = !Password_CheckBox.Checked;

        }



        private void btn_clear_Click(object sender, EventArgs e)
        {
            Username_TB.Text = "";
            PasswordTB.Text = "";
        }



        private void CreateNewAccount_BT_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        #endregion


        #region Exit/Minized


        private void MinizedApp_Label_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitApp_Label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion

     

     
    }
}
