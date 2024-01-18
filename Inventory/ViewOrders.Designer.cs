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
            panel1 = new Panel();
            label_Minimize = new Label();
            label_Exit = new Label();
            label1 = new Label();
            OrderGV = new DataGridView();
            btn_view = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            label10 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderGV).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(label_Minimize);
            panel1.Controls.Add(label_Exit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1559, 91);
            panel1.TabIndex = 0;
            // 
            // label_Minimize
            // 
            label_Minimize.AutoSize = true;
            label_Minimize.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_Minimize.ForeColor = Color.White;
            label_Minimize.Location = new Point(1496, 2);
            label_Minimize.Margin = new Padding(2, 0, 2, 0);
            label_Minimize.Name = "label_Minimize";
            label_Minimize.Size = new Size(22, 30);
            label_Minimize.TabIndex = 58;
            label_Minimize.Text = "_";
            label_Minimize.Click += label_Minimize_Click_1;
            // 
            // label_Exit
            // 
            label_Exit.AutoSize = true;
            label_Exit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Exit.ForeColor = Color.White;
            label_Exit.Location = new Point(1525, 9);
            label_Exit.Margin = new Padding(2, 0, 2, 0);
            label_Exit.Name = "label_Exit";
            label_Exit.Size = new Size(23, 25);
            label_Exit.TabIndex = 57;
            label_Exit.Text = "X";
            label_Exit.Click += label_Exit_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(2, 2);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(259, 41);
            label1.TabIndex = 1;
            label1.Text = "MANAGE ORDERS";
            // 
            // OrderGV
            // 
            OrderGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrderGV.BackgroundColor = SystemColors.ButtonHighlight;
            OrderGV.ColumnHeadersHeight = 29;
            OrderGV.Location = new Point(305, 114);
            OrderGV.Margin = new Padding(2);
            OrderGV.Name = "OrderGV";
            OrderGV.RowHeadersWidth = 62;
            OrderGV.RowTemplate.Height = 33;
            OrderGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrderGV.Size = new Size(962, 543);
            OrderGV.TabIndex = 50;
            OrderGV.CellContentClick += OrderGV_CellContentClick;
            // 
            // btn_view
            // 
            btn_view.BackColor = Color.FromArgb(192, 0, 0);
            btn_view.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_view.ForeColor = SystemColors.ControlLightLight;
            btn_view.Location = new Point(601, 720);
            btn_view.Margin = new Padding(1, 2, 1, 2);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(352, 67);
            btn_view.TabIndex = 54;
            btn_view.Text = "View Orders";
            btn_view.UseVisualStyleBackColor = false;
            btn_view.Click += btn_view_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Lucida Console", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.HighlightText;
            label10.Location = new Point(1453, 15);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(95, 14);
            label10.TabIndex = 2;
            label10.Text = "Version 1.0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Controls.Add(label10);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 815);
            panel2.Name = "panel2";
            panel2.Size = new Size(1559, 38);
            panel2.TabIndex = 55;
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1559, 853);
            Controls.Add(panel2);
            Controls.Add(btn_view);
            Controls.Add(OrderGV);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewOrders";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrderGV).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
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
        private Label label_Minimize;
        private Label label_Exit;
    }
}