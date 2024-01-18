using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }


        #region ConnectToSQL


        // Add connection string
        string connectionString = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;

        // Function to retrieve data from OrderTbl table
        void selectProducts()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    string Myquery = "SELECT * FROM OrderTbl";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    OrderGV.DataSource = ds.Tables[0];
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region ViewOrder

        private void btn_view_Click(object sender, EventArgs e)
        {
            selectProducts();
        }
        #endregion


        #region DataGripViewMenu

        private void OrderGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font titleFont = new Font("Century", 25, FontStyle.Bold);
            Font contentFont = new Font("Century", 20, FontStyle.Regular);
            Brush brush = Brushes.Black;

            DataGridViewRow selectedRow = OrderGV.SelectedRows[0];

            int startX = 80;
            int startY = 100;
            int lineHeight = 40;

            int pageHeight = e.MarginBounds.Height;

            // Alignment for content
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;

            e.Graphics.DrawString("Order Summary", titleFont, brush, new Point(280, startY));

            int endY = pageHeight - 100;

            startY += 2 * lineHeight;

            e.Graphics.DrawString("Order ID:", contentFont, brush, new Point(startX, startY), format);
            e.Graphics.DrawString(selectedRow.Cells[0].Value.ToString(), contentFont, brush, new Point(startX + 200, startY), format);
            startY += lineHeight;

            e.Graphics.DrawString("Cust ID:", contentFont, brush, new Point(startX, startY), format);
            e.Graphics.DrawString(selectedRow.Cells[1].Value.ToString(), contentFont, brush, new Point(startX + 200, startY), format);
            startY += lineHeight;

            e.Graphics.DrawString("Cust Name:", contentFont, brush, new Point(startX, startY), format);
            e.Graphics.DrawString(selectedRow.Cells[2].Value.ToString(), contentFont, brush, new Point(startX + 200, startY), format);
            startY += lineHeight;

            e.Graphics.DrawString("Order Date:", contentFont, brush, new Point(startX, startY), format);
            e.Graphics.DrawString(selectedRow.Cells[3].Value.ToString(), contentFont, brush, new Point(startX + 200, startY), format);
            startY += lineHeight;

            e.Graphics.DrawString("Total Amount:", contentFont, brush, new Point(startX, startY), format);
            e.Graphics.DrawString(selectedRow.Cells[4].Value.ToString() + "$", contentFont, brush, new Point(startX + 200, startY), format);
            startY += lineHeight;

            // Name of company
            Font companyFont = new Font("Century", 16, FontStyle.Italic);
            string companyName = "Adam Dobias";
            SizeF textSize = e.Graphics.MeasureString(companyName, companyFont);
            int rightX = e.MarginBounds.Width - (int)textSize.Width; // X-coordinate to align to the right
            int bottomY = e.MarginBounds.Bottom; // Y-coordinate at the bottom of the page
            e.Graphics.DrawString(companyName, companyFont, brush, new Point(rightX, bottomY - (int)textSize.Height));
        }

        #endregion


        #region ExitButton


        private void label_Minimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label_Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        #endregion
    }
}
