namespace Inventory
{
    partial class HomeFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeFrom));
            panel1 = new Panel();
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            MinimizedApp_Label = new Label();
            ExitApp_Label = new Label();
            ProductsTB = new Label();
            CustomersTB = new Label();
            OrdersTB = new Label();
            UsersTB = new Label();
            CategoriesTB = new Label();
            btn_Logout = new Button();
            Products = new PictureBox();
            Customers = new PictureBox();
            Categories = new PictureBox();
            Users = new PictureBox();
            Orders = new PictureBox();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            UserLogged = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Customers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Categories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Users).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Orders).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlText;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1449, 68);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(459, 16);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(501, 41);
            label4.TabIndex = 16;
            label4.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(MinimizedApp_Label, 0, 0);
            tableLayoutPanel2.Controls.Add(ExitApp_Label, 1, 0);
            tableLayoutPanel2.Location = new Point(1371, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(66, 38);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // MinimizedApp_Label
            // 
            MinimizedApp_Label.Anchor = AnchorStyles.None;
            MinimizedApp_Label.AutoSize = true;
            MinimizedApp_Label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            MinimizedApp_Label.ForeColor = Color.White;
            MinimizedApp_Label.Location = new Point(5, 4);
            MinimizedApp_Label.Margin = new Padding(2, 0, 2, 0);
            MinimizedApp_Label.Name = "MinimizedApp_Label";
            MinimizedApp_Label.Size = new Size(22, 30);
            MinimizedApp_Label.TabIndex = 13;
            MinimizedApp_Label.Text = "_";
            MinimizedApp_Label.Click += MinimizedApp_Label_Click;
            // 
            // ExitApp_Label
            // 
            ExitApp_Label.Anchor = AnchorStyles.None;
            ExitApp_Label.AutoSize = true;
            ExitApp_Label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ExitApp_Label.Location = new Point(36, 3);
            ExitApp_Label.Name = "ExitApp_Label";
            ExitApp_Label.Size = new Size(27, 32);
            ExitApp_Label.TabIndex = 2;
            ExitApp_Label.Text = "X";
            ExitApp_Label.Click += ExitApp_Label_Click;
            // 
            // ProductsTB
            // 
            ProductsTB.Anchor = AnchorStyles.None;
            ProductsTB.AutoSize = true;
            ProductsTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ProductsTB.ForeColor = SystemColors.ActiveCaptionText;
            ProductsTB.Location = new Point(83, 14);
            ProductsTB.Name = "ProductsTB";
            ProductsTB.Size = new Size(97, 30);
            ProductsTB.TabIndex = 1;
            ProductsTB.Text = "Products";
            // 
            // CustomersTB
            // 
            CustomersTB.Anchor = AnchorStyles.None;
            CustomersTB.AutoSize = true;
            CustomersTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            CustomersTB.ForeColor = SystemColors.ActiveCaptionText;
            CustomersTB.Location = new Point(602, 14);
            CustomersTB.Name = "CustomersTB";
            CustomersTB.Size = new Size(116, 30);
            CustomersTB.TabIndex = 2;
            CustomersTB.Text = "Customers";
            // 
            // OrdersTB
            // 
            OrdersTB.Anchor = AnchorStyles.None;
            OrdersTB.AutoSize = true;
            OrdersTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            OrdersTB.ForeColor = SystemColors.ActiveCaptionText;
            OrdersTB.Location = new Point(1148, 14);
            OrdersTB.Name = "OrdersTB";
            OrdersTB.Size = new Size(80, 30);
            OrdersTB.TabIndex = 3;
            OrdersTB.Text = "Orders";
            // 
            // UsersTB
            // 
            UsersTB.Anchor = AnchorStyles.None;
            UsersTB.AutoSize = true;
            UsersTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            UsersTB.ForeColor = SystemColors.ActiveCaptionText;
            UsersTB.Location = new Point(891, 14);
            UsersTB.Name = "UsersTB";
            UsersTB.Size = new Size(66, 30);
            UsersTB.TabIndex = 4;
            UsersTB.Text = "Users";
            // 
            // CategoriesTB
            // 
            CategoriesTB.Anchor = AnchorStyles.None;
            CategoriesTB.AutoSize = true;
            CategoriesTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            CategoriesTB.ForeColor = SystemColors.ActiveCaptionText;
            CategoriesTB.Location = new Point(337, 14);
            CategoriesTB.Name = "CategoriesTB";
            CategoriesTB.Size = new Size(117, 30);
            CategoriesTB.TabIndex = 5;
            CategoriesTB.Text = "Categories";
            // 
            // btn_Logout
            // 
            btn_Logout.BackColor = Color.FromArgb(192, 0, 0);
            btn_Logout.FlatStyle = FlatStyle.Popup;
            btn_Logout.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Logout.Location = new Point(1275, 518);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(133, 41);
            btn_Logout.TabIndex = 6;
            btn_Logout.Text = "Logout";
            btn_Logout.UseVisualStyleBackColor = false;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // Products
            // 
            Products.Anchor = AnchorStyles.None;
            Products.BackColor = SystemColors.GrayText;
            Products.ErrorImage = (Image)resources.GetObject("Products.ErrorImage");
            Products.Image = Properties.Resources.Product;
            Products.Location = new Point(27, 61);
            Products.Margin = new Padding(2);
            Products.Name = "Products";
            Products.Size = new Size(210, 137);
            Products.SizeMode = PictureBoxSizeMode.StretchImage;
            Products.TabIndex = 7;
            Products.TabStop = false;
            Products.Click += Products_Click_1;
            // 
            // Customers
            // 
            Customers.Anchor = AnchorStyles.None;
            Customers.Image = Properties.Resources.Customers;
            Customers.Location = new Point(555, 61);
            Customers.Margin = new Padding(2);
            Customers.Name = "Customers";
            Customers.Size = new Size(210, 137);
            Customers.SizeMode = PictureBoxSizeMode.CenterImage;
            Customers.TabIndex = 8;
            Customers.TabStop = false;
            Customers.Click += Customers_Click_1;
            // 
            // Categories
            // 
            Categories.Anchor = AnchorStyles.None;
            Categories.Image = Properties.Resources.Categories;
            Categories.Location = new Point(291, 61);
            Categories.Margin = new Padding(2);
            Categories.Name = "Categories";
            Categories.Size = new Size(210, 137);
            Categories.SizeMode = PictureBoxSizeMode.StretchImage;
            Categories.TabIndex = 9;
            Categories.TabStop = false;
            Categories.Click += Categories_Click_1;
            // 
            // Users
            // 
            Users.Anchor = AnchorStyles.None;
            Users.Image = Properties.Resources.user;
            Users.Location = new Point(819, 61);
            Users.Margin = new Padding(2);
            Users.Name = "Users";
            Users.Size = new Size(210, 137);
            Users.SizeMode = PictureBoxSizeMode.StretchImage;
            Users.TabIndex = 10;
            Users.TabStop = false;
            Users.Click += Users_Click_1;
            // 
            // Orders
            // 
            Orders.Anchor = AnchorStyles.None;
            Orders.Image = Properties.Resources.order;
            Orders.Location = new Point(1083, 61);
            Orders.Margin = new Padding(2);
            Orders.Name = "Orders";
            Orders.Size = new Size(210, 137);
            Orders.SizeMode = PictureBoxSizeMode.StretchImage;
            Orders.TabIndex = 11;
            Orders.TabStop = false;
            Orders.Click += Orders_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(1332, 607);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 13);
            label3.TabIndex = 2;
            label3.Text = "Version 1.0";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(CustomersTB, 2, 0);
            tableLayoutPanel1.Controls.Add(CategoriesTB, 1, 0);
            tableLayoutPanel1.Controls.Add(Products, 0, 1);
            tableLayoutPanel1.Controls.Add(Categories, 1, 1);
            tableLayoutPanel1.Controls.Add(Users, 3, 1);
            tableLayoutPanel1.Controls.Add(Customers, 2, 1);
            tableLayoutPanel1.Controls.Add(Orders, 4, 1);
            tableLayoutPanel1.Controls.Add(ProductsTB, 0, 0);
            tableLayoutPanel1.Controls.Add(UsersTB, 3, 0);
            tableLayoutPanel1.Controls.Add(OrdersTB, 4, 0);
            tableLayoutPanel1.Location = new Point(63, 107);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 142F));
            tableLayoutPanel1.Size = new Size(1321, 201);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // UserLogged
            // 
            UserLogged.AutoSize = true;
            UserLogged.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            UserLogged.Location = new Point(27, 80);
            UserLogged.Name = "UserLogged";
            UserLogged.Size = new Size(0, 25);
            UserLogged.TabIndex = 14;
            // 
            // HomeFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1449, 629);
            Controls.Add(label3);
            Controls.Add(UserLogged);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btn_Logout);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeFrom";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Products).EndInit();
            ((System.ComponentModel.ISupportInitialize)Customers).EndInit();
            ((System.ComponentModel.ISupportInitialize)Categories).EndInit();
            ((System.ComponentModel.ISupportInitialize)Users).EndInit();
            ((System.ComponentModel.ISupportInitialize)Orders).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label ProductsTB;
        private Label CustomersTB;
        private Label OrdersTB;
        private Label UsersTB;
        private Label CategoriesTB;
        private Button btn_Logout;
        private PictureBox Products;
        private PictureBox Customers;
        private PictureBox Categories;
        private PictureBox Users;
        private PictureBox Orders;
        private Label label3;
        private Label MinimizedApp_Label;
        private TableLayoutPanel tableLayoutPanel1;
        private Label UserLogged;
        private TableLayoutPanel tableLayoutPanel2;
        private Label ExitApp_Label;
        private Label label4;
    }
}