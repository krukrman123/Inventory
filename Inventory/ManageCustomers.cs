using System;
using System.Data;
using System.Data.SQLite; // Použití SQLite
using System.Windows.Forms;

namespace Inventory
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            selectCustomers(); // Opraveno na selectCustomers
            customerIdTB.Text = GenerateCustomerId();
        }

        // SQLite connection string
        string connectionString = "Data Source=inventory.db;Version=3;";

        private void btn_home_Click(object sender, EventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
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
        void selectCustomers() // Opraveno na selectCustomers
        {
            try
            {
                using (SQLiteConnection Con = new SQLiteConnection(connectionString))
                {
                    Con.Open();
                    string Myquery = "SELECT * FROM CustomerTbl";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(Myquery, Con);
                    SQLiteCommandBuilder builder = new SQLiteCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    CustomerGV.DataSource = ds.Tables[0];
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
                using (SQLiteConnection Con = new SQLiteConnection(connectionString))
                {
                    Con.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(CatId) FROM CategoryTbl", Con);
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

        #region DataGridViewMenu

        private void CustomerGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = CustomerGV.Rows[e.RowIndex];
                string customerId = selectedRow.Cells[0].Value.ToString();
                customerIdTB.Text = customerId;
                customerNameTB.Text = selectedRow.Cells[1].Value.ToString();
                customerPhoneTB.Text = selectedRow.Cells[2].Value.ToString();

                using (SQLiteConnection Con = new SQLiteConnection(connectionString))
                {
                    Con.Open();

                    // Get the number of orders
                    string orderCountQuery = "SELECT COUNT(*) FROM OrderTbl WHERE CustId = @CustomerId";
                    using (SQLiteCommand cmd = new SQLiteCommand(orderCountQuery, Con))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);
                        long orderCount = (long)cmd.ExecuteScalar();
                        OrderLabel.Text = orderCount.ToString();
                    }

                    // Get the total amount
                    string totalAmountQuery = "SELECT SUM(TotalAmt) FROM OrderTbl WHERE CustId = @CustomerId";
                    using (SQLiteCommand cmd = new SQLiteCommand(totalAmountQuery, Con))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);
                        object totalAmount = cmd.ExecuteScalar();
                        AmoutLabel.Text = totalAmount != DBNull.Value ? Convert.ToDecimal(totalAmount).ToString("C") : "0";
                    }

                    // Get the last order date
                    string lastOrderDateQuery = "SELECT MAX(OrderDate) FROM OrderTbl WHERE CustId = @CustomerId";
                    using (SQLiteCommand cmd = new SQLiteCommand(lastOrderDateQuery, Con))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);
                        object lastOrderDate = cmd.ExecuteScalar();
                        DateLabel.Text = lastOrderDate != DBNull.Value ? Convert.ToDateTime(lastOrderDate).ToShortDateString() : "N/A";
                    }
                }
            }
        }

        #endregion

        #region ManageCustomerSystem

        private void btn_add_Click(object sender, EventArgs e)
        {
            string CustId = customerIdTB.Text;
            string CustName = customerNameTB.Text;
            string CustPhone = customerPhoneTB.Text;

            if (string.IsNullOrWhiteSpace(CustId) || string.IsNullOrWhiteSpace(CustName) || string.IsNullOrWhiteSpace(CustPhone))
            {
                MessageBox.Show("Please fill in all information.");
                return;
            }

            try
            {
                using (SQLiteConnection Con = new SQLiteConnection(connectionString))
                {
                    Con.Open();

                    SQLiteCommand checkCmd = new SQLiteCommand("SELECT COUNT(*) FROM CustomerTbl WHERE CustId = @CustomerId", Con);
                    checkCmd.Parameters.AddWithValue("@CustomerId", CustId);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count == 1)
                    {
                        MessageBox.Show("Customer ID already exists.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string register = "INSERT INTO CustomerTbl (CustId, CustName, CustPhone) VALUES (@CustomerId, @CustomerName, @CustomerPhone)";
                    SQLiteCommand cmd = new SQLiteCommand(register, Con);
                    cmd.Parameters.AddWithValue("@CustomerId", CustId);
                    cmd.Parameters.AddWithValue("@CustomerName", CustName);
                    cmd.Parameters.AddWithValue("@CustomerPhone", CustPhone);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Customer Successfully Added");
                selectCustomers();
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
                using (SQLiteConnection Con = new SQLiteConnection(connectionString))
                {
                    Con.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(CustId) FROM CustomerTbl", Con);
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string customerId = customerIdTB.Text;
            string customerName = customerNameTB.Text;
            string customerPhone = customerPhoneTB.Text;

            if (string.IsNullOrWhiteSpace(customerId))
            {
                MessageBox.Show("Enter Customer ID");
            }
            else if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("Enter Customer Name");
            }
            else if (string.IsNullOrWhiteSpace(customerPhone))
            {
                MessageBox.Show("Enter Phone Number");
            }
            else
            {
                try
                {
                    using (SQLiteConnection Con = new SQLiteConnection(connectionString))
                    {
                        Con.Open();

                        SQLiteCommand cmd = new SQLiteCommand("UPDATE CustomerTbl SET CustName = @CustName, CustPhone = @CustPhone WHERE CustId = @CustId", Con);
                        cmd.Parameters.AddWithValue("@CustId", customerId);
                        cmd.Parameters.AddWithValue("@CustName", customerName);
                        cmd.Parameters.AddWithValue("@CustPhone", customerPhone);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer Successfully Updated");
                        }
                        else
                        {
                            MessageBox.Show("Customer not found or not updated. Make sure the ID and Phone are correct.");
                        }
                    }

                    selectCustomers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            string customerId = customerIdTB.Text;

            if (string.IsNullOrWhiteSpace(customerId))
            {
                MessageBox.Show("Enter Customer ID");
            }
            else
            {
                try
                {
                    using (SQLiteConnection Con = new SQLiteConnection(connectionString))
                    {
                        Con.Open();

                        SQLiteCommand checkCmd = new SQLiteCommand("SELECT COUNT(*) FROM CustomerTbl WHERE CustId = @CustomerId", Con);
                        checkCmd.Parameters.AddWithValue("@CustomerId", customerId);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count == 1)
                        {
                            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM CustomerTbl WHERE CustId = @CustomerId", Con);
                            cmd.Parameters.AddWithValue("@CustomerId", customerId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Customer Successfully Deleted");
                                selectCustomers();
                            }
                            else
                            {
                                MessageBox.Show("Customer not deleted. Make sure the ID is correct.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Customer with this ID does not exist.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        #endregion

        #region TextArea
        private void customerIdTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void customerPhoneTB_KeyPress(object sender, KeyPressEventArgs e)
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
            this.Hide();
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
