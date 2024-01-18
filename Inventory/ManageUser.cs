using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using Microsoft.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Configuration;
using Microsoft.VisualBasic.ApplicationServices;



namespace Inventory
{
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }


        private void ManageUser_Load(object sender, EventArgs e)
        {
            selectProducts();
        }
        /////////////////////////////// SQL Connect //////////////////////////////////////////

        string connectionString = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;





        #region Fuinctions

        void selectProducts()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    string query = "SELECT * FROM UserTbl";
                    SqlDataAdapter da = new SqlDataAdapter(query, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    UsersGV.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private bool CheckIfCategoriesExist()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(CatId) FROM CategoryTbl", Con);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking for categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }






        #endregion


        #region DataGripViewInfo
        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            userNameTB.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            fullNameTB.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            passwordTB.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
            TelephoneTB.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();

        }

        #endregion


        #region Exit/Minized

        private void ExitAapp_Label_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void MinimizedApp_Label_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }


        private void btn_home_Click(object sender, EventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
            this.Close();
        }


        #endregion


        #region DatabaseEdit

        private void btn_add_Click(object sender, EventArgs e)
        {
            string userName = userNameTB.Text;
            string fullName = fullNameTB.Text;
            string password = passwordTB.Text;
            string telephone = TelephoneTB.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(telephone))
            {
                MessageBox.Show("Please fill in all information correctly.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    // Check if the phone number already exists in the database
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM UserTbl WHERE Uphone = @Telephone", Con);
                    checkCmd.Parameters.AddWithValue("@Telephone", telephone);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 1)
                    {
                        MessageBox.Show("The phone number already exists.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Add a new user
                    string addUserQuery = "INSERT INTO UserTbl (Uname, Ufullname, Upassword, Uphone) VALUES (@UserName, @FullName, @Password, @Telephone)";
                    SqlCommand cmd = new SqlCommand(addUserQuery, Con);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Telephone", telephone);
                    cmd.ExecuteNonQuery();
                }

                ResetText();
                selectProducts();

                MessageBox.Show("User added successfully.", "Successful registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            string telephone = TelephoneTB.Text;

            if (string.IsNullOrWhiteSpace(telephone))
            {
                MessageBox.Show("Enter the user's phone number.");
                return;
            }

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    // Check if the user with the given phone number exists
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM UserTbl WHERE Uphone = @Telephone", Con);
                    checkCmd.Parameters.AddWithValue("@Telephone", telephone);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("The user with the entered phone number does not exist.", "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Delete the user
                    string deleteQuery = "DELETE FROM UserTbl WHERE Uphone = @Telephone";
                    SqlCommand cmd = new SqlCommand(deleteQuery, Con);
                    cmd.Parameters.AddWithValue("@Telephone", telephone);
                    cmd.ExecuteNonQuery();
                }

                ResetText();
                selectProducts();

                MessageBox.Show("The user was successfully deleted.", "The deletion was successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void btn_edit_Click(object sender, EventArgs e)
        {
            string username = userNameTB.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Enter the user's username.");
                return;
            }

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    // Verify that a user with the given username exists
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM UserTbl WHERE Uname = @Uname", Con);
                    checkCmd.Parameters.AddWithValue("@Uname", username);
                    int userCount = (int)checkCmd.ExecuteScalar();

                    if (userCount == 0)
                    {
                        MessageBox.Show("The user with the specified username does not exist.", "Update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Update the user
                    string updateQuery = "UPDATE UserTbl SET Ufullname = @Ufullname, Upassword = @Upassword, Uphone = @Uphone WHERE Uname = @Uname";
                    SqlCommand cmd = new SqlCommand(updateQuery, Con);
                    cmd.Parameters.AddWithValue("@Uname", username);
                    cmd.Parameters.AddWithValue("@Ufullname", fullNameTB.Text);
                    cmd.Parameters.AddWithValue("@Upassword", passwordTB.Text);
                    cmd.Parameters.AddWithValue("@Uphone", TelephoneTB.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User Successfully Updated", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        selectProducts();
                    }
                    else
                    {
                        MessageBox.Show("User update failed.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion


        #region SideBarMenu

        private void CategoriesMenu_BT_Click(object sender, EventArgs e)
        {
            ManageCategories categories = new ManageCategories();
            categories.Show();
            this.Close();

        }

        private void CustomerMenu_BT_Click(object sender, EventArgs e)
        {
            ManageCustomers customers = new ManageCustomers();
            customers.Show();
            this.Close();

        }

        private void OrderMenu_BT_Click(object sender, EventArgs e)
        {
            ManageOrders orders = new ManageOrders();
            orders.Show();
            this.Close();

        }

        private void ProductsMenu_BT_Click(object sender, EventArgs e)
        {
            bool categoriesExist = CheckIfCategoriesExist();

            if (categoriesExist)
            {
                ManageProducts prod = new ManageProducts();
                prod.Show();
                this.Close();


            }
            else
            {
                MessageBox.Show("There are no categories. Add categories first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UserMenu_BT_Click(object sender, EventArgs e)
        {
            ManageUser users = new ManageUser();
            users.Show();
            this.Close();


        }


        #endregion


    }
}

