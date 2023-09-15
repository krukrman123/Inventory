using Microsoft.Data.SqlClient;
using System.Configuration;
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
using System.Windows.Controls.Primitives;
using Newtonsoft.Json.Linq;


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
        /////////////////////////////// SQL Connect //////////////////////////////////////////

        ManageProductsView myformEdit = new ManageProductsView();
        ManageProductsAdd myformAdd = new ManageProductsAdd();

        string connectionString = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;





        private void ManageProducts_Load(object sender, EventArgs e)
        {

            fillCategory();
            populate();
        }



        /////////////////////////////// Top Label //////////////////////////////////////////


        private void label10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ///////////////////////////////////////////     Fuinctions  ///////////////////////////////////////////

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
                    searchCombo_Products.ValueMember = "CatName";
                    searchCombo_Products.DataSource = dt;
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
                    string Myquery = "select * from ProductTbl";
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





        void filterByCategory()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    string Myquery = "SELECT * FROM ProductTbl WHERE ProdCat='" + searchCombo_Products.SelectedValue.ToString() + "'";
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









        /////////////////////////////////// DataGripView ////////////////////////////////////////////////////////
        private void ProductGV_CellClick(object sender, DataGridViewCellEventArgs e)
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
            populate();

        }




        ///////////////////////////////////////////// Buttons USERS LIST /////////////////////////////////////////////////////////////////////////////
        private void btn_home_Click(object sender, EventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
            this.Hide();
        }



        private void btn_add_Click(object sender, EventArgs e)
        {

            myformAdd.ShowDialog();
            populate();
        }
        private void btn_sreach_Click(object sender, EventArgs e)
        {
            filterByCategory();
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            populate();
        }


    }
}
