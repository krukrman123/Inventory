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
            populate();
            categoryId_TB.Text = GenerateCustomerId();
        }



        /////////////////////////////// SQL Connect //////////////////////////////////////////

        string connectionString = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;




        ///////////////////////////////////////////     Fuinctions  ///////////////////////////////////////////


        void populate()
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



        /////////////////////////////////// Choose All Colum function ////////////////////////////////////////////////////////

        private void CategoryGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            categoryId_TB.Text = CategoryGV.SelectedRows[0].Cells[0].Value.ToString();
            categoryName_TB.Text = CategoryGV.SelectedRows[0].Cells[1].Value.ToString();


        }


        ///////////////////////////////////////////// Buttons USERS LIST /////////////////////////////////////////////////////////////////////////////





        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
            this.Hide();
        }

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
                populate();
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
                populate();
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

                    // Ověření, zda kategorie s daným ID již existuje
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM CategoryTbl WHERE CatId = @CategoryId", Con);
                    checkCmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 1)
                    {
                        MessageBox.Show("Category ID already exists.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Přidání nové kategorie
                    SqlCommand cmd = new SqlCommand("INSERT INTO CategoryTbl (CatId, CatName) VALUES (@CategoryId, @CategoryName)", Con);
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Category Successfully Added");
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void label9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void category_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

        }


    }
}

