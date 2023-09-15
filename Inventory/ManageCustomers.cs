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
using System.Data.Sql;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Configuration;


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
            populate();
            customerIdTB.Text = GenerateCustomerId();
        }




        /////////////////////////////// SQL Connect //////////////////////////////////////////

        string connectionString = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;


        private void label3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void label9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        ///////////////////////////////////////////     Fuinctions  ///////////////////////////////////////////

        void populate()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    string Myquery = "SELECT * FROM CustomerTbl";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
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


        /////////////////////////////////// Choose All Colum function ////////////////////////////////////////////////////////


        private void CustomerGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Získání dat z vybraného řádku DataGridView
                DataGridViewRow selectedRow = CustomerGV.Rows[e.RowIndex];

                // Získání hodnoty z buňky pro ID zákazníka
                string customerId = selectedRow.Cells[0].Value.ToString();

                // Zobrazení informací o zákazníkovi
                customerIdTB.Text = customerId;
                customerNameTB.Text = selectedRow.Cells[1].Value.ToString();
                customerPhoneTB.Text = selectedRow.Cells[2].Value.ToString();

                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    // Dotaz na počet objednávek zákazníka
                    string orderCountQuery = "SELECT COUNT(*) FROM OrderTbl WHERE CustId = @CustomerId";
                    using (SqlCommand cmd = new SqlCommand(orderCountQuery, Con))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);
                        int orderCount = (int)cmd.ExecuteScalar();
                        OrderLabel.Text = orderCount.ToString();
                    }

                    // Dotaz na celkovou částku objednávek zákazníka
                    string totalAmountQuery = "SELECT SUM(TotalAmt) FROM OrderTbl WHERE CustId = @CustomerId";
                    using (SqlCommand cmd = new SqlCommand(totalAmountQuery, Con))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);
                        object totalAmount = cmd.ExecuteScalar();
                        AmoutLabel.Text = totalAmount != DBNull.Value ? totalAmount.ToString() : "0";
                    }

                    // Dotaz na datum poslední objednávky zákazníka
                    string lastOrderDateQuery = "SELECT MAX(OrderDate) FROM OrderTbl WHERE CustId = @CustomerId";
                    using (SqlCommand cmd = new SqlCommand(lastOrderDateQuery, Con))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);
                        object lastOrderDate = cmd.ExecuteScalar();
                        DateLabel.Text = lastOrderDate != DBNull.Value ? ((DateTime)lastOrderDate).ToShortDateString() : "N/A";
                    }
                }
            }
        }




        ///////////////////////////////////////////// Buttons USERS LIST /////////////////////////////////////////////////////////////////////////////



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
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    // Ověření, zda zákazník s daným ID již existuje
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM CustomerTbl WHERE CustId = @CustomerId", Con);
                    checkCmd.Parameters.AddWithValue("@CustomerId", CustId);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 1)
                    {
                        MessageBox.Show("Customer ID already exists.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Přidání nového zákazníka
                    string register = "INSERT INTO CustomerTbl (CustId, CustName, CustPhone) VALUES (@CustomerId, @CustomerName, @CustomerPhone)";
                    SqlCommand cmd = new SqlCommand(register, Con);
                    cmd.Parameters.AddWithValue("@CustomerId", CustId);
                    cmd.Parameters.AddWithValue("@CustomerName", CustName);
                    cmd.Parameters.AddWithValue("@CustomerPhone", CustPhone);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Customer Successfully Added");
                populate();
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
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(CustId) FROM CustomerTbl", Con);
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
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();

                        // Aktualizace zákazníka
                        SqlCommand cmd = new SqlCommand("UPDATE CustomerTbl SET CustName = @CustName, CustPhone = @CustPhone  WHERE CustId = @CustId", Con);
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

                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
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
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();

                        // Ověření, zda zákazník s daným ID existuje
                        SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM CustomerTbl WHERE CustId = @CustomerId", Con);
                        checkCmd.Parameters.AddWithValue("@CustomerId", customerId);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 1)
                        {
                            // Pokud zákazník s daným ID existuje, provede se DELETE dotaz
                            SqlCommand cmd = new SqlCommand("DELETE FROM CustomerTbl WHERE CustId = @CustomerId", Con);
                            cmd.Parameters.AddWithValue("@CustomerId", customerId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Customer Successfully Deleted");
                                populate();
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


        private void btn_home_Click(object sender, EventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
            this.Hide();
        }



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
    }
}
