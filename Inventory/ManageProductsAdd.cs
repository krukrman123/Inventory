using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Globalization;
using System.Configuration;
using System.Windows.Controls.Primitives;

namespace Inventory
{
    public partial class ManageProductsAdd : Form
    {
        public ManageProductsAdd()
        {
            InitializeComponent();

        }


        /////////////////////////////// SQL Connect //////////////////////////////////////////



        string connectionString = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;

        private void ManageProductsAdd_Load(object sender, EventArgs e)
        {
            fillCategory();
            populate();
            GenerateId();
        }

        string ProdId = "";


        void fillCategory()
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CategoryTbl";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader rdr;
                try
                {
                    Con.Open();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("CatName", typeof(string));
                    rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                    CatCombo.ValueMember = "CatName";
                    CatCombo.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void GenerateId()
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Select Count (ProdId) From ProductTbl", Con);
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                Con.Close();
                i++;
                productIDTB.Text = ProdId + i.ToString();
            }
        }

        void populate()
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                try
                {
                    Con.Open();
                    string Myquery = "select * from ProductTbl";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void insert(string filename, byte[] image)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                string myQuery = "INSERT INTO ProductTbl(ProdFile,ProdImage) VALUES (@ProdFile,@ProdImage)";
                SqlCommand cmd = new SqlCommand(myQuery, Con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ProdFile", FileNameTB.Text);
                cmd.Parameters.AddWithValue("@ProdImage", PictureBox.Image);

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







        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productIDTB.Text) || string.IsNullOrWhiteSpace(productNameTB.Text) || string.IsNullOrWhiteSpace(productQTYTB.Text) || string.IsNullOrWhiteSpace(productPriceTB.Text) || string.IsNullOrWhiteSpace(descriptionTB.Text) || string.IsNullOrWhiteSpace(FileNameTB.Text) || string.IsNullOrWhiteSpace(textProductTb.Text) || PictureBox.Image == null)
            {
                MessageBox.Show("Please fill in all the required information.");
                return;
            }

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    // Kontrola existence ID
                    SqlCommand checkIdCmd = new SqlCommand("SELECT COUNT(*) FROM ProductTbl WHERE ProdId = @ProdId", Con);
                    checkIdCmd.Parameters.AddWithValue("@ProdId", productIDTB.Text);
                    int count = Convert.ToInt32(checkIdCmd.ExecuteScalar());

                    if (count == 1)
                    {
                        MessageBox.Show("Product with the same ID already exists.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Nemusíte uzavírat připojení Con, protože používáte blok 'using'
                    }

                    // Vložení produktu
                    string insertQuery = "INSERT INTO ProductTbl (ProdId, ProdName, ProdQty, ProdPrice, ProdDesc, ProdCat, ProdFile, ProdText, ProdImage) VALUES (@ProdId, @ProdName, @ProdQty, @ProdPrice, @ProdDesc, @ProdCat, @ProdFile, @ProdText, @ProdImage)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, Con);
                    insertCmd.Parameters.AddWithValue("@ProdId", productIDTB.Text);
                    insertCmd.Parameters.AddWithValue("@ProdName", productNameTB.Text);
                    insertCmd.Parameters.AddWithValue("@ProdQty", productQTYTB.Text);
                    insertCmd.Parameters.AddWithValue("@ProdPrice", productPriceTB.Text);
                    insertCmd.Parameters.AddWithValue("@ProdDesc", descriptionTB.Text);
                    insertCmd.Parameters.AddWithValue("@ProdCat", CatCombo.SelectedValue.ToString());
                    insertCmd.Parameters.AddWithValue("@ProdFile", FileNameTB.Text);
                    insertCmd.Parameters.AddWithValue("@ProdText", textProductTb.Text);


                    MemoryStream stream = new MemoryStream();
                    PictureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    insertCmd.Parameters.AddWithValue("@ProdImage", pic);



                    string fname = productIDTB.Text + ".jpg";
                    string pathstring = Path.Combine("Photo", fname);

                    // Uložení obrázku do složky
                    PictureBox.Image.Save(pathstring);

                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Added");

                }

                populate();
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
                    PictureBox.Image = Image.FromFile(ofd.FileName);
                    FileNameTB.Text = ofd.FileName;


                }
            }
        }


        private void productIDTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }








    }
}

