
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;




namespace Inventory
{




    public partial class LoginForm : Form
    {

        /////////////////////////////// SQL Connect //////////////////////////////////////////



        string connectionString = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;



     

        public LoginForm()
        {
            InitializeComponent();
        }






        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel_Login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                PasswordTB.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTB.UseSystemPasswordChar = true;
            }

        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;

            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM UserTbl WHERE Uname=@username AND Upassword=@password", Con);
                cmd.Parameters.AddWithValue("@username", UsernameTB.Text);
                cmd.Parameters.AddWithValue("@password", PasswordTB.Text);

                int userCount = (int)cmd.ExecuteScalar();

                if (userCount == 1)
                {
                    // Přihlášení bylo úspěšné, takže otevřete Loading_Form.
                    Loading_Form loadForm = new Loading_Form();
                    this.Hide();
                    loadForm.ShowDialog(); // Otevřete Loading_Form modálně
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
            }
        }









        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            UsernameTB.Text = "";
            PasswordTB.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CreateNewAccount_BT_Click(object sender, EventArgs e)
        {
            this.Hide(); // Skryjte aktuální přihlašovací formulář
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog(); // Zobrazte formulář pro registraci modálně

            // Po dokončení registrace a zavření formuláře pro registraci můžete tento formulář znovu zobrazit.
        }
    }
}
