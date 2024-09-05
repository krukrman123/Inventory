using System;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Inventory
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        /////////////////////////////// SQLite Connect //////////////////////////////////////////

        string connectionString = "Data Source=inventory.db;Version=3;";






        #region RegisterSystem

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private void REGISTER_Click(object sender, EventArgs e)
        {
            string Uname = UsernameTB.Text;
            string Ufullname = FullNameTB.Text;
            string Upassword = PasswordTB.Text;
            string Uphone = TelephoneTB.Text;

            if (string.IsNullOrWhiteSpace(Uname) || string.IsNullOrWhiteSpace(Ufullname) || string.IsNullOrWhiteSpace(Upassword) || string.IsNullOrWhiteSpace(Uphone))
            {
                MessageBox.Show("Please fill in all information correctly.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string hashedPassword = HashPassword(Upassword); // Získání hashe hesla

                using (SQLiteConnection Con = new SQLiteConnection(connectionString))
                {
                    Con.Open();

                    // Ověření, zda uživatel s daným jménem již existuje
                    SQLiteCommand checkCmd = new SQLiteCommand("SELECT COUNT(*) FROM UserTbl WHERE Uname = @Username", Con);
                    checkCmd.Parameters.AddWithValue("@Username", Uname);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count == 1)
                    {
                        MessageBox.Show("Account already exists.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Přidání nového uživatele s hashem hesla
                    string register = "INSERT INTO UserTbl (Uname, Ufullname, Upassword, Uphone) VALUES (@Username, @FullName, @Password, @Telephone)";
                    SQLiteCommand cmd = new SQLiteCommand(register, Con);
                    cmd.Parameters.AddWithValue("@Username", Uname);
                    cmd.Parameters.AddWithValue("@FullName", Ufullname);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword); // Použití hashe hesla
                    cmd.Parameters.AddWithValue("@Telephone", Uphone);
                    cmd.ExecuteNonQuery();
                } // Po skončení using bloku se automaticky uzavře připojení.

                ResetText();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();

                MessageBox.Show("Your account has been created successfully.", "Registration succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        #endregion

        #region Exit/Minimized

        private void ExitLabel_TB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizedLabel_TB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        private void BackToRegister_Click(object sender, EventArgs e)
        {
            LoginForm Load = new LoginForm();
            this.Hide();
            Load.Show();
        }

        private void ShowPassword_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword_CheckBox.Checked == true)
            {
                PasswordTB.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTB.UseSystemPasswordChar = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            UsernameTB.Text = "";
            FullNameTB.Text = "";
            PasswordTB.Text = "";
            TelephoneTB.Text = "";
        }

        private void TelephoneTB_TextChanged(object sender, EventArgs e)
        {
            string text = TelephoneTB.Text;

            // Only numbers and Backspace are allowed
            string cleanedText = new string(text.Where(char.IsDigit).ToArray());

            // Update the text in the TextBox
            if (text != cleanedText)
            {
                TelephoneTB.Text = cleanedText;
                TelephoneTB.SelectionStart = cleanedText.Length;
            }
        }

        private void MinizedApp_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
