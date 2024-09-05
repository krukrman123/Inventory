using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite; 

namespace Inventory
{
    public partial class ManageProductsAdd : Form
    {


        /////////////////////////////// SQLite Connect //////////////////////////////////////////

        string connectionString = $@"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "inventory.db")};Version=3;";
        string ProdId = "";

        public ManageProductsAdd()
        {
            InitializeComponent();
        }

        private void ManageProductsAdd_Load(object sender, EventArgs e)
        {
            fillCategory();
            selectProducts();
            GenerateId();
        }

        private void productIDTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        #region Functions

        void fillCategory()
        {
            using (SQLiteConnection Con = new SQLiteConnection(connectionString))
            {
                string query = "SELECT * FROM CategoryTbl";
                try
                {
                    Con.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(query, Con))
                    {
                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add("CatName", typeof(string));
                            dt.Load(rdr);
                            CatCombo.ValueMember = "CatName";
                            CatCombo.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                    {
                        Con.Close();
                    }
                }
            }
        }

        void GenerateId()
        {
            using (SQLiteConnection Con = new SQLiteConnection(connectionString))
            {
                try
                {
                    Con.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT (ProdId) FROM ProductTbl", Con))
                    {
                        int i = Convert.ToInt32(cmd.ExecuteScalar());
                        i++;
                        productIDTB.Text = ProdId + i.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                    {
                        Con.Close();
                    }
                }
            }
        }



        void selectProducts()
        {
            using (SQLiteConnection Con = new SQLiteConnection(connectionString))
            {
                try
                {
                    Con.Open();
                    string Myquery = "SELECT * FROM ProductTbl";

                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(Myquery, Con))
                    {
                        var ds = new DataSet();
                        da.Fill(ds);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }





        #endregion

        #region ManageProductSystem

        public void insert(string filename, byte[] image)
        {
            using (SQLiteConnection Con = new SQLiteConnection(connectionString))
            {
                string myQuery = "INSERT INTO ProductTbl(ProdFile, ProdImage) VALUES (@ProdFile, @ProdImage)";
                using (SQLiteCommand cmd = new SQLiteCommand(myQuery, Con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ProdFile", filename);
                    cmd.Parameters.AddWithValue("@ProdImage", image);

                    try
                    {
                        Con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productIDTB.Text) || string.IsNullOrWhiteSpace(productNameTB.Text) ||
                string.IsNullOrWhiteSpace(productQTYTB.Text) || string.IsNullOrWhiteSpace(productPriceTB.Text) ||
                string.IsNullOrWhiteSpace(descriptionTB.Text) || string.IsNullOrWhiteSpace(FileNameTB.Text) ||
                string.IsNullOrWhiteSpace(textProductTb.Text) || PictureBox.Image == null)
            {
                MessageBox.Show("Please fill in all the required information.");
                return;
            }

            try
            {
                using (SQLiteConnection Con = new SQLiteConnection(connectionString))
                {
                    Con.Open();

                    SQLiteCommand checkIdCmd = new SQLiteCommand("SELECT COUNT(*) FROM ProductTbl WHERE ProdId = @ProdId", Con);
                    checkIdCmd.Parameters.AddWithValue("@ProdId", productIDTB.Text);
                    int count = Convert.ToInt32(checkIdCmd.ExecuteScalar());

                    if (count == 1)
                    {
                        MessageBox.Show("Product with the same ID already exists.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string insertQuery = "INSERT INTO ProductTbl (ProdId, ProdName, ProdQty, ProdPrice, ProdDesc, ProdCat, ProdFile, ProdText, ProdImage) VALUES (@ProdId, @ProdName, @ProdQty, @ProdPrice, @ProdDesc, @ProdCat, @ProdFile, @ProdText, @ProdImage)";

                    using (SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, Con))
                    {
                        insertCmd.Parameters.AddWithValue("@ProdId", productIDTB.Text);
                        insertCmd.Parameters.AddWithValue("@ProdName", productNameTB.Text);
                        insertCmd.Parameters.AddWithValue("@ProdQty", productQTYTB.Text);
                        insertCmd.Parameters.AddWithValue("@ProdPrice", productPriceTB.Text);
                        insertCmd.Parameters.AddWithValue("@ProdDesc", descriptionTB.Text);
                        insertCmd.Parameters.AddWithValue("@ProdCat", CatCombo.SelectedValue.ToString());
                        insertCmd.Parameters.AddWithValue("@ProdFile", FileNameTB.Text);
                        insertCmd.Parameters.AddWithValue("@ProdText", textProductTb.Text);

                        using (MemoryStream stream = new MemoryStream())
                        {
                            PictureBox.Image.Save(stream, ImageFormat.Jpeg);
                            byte[] pic = stream.ToArray();
                            insertCmd.Parameters.AddWithValue("@ProdImage", pic);
                        }

                        string folderPath = "Photo";
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }

                        string fname = productNameTB.Text + ".jpg";
                        string pathstring = Path.Combine("Photo", fname);

                        PictureBox.Image.Save(pathstring);

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Product Successfully Added");
                        MessageBox.Show("Current Directory: " + Directory.GetCurrentDirectory());
                    }
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image Files(*.jpg;*.jpeg)| *.jpg;*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (Image image = Image.FromFile(ofd.FileName))
                    {
                        PictureBox.Image = new Bitmap(image);
                        FileNameTB.Text = ofd.FileName;
                    }
                }
            }
        }
        #endregion
    }
}
