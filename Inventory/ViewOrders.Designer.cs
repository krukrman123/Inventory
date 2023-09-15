namespace Inventory
{
    partial class ViewOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrders));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Minimize = new System.Windows.Forms.Label();
            this.label_Exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderGV = new System.Windows.Forms.DataGridView();
            this.btn_view = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label_Minimize);
            this.panel1.Controls.Add(this.label_Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1559, 91);
            this.panel1.TabIndex = 0;
            // 
            // label_Minimize
            // 
            this.label_Minimize.AutoSize = true;
            this.label_Minimize.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Minimize.ForeColor = System.Drawing.Color.White;
            this.label_Minimize.Location = new System.Drawing.Point(1496, 2);
            this.label_Minimize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Minimize.Name = "label_Minimize";
            this.label_Minimize.Size = new System.Drawing.Size(22, 30);
            this.label_Minimize.TabIndex = 58;
            this.label_Minimize.Text = "_";
            this.label_Minimize.Click += new System.EventHandler(this.label_Minimize_Click_1);
            // 
            // label_Exit
            // 
            this.label_Exit.AutoSize = true;
            this.label_Exit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Exit.ForeColor = System.Drawing.Color.White;
            this.label_Exit.Location = new System.Drawing.Point(1525, 9);
            this.label_Exit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(23, 25);
            this.label_Exit.TabIndex = 57;
            this.label_Exit.Text = "X";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(644, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANAGE ORDERS";
            // 
            // OrderGV
            // 
            this.OrderGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderGV.ColumnHeadersHeight = 29;
            this.OrderGV.Location = new System.Drawing.Point(305, 114);
            this.OrderGV.Margin = new System.Windows.Forms.Padding(2);
            this.OrderGV.Name = "OrderGV";
            this.OrderGV.RowHeadersWidth = 62;
            this.OrderGV.RowTemplate.Height = 33;
            this.OrderGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGV.Size = new System.Drawing.Size(962, 543);
            this.OrderGV.TabIndex = 50;
            this.OrderGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGV_CellContentClick);
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_view.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_view.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_view.Location = new System.Drawing.Point(601, 720);
            this.btn_view.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(352, 67);
            this.btn_view.TabIndex = 54;
            this.btn_view.Text = "View Orders";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(1453, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 14);
            this.label10.TabIndex = 2;
            this.label10.Text = "Version 1.0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 815);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1559, 38);
            this.panel2.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(633, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(295, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Devolop By Adams Indastris";
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1559, 853);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.OrderGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewOrders";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView OrderGV;
        private Button btn_view;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label10;
        private Panel panel2;
        private Label label11;
        private Label label_Minimize;
        private Label label_Exit;
    }
}