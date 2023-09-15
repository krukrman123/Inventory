namespace Inventory
{
    partial class ManageOrders
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
            panel1 = new Panel();
            label_Minimize = new Label();
            label_Exit = new Label();
            label1 = new Label();
            label2 = new Label();
            CustomerGV = new DataGridView();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            CustomerIdTB = new TextBox();
            OrderIdTB = new TextBox();
            orderDate = new DateTimePicker();
            label7 = new Label();
            ProductGV = new DataGridView();
            searchCombo = new ComboBox();
            label8 = new Label();
            productQtyTB = new TextBox();
            btn_OrderAdd = new Button();
            label9 = new Label();
            CustNameTB = new TextBox();
            Numss = new DataGridViewTextBoxColumn();
            label10 = new Label();
            TotAmout = new Label();
            btn_insert = new Button();
            btn_view = new Button();
            btn_home = new Button();
            label11 = new Label();
            label12 = new Label();
            panel2 = new Panel();
            OrderGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductGV).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlText;
            panel1.Controls.Add(label_Minimize);
            panel1.Controls.Add(label_Exit);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1782, 120);
            panel1.TabIndex = 3;
            // 
            // label_Minimize
            // 
            label_Minimize.AutoSize = true;
            label_Minimize.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_Minimize.ForeColor = Color.White;
            label_Minimize.Location = new Point(1710, 0);
            label_Minimize.Margin = new Padding(2, 0, 2, 0);
            label_Minimize.Name = "label_Minimize";
            label_Minimize.Size = new Size(29, 38);
            label_Minimize.TabIndex = 56;
            label_Minimize.Text = "_";
            label_Minimize.Click += label_Minimize_Click;
            // 
            // label_Exit
            // 
            label_Exit.AutoSize = true;
            label_Exit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Exit.ForeColor = Color.White;
            label_Exit.Location = new Point(1743, 9);
            label_Exit.Margin = new Padding(2, 0, 2, 0);
            label_Exit.Name = "label_Exit";
            label_Exit.Size = new Size(28, 32);
            label_Exit.TabIndex = 2;
            label_Exit.Text = "X";
            label_Exit.Click += label_Exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(594, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(618, 50);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(807, 65);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 1;
            label2.Text = "Manage Orders";
            // 
            // CustomerGV
            // 
            CustomerGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomerGV.BackgroundColor = SystemColors.ButtonHighlight;
            CustomerGV.ColumnHeadersHeight = 29;
            CustomerGV.Location = new Point(38, 283);
            CustomerGV.Margin = new Padding(2, 3, 2, 3);
            CustomerGV.Name = "CustomerGV";
            CustomerGV.RowHeadersWidth = 62;
            CustomerGV.RowTemplate.Height = 33;
            CustomerGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerGV.Size = new Size(672, 327);
            CustomerGV.TabIndex = 14;
            CustomerGV.CellContentClick += CustomerGV_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(224, 207);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(305, 50);
            label4.TabIndex = 15;
            label4.Text = "CUSTOMER LIST";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(38, 755);
            label6.Name = "label6";
            label6.Size = new Size(118, 28);
            label6.TabIndex = 27;
            label6.Text = "Customer Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(128, 255, 255);
            label5.Location = new Point(38, 669);
            label5.Name = "label5";
            label5.Size = new Size(124, 37);
            label5.TabIndex = 26;
            label5.Text = "Order Id";
            // 
            // CustomerIdTB
            // 
            CustomerIdTB.BackColor = SystemColors.GrayText;
            CustomerIdTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerIdTB.ForeColor = SystemColors.ButtonHighlight;
            CustomerIdTB.Location = new Point(224, 751);
            CustomerIdTB.Margin = new Padding(2, 3, 2, 3);
            CustomerIdTB.Name = "CustomerIdTB";
            CustomerIdTB.Size = new Size(340, 34);
            CustomerIdTB.TabIndex = 25;
            // 
            // OrderIdTB
            // 
            OrderIdTB.BackColor = SystemColors.GrayText;
            OrderIdTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OrderIdTB.ForeColor = SystemColors.ControlDark;
            OrderIdTB.Location = new Point(224, 673);
            OrderIdTB.Margin = new Padding(2, 3, 2, 3);
            OrderIdTB.Name = "OrderIdTB";
            OrderIdTB.ReadOnly = true;
            OrderIdTB.Size = new Size(340, 34);
            OrderIdTB.TabIndex = 24;
            OrderIdTB.KeyPress += OrderIdTB_KeyPress;
            // 
            // orderDate
            // 
            orderDate.CalendarFont = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            orderDate.CalendarTitleBackColor = SystemColors.ControlText;
            orderDate.CalendarTitleForeColor = Color.AliceBlue;
            orderDate.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            orderDate.Format = DateTimePickerFormat.Custom;
            orderDate.ImeMode = ImeMode.NoControl;
            orderDate.Location = new Point(224, 916);
            orderDate.Margin = new Padding(3, 4, 3, 4);
            orderDate.Name = "orderDate";
            orderDate.Size = new Size(340, 27);
            orderDate.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(128, 255, 255);
            label7.Location = new Point(38, 907);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(159, 37);
            label7.TabIndex = 29;
            label7.Text = "Order Date";
            // 
            // ProductGV
            // 
            ProductGV.AllowUserToDeleteRows = false;
            ProductGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductGV.BackgroundColor = SystemColors.ButtonHighlight;
            ProductGV.ColumnHeadersHeight = 29;
            ProductGV.Location = new Point(880, 207);
            ProductGV.Margin = new Padding(2, 3, 2, 3);
            ProductGV.Name = "ProductGV";
            ProductGV.ReadOnly = true;
            ProductGV.RowHeadersWidth = 62;
            ProductGV.RowTemplate.Height = 33;
            ProductGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductGV.Size = new Size(849, 327);
            ProductGV.TabIndex = 30;
            ProductGV.CellContentClick += ProductGV_CellContentClick;
            // 
            // searchCombo
            // 
            searchCombo.BackColor = SystemColors.GrayText;
            searchCombo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchCombo.ForeColor = SystemColors.ButtonHighlight;
            searchCombo.FormattingEnabled = true;
            searchCombo.Location = new Point(1125, 140);
            searchCombo.Margin = new Padding(3, 4, 3, 4);
            searchCombo.Name = "searchCombo";
            searchCombo.Size = new Size(340, 36);
            searchCombo.TabIndex = 42;
            searchCombo.Text = "Select Category";
            searchCombo.SelectionChangeCommitted += searchCombo_SelectionChangeCommitted;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(880, 564);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(129, 37);
            label8.TabIndex = 43;
            label8.Text = "Quantity";
            // 
            // productQtyTB
            // 
            productQtyTB.BackColor = SystemColors.GrayText;
            productQtyTB.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            productQtyTB.ForeColor = SystemColors.ButtonHighlight;
            productQtyTB.Location = new Point(1125, 573);
            productQtyTB.Margin = new Padding(1, 3, 1, 3);
            productQtyTB.Name = "productQtyTB";
            productQtyTB.Size = new Size(340, 30);
            productQtyTB.TabIndex = 44;
            productQtyTB.KeyPress += productQTYTB_KeyPress;
            // 
            // btn_OrderAdd
            // 
            btn_OrderAdd.BackColor = Color.FromArgb(192, 0, 0);
            btn_OrderAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_OrderAdd.ForeColor = SystemColors.ControlLightLight;
            btn_OrderAdd.Location = new Point(1587, 565);
            btn_OrderAdd.Margin = new Padding(1, 3, 1, 3);
            btn_OrderAdd.Name = "btn_OrderAdd";
            btn_OrderAdd.Size = new Size(142, 67);
            btn_OrderAdd.TabIndex = 45;
            btn_OrderAdd.Text = "Add To Order";
            btn_OrderAdd.UseVisualStyleBackColor = false;
            btn_OrderAdd.Click += btn_OrderAdd_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(38, 829);
            label9.Name = "label9";
            label9.Size = new Size(153, 28);
            label9.TabIndex = 48;
            label9.Text = "Customer Name";
            // 
            // CustNameTB
            // 
            CustNameTB.BackColor = SystemColors.GrayText;
            CustNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CustNameTB.ForeColor = SystemColors.ButtonHighlight;
            CustNameTB.Location = new Point(224, 823);
            CustNameTB.Margin = new Padding(2, 3, 2, 3);
            CustNameTB.Name = "CustNameTB";
            CustNameTB.Size = new Size(340, 34);
            CustNameTB.TabIndex = 47;
            // 
            // Numss
            // 
            Numss.HeaderText = "Nussm";
            Numss.MinimumWidth = 8;
            Numss.Name = "Numss";
            Numss.Width = 90;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(1202, 996);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(192, 41);
            label10.TabIndex = 50;
            label10.Text = "Total Amout";
            // 
            // TotAmout
            // 
            TotAmout.AutoSize = true;
            TotAmout.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TotAmout.ForeColor = SystemColors.ActiveCaptionText;
            TotAmout.Location = new Point(1395, 996);
            TotAmout.Margin = new Padding(2, 0, 2, 0);
            TotAmout.Name = "TotAmout";
            TotAmout.Size = new Size(35, 41);
            TotAmout.TabIndex = 51;
            TotAmout.Text = "$";
            // 
            // btn_insert
            // 
            btn_insert.BackColor = Color.FromArgb(192, 0, 0);
            btn_insert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_insert.ForeColor = SystemColors.ControlLightLight;
            btn_insert.Location = new Point(224, 972);
            btn_insert.Margin = new Padding(1, 3, 1, 3);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(142, 67);
            btn_insert.TabIndex = 52;
            btn_insert.Text = "Insert Order";
            btn_insert.UseVisualStyleBackColor = false;
            btn_insert.Click += btn_insert_Click;
            // 
            // btn_view
            // 
            btn_view.BackColor = Color.FromArgb(192, 0, 0);
            btn_view.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_view.ForeColor = SystemColors.ControlLightLight;
            btn_view.Location = new Point(422, 972);
            btn_view.Margin = new Padding(1, 3, 1, 3);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(142, 67);
            btn_view.TabIndex = 53;
            btn_view.Text = "View Orders";
            btn_view.UseVisualStyleBackColor = false;
            btn_view.Click += btn_view_Click;
            // 
            // btn_home
            // 
            btn_home.BackColor = Color.FromArgb(192, 0, 0);
            btn_home.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_home.ForeColor = SystemColors.ControlLightLight;
            btn_home.Location = new Point(11, 125);
            btn_home.Margin = new Padding(2, 3, 2, 3);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(142, 67);
            btn_home.TabIndex = 54;
            btn_home.Text = "Home";
            btn_home.UseVisualStyleBackColor = false;
            btn_home.Click += btn_home_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Lucida Console", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.HighlightText;
            label11.Location = new Point(1653, 17);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(118, 17);
            label11.TabIndex = 2;
            label11.Text = "Version 1.0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Lucida Console", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.HighlightText;
            label12.Location = new Point(721, 17);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(318, 24);
            label12.TabIndex = 1;
            label12.Text = "Devolop By Adam Dobias";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlText;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1086);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1782, 51);
            panel2.TabIndex = 55;
            // 
            // OrderGV
            // 
            OrderGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrderGV.BackgroundColor = SystemColors.ButtonHighlight;
            OrderGV.ColumnHeadersHeight = 29;
            OrderGV.Location = new Point(886, 637);
            OrderGV.Margin = new Padding(2, 3, 2, 3);
            OrderGV.Name = "OrderGV";
            OrderGV.RowHeadersWidth = 62;
            OrderGV.RowTemplate.Height = 33;
            OrderGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrderGV.Size = new Size(849, 327);
            OrderGV.TabIndex = 57;
            // 
            // ManageOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1782, 1137);
            Controls.Add(OrderGV);
            Controls.Add(panel2);
            Controls.Add(btn_home);
            Controls.Add(btn_view);
            Controls.Add(btn_insert);
            Controls.Add(TotAmout);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(CustNameTB);
            Controls.Add(btn_OrderAdd);
            Controls.Add(productQtyTB);
            Controls.Add(label8);
            Controls.Add(searchCombo);
            Controls.Add(ProductGV);
            Controls.Add(label7);
            Controls.Add(orderDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(CustomerIdTB);
            Controls.Add(OrderIdTB);
            Controls.Add(label4);
            Controls.Add(CustomerGV);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageOrders";
            Load += ManageOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductGV).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrderGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label_Exit;
        private Label label2;
        private Label label1;
        private DataGridView CustomerGV;
        private Label label4;
        private Label label6;
        private Label label5;
        private TextBox CustomerIdTB;
        private TextBox OrderIdTB;
        private DateTimePicker orderDate;
        private Label label7;
        private DataGridView ProductGV;
        private ComboBox searchCombo;
        private Label label8;
        private TextBox productQtyTB;
        private Button btn_OrderAdd;
        private Label label9;
        private TextBox CustNameTB;
        private DataGridViewTextBoxColumn Numss;
        private Label label10;
        private Label TotAmout;
        private Button btn_insert;
        private Button btn_view;
        private Button btn_home;
        private Label label11;
        private Label label12;
        private Panel panel2;
        private Label label_Minimize;
        private DataGridView OrderGV;
    }
}