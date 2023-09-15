using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Inventory
{
    public partial class HomeFrom : Form
    {


        public HomeFrom()
        {
            InitializeComponent();

        }


        /////////////////////////////// SQL Connect //////////////////////////////////////////

        string connectionString = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;



        private void HomeFrom_Load(object sender, EventArgs e)
        {

        }





        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {


            LoginForm login = new LoginForm();
            login.Show(); // Zobrazit přihlašovací formulář
            this.Hide(); // Skrýt aktuální formulář (HomeFrom)
        }



        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }




        private void Products_Click_1(object sender, EventArgs e)
        {
            // Předpokládáme, že máte způsob, jakým získáte informace o kategoriích.
            bool categoriesExist = CheckIfCategoriesExist();

            if (categoriesExist)
            {
                ManageProducts prod = new ManageProducts();
                prod.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("There are no categories. Add categories first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void Categories_Click_1(object sender, EventArgs e)
        {
            ManageCategories categories = new ManageCategories();
            categories.Show();
            this.Hide();
        }

        private void Users_Click_1(object sender, EventArgs e)
        {
            ManageUser users = new ManageUser();
            users.Show();
            this.Hide();
        }

        private void Orders_Click_1(object sender, EventArgs e)
        {
            ManageOrders orders = new ManageOrders();
            orders.Show();
            this.Hide();
        }

        private void Customers_Click_1(object sender, EventArgs e)
        {
            ManageCustomers customers = new ManageCustomers();
            customers.Show();
            this.Hide();
        }




    }
}
