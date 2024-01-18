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









        private void btn_Logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

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




        #region Functions

        private void Products_Click_1(object sender, EventArgs e)
        {
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


        #endregion  



        #region SideBarMenu

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


        #endregion


       
    }
}
