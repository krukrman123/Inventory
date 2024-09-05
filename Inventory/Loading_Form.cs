using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Inventory
{
    public partial class Loading_Form : Form
    {


        public Loading_Form()
        {
            InitializeComponent();
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Value += 1;
            ProgressBar1.Text = ProgressBar1.Value.ToString() + "%";
            if (ProgressBar1.Value == 100)
            {
                // Close the Loading_Form
                this.Close();
                timer1.Stop();

                // Open the HomeForm with role-based adjustments
                HomeFrom home = new HomeFrom();
                home.Show();
            }
        }

        private void MinimizedApp_Label_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
