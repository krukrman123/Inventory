using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Configuration;






namespace Inventory
{
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        /////////////////////////////// Top Menu //////////////////////////////////////////

        private void label_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /////////////////////////////// SQL Connect //////////////////////////////////////////



        string connectionString = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;






        ///////////////////////////////////////////     Main Form  ///////////////////////////////////////////

        private void ManageOrders_Load(object sender, EventArgs e)
        {

            populate();
            populateProducts();
            fillCategory();
            GenerateId();
            tableColums();



            OrderGV.DataSource = table;

        }

        DataTable table = new DataTable();



        ///////////////////////////////////////////     Data Types  ///////////////////////////////////////////
        int sum = 0;
        int num = 0;
        int uprice, totprice, qty;
        string product;
        int stock;
        int flag = 0;
        string OrdeId = "";
        bool found = false;







        ///////////////////////////////////////////     Fuinctions  ///////////////////////////////////////////
        void GenerateId()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(OrderId) FROM OrderTbl", Con);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    count++;
                    OrderIdTB.Text = count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void fillCategory()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM CategoryTbl";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    SqlDataReader rdr;
                    Con.Open();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("CatName", typeof(string));
                    rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                    searchCombo.ValueMember = "CatName";
                    searchCombo.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void populateProducts()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    string Myquery = "SELECT * FROM ProductTbl";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    ProductGV.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void updateProduct()
        {
            int id = Convert.ToInt32(ProductGV.SelectedRows[0].Cells[0].Value.ToString());
            int newQty = stock - Convert.ToInt32(productQtyTB.Text);

            if (newQty < 0)
            {
                MessageBox.Show("Operation Failed");
                return;
            }

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    string query = "UPDATE ProductTbl SET ProdQty = @NewQty WHERE ProdId = @Id";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@NewQty", newQty);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }

                populateProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void tableColums()
        {

            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Uprice", typeof(int));
            table.Columns.Add("TotPrice", typeof(int));

        }





        ///////////////////////////////////////////     DataGripView  ///////////////////////////////////////////


        private void CustomerGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIdTB.Text = CustomerGV.SelectedRows[0].Cells[0].Value.ToString();
            CustNameTB.Text = CustomerGV.SelectedRows[0].Cells[1].Value.ToString();
        }
        private void ProductGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            product = ProductGV.SelectedRows[0].Cells[1].Value.ToString();
            stock = Convert.ToInt32(ProductGV.SelectedRows[0].Cells[2].Value.ToString());
            uprice = Convert.ToInt32(ProductGV.SelectedRows[0].Cells[3].Value.ToString());

            flag = 1;

        }


        ///////////////////////////////////////////     Buttons  ///////////////////////////////////////////

        private void btn_OrderAdd_Click(object sender, EventArgs e)
        {
            if (productQtyTB.Text == "")
            {
                MessageBox.Show("Enter The Quantity of Products");
                return;
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select The Product");
                return;
            }
            else if (Convert.ToInt32(productQtyTB.Text) > stock)
            {
                MessageBox.Show("No Enough Stock Available");
                return;
            }

            int quantity = Convert.ToInt32(productQtyTB.Text);
            int totalPrice = quantity * uprice;

            bool productFound = false;
            foreach (DataRow row in table.Rows)
            {
                if (row["Product"].ToString() == product)
                {
                    // Produkt již existuje, aktualizujte množství a celkovou cenu
                    int existingQty = Convert.ToInt32(row["Quantity"]);
                    int newQty = existingQty + quantity;
                    int newTotalPrice = newQty * uprice;
                    row["Quantity"] = newQty;
                    row["TotPrice"] = newTotalPrice;
                    productFound = true;
                    break;
                }
            }

            if (!productFound)
            {
                num = num + 1;
                table.Rows.Add(num, product, quantity, uprice, totalPrice);
            }

            OrderGV.DataSource = table;
            flag = 0;

            sum += totalPrice;
            TotAmout.Text = sum.ToString();

            updateProduct();
        }







        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OrderIdTB.Text) || string.IsNullOrWhiteSpace(CustomerIdTB.Text) || string.IsNullOrWhiteSpace(CustNameTB.Text))
            {
                MessageBox.Show("Please fill in all the required information correctly.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(TotAmout.Text))
            {
                MessageBox.Show("Please choose the amount of the product.");
                return;
            }

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO OrderTbl (OrderId, CustId, CustName, OrderDate, TotalAmt) VALUES (@OrderId, @CustId, @CustName, @OrderDate, @TotalAmt)", Con);
                    cmd.Parameters.AddWithValue("@OrderId", OrderIdTB.Text);
                    cmd.Parameters.AddWithValue("@CustId", CustomerIdTB.Text);
                    cmd.Parameters.AddWithValue("@CustName", CustNameTB.Text);
                    cmd.Parameters.AddWithValue("@OrderDate", orderDate.Value);
                    cmd.Parameters.AddWithValue("@TotalAmt", TotAmout.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully");
                }

                populate();
                updateProduct();
                fillCategory();
                GenerateId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();

        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
            this.Hide();

        }

        private void OrderIdTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }


        private void productQTYTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void searchCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    string Myquery = "SELECT * FROM ProductTbl WHERE ProdCat = @Category";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    da.SelectCommand.Parameters.AddWithValue("@Category", searchCombo.SelectedValue.ToString());
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    ProductGV.DataSource = ds.Tables[0];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }

}
