using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace Inventory
{
    public partial class ManageProductsAdd : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        string ProdId =  "";
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
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CategoryTbl";
                try
                {
                    Con.Open(); 

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        using (SqlDataReader rdr = cmd.ExecuteReader())
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
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                try
                {
                    Con.Open(); 

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT (ProdId) FROM ProductTbl", Con))
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
        //Select data from the database
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                try
                {
                    Con.Open();
                    string Myquery = "select * from ProductTbl";
                    using (SqlDataAdapter da = new SqlDataAdapter(Myquery, Con))
                    {
                        using (SqlCommandBuilder builder = new SqlCommandBuilder(da))
                        {
                            var ds = new DataSet();
                            da.Fill(ds);
                        }
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
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                string myQuery = "INSERT INTO ProductTbl(ProdFile,ProdImage) VALUES (@ProdFile,@ProdImage)";
                using (SqlCommand cmd = new SqlCommand(myQuery, Con))
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
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    SqlCommand checkIdCmd = new SqlCommand("SELECT COUNT(*) FROM ProductTbl WHERE ProdId = @ProdId", Con);
                    checkIdCmd.Parameters.AddWithValue("@ProdId", productIDTB.Text);
                    int count = Convert.ToInt32(checkIdCmd.ExecuteScalar());

                    if (count == 1)
                    {
                        MessageBox.Show("Product with the same ID already exists.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string insertQuery = "INSERT INTO ProductTbl (ProdId, ProdName, ProdQty, ProdPrice, ProdDesc, ProdCat, ProdFile, ProdText, ProdImage) VALUES (@ProdId, @ProdName, @ProdQty, @ProdPrice, @ProdDesc, @ProdCat, @ProdFile, @ProdText, @ProdImage)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, Con))
                    {
                        insertCmd.Parameters.AddWithValue("@ProdId", productIDTB.Text);
                        insertCmd.Parameters.AddWithValue("@ProdName", productNameTB.Text);
                        insertCmd.Parameters.AddWithValue("@ProdQty", productQTYTB.Text);
                        insertCmd.Parameters.AddWithValue("@ProdPrice", productPriceTB.Text);
                        insertCmd.Parameters.AddWithValue("@ProdDesc", descriptionTB.Text);
                        insertCmd.Parameters.AddWithValue("@ProdCat", CatCombo.SelectedValue.ToString());
                        insertCmd.Parameters.AddWithValue("@ProdFile", FileNameTB.Text);
                        insertCmd.Parameters.AddWithValue("@ProdText", textProductTb.Text);

                        MemoryStream stream = new MemoryStream();
                        PictureBox.Image.Save(stream, ImageFormat.Jpeg);
                        byte[] pic = stream.ToArray();
                        insertCmd.Parameters.AddWithValue("@ProdImage", pic);

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

                selectProducts();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "ProdFile(*.jpg;*.jpeg)| *.jpg;*.jpeg", Multiselect = false })
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
