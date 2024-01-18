using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }
        private void ManageCategories_Load(object sender, EventArgs e)
        {
            selectProducts();
            categoryId_TB.Text = GenerateCustomerId();
        }



        /////////////////////////////// SQL Connect //////////////////////////////////////////

        string connectionString = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;



        private void btn_home_Click(object sender, EventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
            this.Hide();
        }


        #region Functions

        void selectProducts()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    string Myquery = "SELECT * FROM CategoryTbl";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    CategoryGV.DataSource = ds.Tables[0];
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





        private string GenerateCustomerId()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(CatId) FROM CategoryTbl", Con);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    count++;
                    return count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while generating the ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        #endregion

        #region DataGripViewMenu

        private void CategoryGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            categoryId_TB.Text = CategoryGV.SelectedRows[0].Cells[0].Value.ToString();
            categoryName_TB.Text = CategoryGV.SelectedRows[0].Cells[1].Value.ToString();


        }


        #endregion

        #region ManageCategoriesSystem



        private void btn_delete_Click(object sender, EventArgs e)
        {
            string categoryId = categoryId_TB.Text;

            if (string.IsNullOrWhiteSpace(categoryId))
            {
                MessageBox.Show("Enter Category ID");
                return;
            }

            if (!CategoryExists(categoryId))
            {
                MessageBox.Show("Category with the specified ID does not exist.");
                return;
            }

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    string myquery = "DELETE FROM CategoryTbl WHERE CatId = @CategoryId";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Category Successfully deleted");
                selectProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool CategoryExists(string categoryId)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                string query = "SELECT COUNT(*) FROM CategoryTbl WHERE CatId = @CategoryId";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }





        private void btn_edit_Click(object sender, EventArgs e)
        {
            string categoryId = categoryId_TB.Text;
            string categoryName = categoryName_TB.Text;

            if (string.IsNullOrWhiteSpace(categoryId))
            {
                MessageBox.Show("Enter Category ID");
                return;
            }

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Enter Category Name");
                return;
            }

            if (!CategoryExists(categoryId))
            {
                MessageBox.Show("Category with the specified ID does not exist.");
                return;
            }

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    string myquery = "UPDATE CategoryTbl SET CatName = @CategoryName WHERE CatId = @CategoryId";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Category Successfully Updated");
                selectProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            string categoryId = categoryId_TB.Text;
            string categoryName = categoryName_TB.Text;

            if (string.IsNullOrWhiteSpace(categoryId) || string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Please fill in all information.");
                return;
            }

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    // Check if a category with the given ID already exists
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM CategoryTbl WHERE CatId = @CategoryId", Con);
                    checkCmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 1)
                    {
                        MessageBox.Show("Category ID already exists.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Add a new category
                    SqlCommand cmd = new SqlCommand("INSERT INTO CategoryTbl (CatId, CatName) VALUES (@CategoryId, @CategoryName)", Con);
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Category Successfully Added");
                selectProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        #endregion

        #region Exit/Minimized
        private void MinimizedApp_Label_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }


        private void ExitApp_Label_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        #endregion

        #region TextArea
        private void category_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
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

