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
    public partial class ManageProductsView : Form
    {
        public ManageProductsView()
        {
            InitializeComponent();
        }

        private void ManageProductsView_Load(object sender, EventArgs e)
        {
            fillCategory();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

            {
                productIDTB.Clear();
                productNameTB.Clear();
                productQTYTB.Clear();
                productPriceTB.Clear();
                descriptionTB.Clear();
            }
        }

        /////////////////////////////// SQL Connect //////////////////////////////////////////



        string connectionString = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;



        #region Functions
        void fillCategory()
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CategoryTbl";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader rdr = null;

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
                finally
                {
                    // Close SqlDataReader
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                }
            }



        }



        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            PictureBox.Image.Save(ms, PictureBox.Image.RawFormat);
            return ms.GetBuffer();
        }

        private byte[] ConvertImageToBytes(Image image)
        {
            if (image == null)
            {
                MessageBox.Show("No image selected.");
                return null;
            }

            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, ImageFormat.Jpeg); 
                return stream.ToArray();
            }
        }


        private void UpdateImage(int prodId, byte[] imageBytes)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string updateQuery = "UPDATE ProductTbl SET ProdImage = @ProdImage WHERE ProdId = @ProdId";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, Con);
                    updateCmd.Parameters.AddWithValue("@ProdImage", imageBytes);
                    updateCmd.Parameters.AddWithValue("@ProdId", prodId);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Image Successfully Updated");

                    // Reload the image to display in the PictureBox after the update
                    LoadImage(prodId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void LoadImage(int prodId)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string selectQuery = "SELECT ProdImage FROM ProductTbl WHERE ProdId = @ProdId";
                    SqlCommand selectCmd = new SqlCommand(selectQuery, Con);
                    selectCmd.Parameters.AddWithValue("@ProdId", prodId);

                    SqlDataReader reader = selectCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Retrieve a byte[] from the database and convert it back to an image
                        byte[] imageBytes = (byte[])reader["ProdImage"];
                        PictureBox.Image = Image.FromStream(new MemoryStream(imageBytes));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        #endregion


        #region ManageProductSystem


        public void insert(string filename, byte[] image)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    string myQuery = "INSERT INTO ProductTbl(ProdFile, ProdImage) VALUES (@ProdFile, @ProdImage)";
                    SqlCommand cmd = new SqlCommand(myQuery, Con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ProdFile", filename);
                    cmd.Parameters.AddWithValue("@ProdImage", image);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Added");
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (productIDTB.Text == "")
            {
                MessageBox.Show("Enter The Product ID Number");
            }
            else
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    string myquery = "DELETE FROM ProductTbl WHERE ProdId='" + productIDTB.Text + "';";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully deleted");
                }


                this.Close();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productIDTB.Text))
            {
                MessageBox.Show("Enter the Product ID");
                return;
            }

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();


                    string updateQuery = "UPDATE ProductTbl SET ProdName = @ProdName, ProdQty = @ProdQty, ProdPrice = @ProdPrice, ProdDesc = @ProdDesc, ProdCat = @ProdCat, ProdFile = @ProdFile, ProdText = @ProdText, ProdImage = @ProdImage WHERE ProdId = @ProdId";
                    SqlCommand cmd = new SqlCommand(updateQuery, Con);

                    cmd.Parameters.AddWithValue("@ProdId", productIDTB.Text);
                    cmd.Parameters.AddWithValue("@ProdName", productNameTB.Text);
                    cmd.Parameters.AddWithValue("@ProdQty", productQTYTB.Text);
                    cmd.Parameters.AddWithValue("@ProdPrice", productPriceTB.Text);
                    cmd.Parameters.AddWithValue("@ProdDesc", descriptionTB.Text);
                    cmd.Parameters.AddWithValue("@ProdCat", CatCombo.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@ProdFile", FileNameTB.Text);
                    cmd.Parameters.AddWithValue("@ProdText", textProductTb.Text);


                    // Add a product image if a new image has been selected
                    if (PictureBox.Image != null)
                    {
                        byte[] productImageBytes = SavePhoto();
                        cmd.Parameters.AddWithValue("@ProdImage", productImageBytes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ProdImage", DBNull.Value);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product Successfully Updated", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Product update failed.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    int prodId = Convert.ToInt32(productIDTB.Text); 
                    UpdateImage(prodId, ConvertImageToBytes(PictureBox.Image));
                }
            }
        }


        #endregion


       


    }

}
