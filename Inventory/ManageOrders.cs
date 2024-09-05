using System;
using System.Data;
using System.Data.SQLite; 
using System.Windows.Forms;

namespace Inventory
{
    public partial class ManageOrders : Form
    {
        #region attributes

        int sum = 0;
        int numericValue;
        int num = 0;
        int uprice, stock, flag = 0;
        string product = "";
        string OrdeId = "";
        bool found = false;
        private BindingSource bindingSource = new BindingSource();

        #endregion

        public ManageOrders()
        {
            InitializeComponent();
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            selectProducts();
            populateProducts();
            fillCategory();
            GenerateId();
            tableColums();

            OrderGV.DataSource = table;
        }

        DataTable table = new DataTable();

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

        /////////////////////////////// SQLite Connect //////////////////////////////////////////

        string connectionString = $@"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "inventory.db")};Version=3;";

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

        #region Functions

        void GenerateId()
        {
            try
            {
                using (SQLiteConnection Con = new SQLiteConnection(connectionString))
                {
                    Con.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(OrderId) FROM OrderTbl", Con);
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

        void selectProducts()
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
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void fillCategory()
        {
            try
            {
                using (SQLiteConnection Con = new SQLiteConnection(connectionString))
                {
                    string query = "SELECT * FROM CategoryTbl";
                    SQLiteCommand cmd = new SQLiteCommand(query, Con);
                    SQLiteDataReader rdr;
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
                using (SQLiteConnection Con = new SQLiteConnection(connectionString))
                {
                    Con.Open();
                    string Myquery = "SELECT * FROM ProductTbl";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(Myquery, Con);
                    SQLiteCommandBuilder builder = new SQLiteCommandBuilder(da);
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
                using (SQLiteConnection Con = new SQLiteConnection(connectionString))
                {
                    Con.Open();
                    string query = "UPDATE ProductTbl SET ProdQty = @NewQty WHERE ProdId = @Id";
                    SQLiteCommand cmd = new SQLiteCommand(query, Con);
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

        private void UpdateDataGridView()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(UpdateDataGridView));
                return;
            }

            bindingSource.ResetBindings(false);
            OrderGV.Refresh();
        }

        #endregion

        #region DataGripViewMenu

        private void CustomerGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIdTB.Text = CustomerGV.SelectedRows[0].Cells[0].Value.ToString();
            CustNameTB.Text = CustomerGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void ProductGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductGV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ProductGV.SelectedRows[0];

                if (selectedRow.Cells[1].Value != DBNull.Value && selectedRow.Cells[1].Value != null)
                {
                    product = selectedRow.Cells[1].Value.ToString();
                }
                else
                {
                    product = string.Empty;
                }

                if (selectedRow.Cells[2].Value != DBNull.Value && selectedRow.Cells[2].Value != null)
                {
                    stock = Convert.ToInt32(selectedRow.Cells[2].Value);
                }
                else
                {
                    stock = 0;
                }

                if (selectedRow.Cells[3].Value != DBNull.Value && selectedRow.Cells[3].Value != null)
                {
                    uprice = Convert.ToInt32(selectedRow.Cells[3].Value);
                }
                else
                {
                    uprice = 0;
                }

                flag = 1;
            }
            else
            {
                MessageBox.Show("Enter The Product");
            }
        }

        #endregion

        #region ManageOrdersSystem

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
                num = table.Rows.Count + 1;
                table.Rows.Add(num, product, quantity, uprice, totalPrice);
            }

            sum = table.AsEnumerable().Sum(row => Convert.ToInt32(row["TotPrice"]));
            TotAmout.Text = sum.ToString("C");

            UpdateDataGridView();

            flag = 0;
        }


      

        private void DeductStock(string product, int quantity)
        {
            using (SQLiteConnection Con = new SQLiteConnection(connectionString))
            {
                Con.Open();
                string query = "UPDATE ProductTbl SET ProdQty = ProdQty - @quantity WHERE ProdName = @product";
                using (SQLiteCommand cmd = new SQLiteCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@product", product);
                    cmd.ExecuteNonQuery();
                }
            }
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
                using (SQLiteConnection Con = new SQLiteConnection(connectionString))
                {
                    Con.Open();

                    SQLiteCommand checkIdCmd = new SQLiteCommand("SELECT COUNT(*) FROM OrderTbl WHERE OrderId = @OrderId", Con);
                    checkIdCmd.Parameters.AddWithValue("@OrderId", OrderIdTB.Text);
                    int count = Convert.ToInt32(checkIdCmd.ExecuteScalar());

                    if (count == 1)
                    {
                        MessageBox.Show("Order with the same ID already exists.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Debug outputs
                    Console.WriteLine("OrderId: " + OrderIdTB.Text);
                    Console.WriteLine("CustomerId: " + CustomerIdTB.Text);
                    Console.WriteLine("CustName: " + CustNameTB.Text);
                    Console.WriteLine("OrderDate: " + orderDate.Value);
                    Console.WriteLine("TotalAmt (numericValue): " + sum);

                    SQLiteCommand cmd = new SQLiteCommand("INSERT INTO OrderTbl (OrderId, CustId, CustName, OrderDate, TotalAmt) VALUES (@OrderId, @CustId, @CustName, @OrderDate, @TotalAmt)", Con);
                    cmd.Parameters.AddWithValue("@OrderId", OrderIdTB.Text);
                    cmd.Parameters.AddWithValue("@CustId", CustomerIdTB.Text);
                    cmd.Parameters.AddWithValue("@CustName", CustNameTB.Text);
                    cmd.Parameters.AddWithValue("@OrderDate", orderDate.Value);
                    cmd.Parameters.AddWithValue("@TotalAmt", sum);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully");
                    OrderGV.Refresh();

                }
                HomeFrom home = new HomeFrom();
                home.Show();
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection Con = new SQLiteConnection(connectionString))
                {
                    Con.Open();
                    string Myquery = "SELECT * FROM ProductTbl WHERE ProdCat = @Category";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(Myquery, Con);
                    da.SelectCommand.Parameters.AddWithValue("@Category", searchCombo.SelectedValue.ToString());
                    SQLiteCommandBuilder builder = new SQLiteCommandBuilder(da);
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

        #endregion

        #region TextArea

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

        private void clear_BTN_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in table.Rows)
            {
                string product = row["Product"].ToString();
                int quantity = Convert.ToInt32(row["Quantity"]);

                RestoreStock(product, quantity);
            }

            table.Clear();
            TotAmout.Text = "0";
            UpdateDataGridView();
        }

        private void RestoreStock(string product, int quantity)
        {
            using (SQLiteConnection Con = new SQLiteConnection(connectionString))
            {
                Con.Open();
                string query = "UPDATE ProductTbl SET ProdQty = ProdQty + @quantity WHERE ProdName = @product";
                using (SQLiteCommand cmd = new SQLiteCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@product", product);
                    cmd.ExecuteNonQuery();
                }
            }
        }



    }
}
