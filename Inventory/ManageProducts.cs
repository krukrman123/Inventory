using System;
using System.Data;
using System.Data.SQLite; 
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventory
{
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();

            ProductGV.RowTemplate.Height = 150;
            ((DataGridViewImageColumn)ProductGV.Columns[ProductGV.Columns.Count - 1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            fillCategory();
            selectProducts();
        }

        /////////////////////////////// SQLite Connect //////////////////////////////////////////

        ManageProductsView myformEdit = new ManageProductsView();
        ManageProductsAdd myformAdd = new ManageProductsAdd();

        string connectionString = $@"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "inventory.db")};Version=3;";

        #region Exit/Minimized

        private void MinimazedApp_Label_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitApp_Label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Functions

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
                    searchCombo_Products.ValueMember = "CatName";
                    searchCombo_Products.DataSource = dt;
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

        void filterByCategory()
        {
            try
            {
                using (SQLiteConnection Con = new SQLiteConnection(connectionString))
                {
                    Con.Open();
                    string Myquery = "SELECT * FROM ProductTbl WHERE ProdCat=@Category";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(Myquery, Con);
                    da.SelectCommand.Parameters.AddWithValue("@Category", searchCombo_Products.SelectedValue.ToString());
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

        private bool CheckIfCategoriesExist()
        {
            try
            {
                using (SQLiteConnection Con = new SQLiteConnection(connectionString))
                {
                    Con.Open();
                    string query = "SELECT COUNT(*) FROM CategoryTbl";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, Con))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
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

        private void ProductGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductGV.SelectedRows.Count > 0)
            {
                myformEdit.productIDTB.Text = ProductGV.SelectedRows[0].Cells[0].Value.ToString();
                myformEdit.productNameTB.Text = ProductGV.SelectedRows[0].Cells[1].Value.ToString();
                myformEdit.productQTYTB.Text = ProductGV.SelectedRows[0].Cells[2].Value.ToString();
                myformEdit.productPriceTB.Text = ProductGV.SelectedRows[0].Cells[3].Value.ToString();
                myformEdit.descriptionTB.Text = ProductGV.SelectedRows[0].Cells[4].Value.ToString();
                myformEdit.CatCombo.SelectedValue = ProductGV.SelectedRows[0].Cells[5].Value.ToString();
                myformEdit.FileNameTB.Text = ProductGV.SelectedRows[0].Cells[6].Value.ToString();
                myformEdit.textProductTb.Text = ProductGV.SelectedRows[0].Cells[7].Value.ToString();

                byte[] image = Encoding.ASCII.GetBytes(ProductGV.SelectedRows[0].Cells[8].Value.ToString());



                if (image == null)
                    myformEdit.PictureBox.Image = null;
                if (!DBNull.Value.Equals(ProductGV.SelectedRows[0].Cells[8].Value)) ;
                else
                    return;

                {

                    var data = (byte[])(ProductGV.SelectedRows[0].Cells[8].Value);
                    var stream = new MemoryStream(data);
                    myformEdit.PictureBox.Image = Image.FromStream(stream);

                }

                myformEdit.ShowDialog();
                selectProducts();
            }
        }

        #endregion

        #region ButtonUserList

        private void btn_home_Click(object sender, EventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
            this.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            myformAdd.ShowDialog();
            selectProducts();
        }

        private void btn_sreach_Click(object sender, EventArgs e)
        {
            filterByCategory();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            selectProducts();
        }

        #endregion

        #region SideBarMenu

        private void CategoriesMenu_BT_Click(object sender, EventArgs e)
        {
            CategoriesMenu_BT.BackColor = Color.LightBlue;

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
