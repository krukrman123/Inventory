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
            MinimizedApp_Label = new Label();
            ExitApp_Label = new Label();
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
            OrderGV = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel3 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            UserMenu_BT = new Button();
            ProductsMenu_BT = new Button();
            OrderMenu_BT = new Button();
            CustomerMenu_BT = new Button();
            pictureBox1 = new PictureBox();
            CategoriesMenu_BT = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderGV).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlText;
            panel1.Controls.Add(MinimizedApp_Label);
            panel1.Controls.Add(ExitApp_Label);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1700, 90);
            panel1.TabIndex = 3;
            // 
            // MinimizedApp_Label
            // 
            MinimizedApp_Label.AutoSize = true;
            MinimizedApp_Label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            MinimizedApp_Label.ForeColor = Color.White;
            MinimizedApp_Label.Location = new Point(1637, 2);
            MinimizedApp_Label.Margin = new Padding(2, 0, 2, 0);
            MinimizedApp_Label.Name = "MinimizedApp_Label";
            MinimizedApp_Label.Size = new Size(22, 30);
            MinimizedApp_Label.TabIndex = 56;
            MinimizedApp_Label.Text = "_";
            MinimizedApp_Label.Click += MinimizedApp_Label_Click;
            // 
            // ExitApp_Label
            // 
            ExitApp_Label.AutoSize = true;
            ExitApp_Label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ExitApp_Label.ForeColor = Color.White;
            ExitApp_Label.Location = new Point(1666, 9);
            ExitApp_Label.Margin = new Padding(2, 0, 2, 0);
            ExitApp_Label.Name = "ExitApp_Label";
            ExitApp_Label.Size = new Size(23, 25);
            ExitApp_Label.TabIndex = 2;
            ExitApp_Label.Text = "X";
            ExitApp_Label.Click += ExitApp_Label_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 1;
            label2.Text = "Manage Orders";
            // 
            // CustomerGV
            // 
            CustomerGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomerGV.BackgroundColor = SystemColors.ButtonHighlight;
            CustomerGV.ColumnHeadersHeight = 29;
            CustomerGV.Location = new Point(301, 205);
            CustomerGV.Margin = new Padding(2);
            CustomerGV.Name = "CustomerGV";
            CustomerGV.RowHeadersWidth = 62;
            CustomerGV.RowTemplate.Height = 33;
            CustomerGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerGV.Size = new Size(588, 410);
            CustomerGV.TabIndex = 14;
            CustomerGV.CellContentClick += CustomerGV_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(878, 114);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 40);
            label4.TabIndex = 15;
            label4.Text = "Orders";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(300, 717);
            label6.Name = "label6";
            label6.Size = new Size(102, 21);
            label6.TabIndex = 27;
            label6.Text = "Customer Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(128, 255, 255);
            label5.Location = new Point(300, 653);
            label5.Name = "label5";
            label5.Size = new Size(101, 30);
            label5.TabIndex = 26;
            label5.Text = "Order Id";
            // 
            // CustomerIdTB
            // 
            CustomerIdTB.BackColor = SystemColors.ControlLightLight;
            CustomerIdTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerIdTB.ForeColor = SystemColors.ActiveCaptionText;
            CustomerIdTB.Location = new Point(463, 714);
            CustomerIdTB.Margin = new Padding(2);
            CustomerIdTB.Name = "CustomerIdTB";
            CustomerIdTB.Size = new Size(298, 29);
            CustomerIdTB.TabIndex = 25;
            // 
            // OrderIdTB
            // 
            OrderIdTB.BackColor = SystemColors.ControlLightLight;
            OrderIdTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OrderIdTB.ForeColor = SystemColors.ActiveCaptionText;
            OrderIdTB.Location = new Point(463, 656);
            OrderIdTB.Margin = new Padding(2);
            OrderIdTB.Name = "OrderIdTB";
            OrderIdTB.ReadOnly = true;
            OrderIdTB.Size = new Size(298, 29);
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
            orderDate.Location = new Point(463, 838);
            orderDate.Name = "orderDate";
            orderDate.Size = new Size(298, 23);
            orderDate.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(128, 255, 255);
            label7.Location = new Point(300, 831);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(129, 30);
            label7.TabIndex = 29;
            label7.Text = "Order Date";
            // 
            // ProductGV
            // 
            ProductGV.AllowUserToDeleteRows = false;
            ProductGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductGV.BackgroundColor = SystemColors.ButtonHighlight;
            ProductGV.ColumnHeadersHeight = 29;
            ProductGV.Location = new Point(935, 205);
            ProductGV.Margin = new Padding(2);
            ProductGV.Name = "ProductGV";
            ProductGV.ReadOnly = true;
            ProductGV.RowHeadersWidth = 62;
            ProductGV.RowTemplate.Height = 33;
            ProductGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductGV.Size = new Size(743, 306);
            ProductGV.TabIndex = 30;
            ProductGV.CellContentClick += ProductGV_CellContentClick;
            // 
            // searchCombo
            // 
            searchCombo.BackColor = SystemColors.ControlLightLight;
            searchCombo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchCombo.ForeColor = SystemColors.ActiveCaptionText;
            searchCombo.FormattingEnabled = true;
            searchCombo.Location = new Point(1380, 160);
            searchCombo.Name = "searchCombo";
            searchCombo.Size = new Size(298, 29);
            searchCombo.TabIndex = 42;
            searchCombo.Text = "Select Category";
            searchCombo.SelectionChangeCommitted += searchCombo_SelectionChangeCommitted;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(935, 534);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(104, 30);
            label8.TabIndex = 43;
            label8.Text = "Quantity";
            // 
            // productQtyTB
            // 
            productQtyTB.BackColor = SystemColors.ControlLightLight;
            productQtyTB.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            productQtyTB.ForeColor = SystemColors.ActiveCaptionText;
            productQtyTB.Location = new Point(1053, 539);
            productQtyTB.Margin = new Padding(1, 2, 1, 2);
            productQtyTB.Name = "productQtyTB";
            productQtyTB.Size = new Size(298, 25);
            productQtyTB.TabIndex = 44;
            productQtyTB.KeyPress += productQTYTB_KeyPress;
            // 
            // btn_OrderAdd
            // 
            btn_OrderAdd.BackColor = Color.FromArgb(192, 0, 0);
            btn_OrderAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_OrderAdd.ForeColor = SystemColors.ControlLightLight;
            btn_OrderAdd.Location = new Point(1554, 527);
            btn_OrderAdd.Margin = new Padding(1, 2, 1, 2);
            btn_OrderAdd.Name = "btn_OrderAdd";
            btn_OrderAdd.Size = new Size(124, 50);
            btn_OrderAdd.TabIndex = 45;
            btn_OrderAdd.Text = "Add To Order";
            btn_OrderAdd.UseVisualStyleBackColor = false;
            btn_OrderAdd.Click += btn_OrderAdd_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(300, 773);
            label9.Name = "label9";
            label9.Size = new Size(133, 21);
            label9.TabIndex = 48;
            label9.Text = "Customer Name";
            // 
            // CustNameTB
            // 
            CustNameTB.BackColor = SystemColors.ControlLightLight;
            CustNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CustNameTB.ForeColor = SystemColors.ActiveCaptionText;
            CustNameTB.Location = new Point(463, 768);
            CustNameTB.Margin = new Padding(2);
            CustNameTB.Name = "CustNameTB";
            CustNameTB.Size = new Size(298, 29);
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
            label10.Location = new Point(1212, 877);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(155, 32);
            label10.TabIndex = 50;
            label10.Text = "Total Amout";
            // 
            // TotAmout
            // 
            TotAmout.AutoSize = true;
            TotAmout.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TotAmout.ForeColor = SystemColors.ActiveCaptionText;
            TotAmout.Location = new Point(1381, 877);
            TotAmout.Margin = new Padding(2, 0, 2, 0);
            TotAmout.Name = "TotAmout";
            TotAmout.Size = new Size(28, 32);
            TotAmout.TabIndex = 51;
            TotAmout.Text = "$";
            // 
            // btn_insert
            // 
            btn_insert.BackColor = Color.FromArgb(192, 0, 0);
            btn_insert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_insert.ForeColor = SystemColors.ControlLightLight;
            btn_insert.Location = new Point(463, 880);
            btn_insert.Margin = new Padding(1, 2, 1, 2);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(124, 50);
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
            btn_view.Location = new Point(636, 880);
            btn_view.Margin = new Padding(1, 2, 1, 2);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(124, 50);
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
            btn_home.Location = new Point(1574, 880);
            btn_home.Margin = new Padding(2);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(104, 49);
            btn_home.TabIndex = 54;
            btn_home.Text = "Home";
            btn_home.UseVisualStyleBackColor = false;
            btn_home.Click += btn_home_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Desktop;
            label11.Location = new Point(1574, 941);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(106, 13);
            label11.TabIndex = 2;
            label11.Text = "Version 1.0";
            // 
            // OrderGV
            // 
            OrderGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrderGV.BackgroundColor = SystemColors.ButtonHighlight;
            OrderGV.ColumnHeadersHeight = 29;
            OrderGV.Location = new Point(935, 589);
            OrderGV.Margin = new Padding(2);
            OrderGV.Name = "OrderGV";
            OrderGV.RowHeadersWidth = 62;
            OrderGV.RowTemplate.Height = 33;
            OrderGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrderGV.Size = new Size(743, 264);
            OrderGV.TabIndex = 57;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GrayText;
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(UserMenu_BT);
            panel3.Controls.Add(ProductsMenu_BT);
            panel3.Controls.Add(OrderMenu_BT);
            panel3.Controls.Add(CustomerMenu_BT);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(CategoriesMenu_BT);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 876);
            panel3.TabIndex = 58;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.user;
            pictureBox5.Location = new Point(3, 318);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(73, 42);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Product;
            pictureBox4.Location = new Point(3, 240);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(73, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.order;
            pictureBox3.Location = new Point(3, 164);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(73, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Customers;
            pictureBox2.Location = new Point(3, 89);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // UserMenu_BT
            // 
            UserMenu_BT.BackColor = SystemColors.GrayText;
            UserMenu_BT.Dock = DockStyle.Top;
            UserMenu_BT.FlatStyle = FlatStyle.Flat;
            UserMenu_BT.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            UserMenu_BT.Location = new Point(0, 300);
            UserMenu_BT.Name = "UserMenu_BT";
            UserMenu_BT.Size = new Size(267, 75);
            UserMenu_BT.TabIndex = 5;
            UserMenu_BT.Text = "Users";
            UserMenu_BT.UseVisualStyleBackColor = false;
            UserMenu_BT.Click += UserMenu_BT_Click;
            // 
            // ProductsMenu_BT
            // 
            ProductsMenu_BT.BackColor = SystemColors.GrayText;
            ProductsMenu_BT.Dock = DockStyle.Top;
            ProductsMenu_BT.FlatStyle = FlatStyle.Flat;
            ProductsMenu_BT.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ProductsMenu_BT.Location = new Point(0, 225);
            ProductsMenu_BT.Name = "ProductsMenu_BT";
            ProductsMenu_BT.Size = new Size(267, 75);
            ProductsMenu_BT.TabIndex = 4;
            ProductsMenu_BT.Text = "Product";
            ProductsMenu_BT.UseVisualStyleBackColor = false;
            ProductsMenu_BT.Click += ProductsMenu_BT_Click;
            // 
            // OrderMenu_BT
            // 
            OrderMenu_BT.BackColor = SystemColors.ControlDark;
            OrderMenu_BT.Dock = DockStyle.Top;
            OrderMenu_BT.FlatStyle = FlatStyle.Flat;
            OrderMenu_BT.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            OrderMenu_BT.Location = new Point(0, 150);
            OrderMenu_BT.Name = "OrderMenu_BT";
            OrderMenu_BT.Size = new Size(267, 75);
            OrderMenu_BT.TabIndex = 3;
            OrderMenu_BT.Text = "Order";
            OrderMenu_BT.UseVisualStyleBackColor = false;
            OrderMenu_BT.Click += OrderMenu_BT_Click;
            // 
            // CustomerMenu_BT
            // 
            CustomerMenu_BT.BackColor = SystemColors.GrayText;
            CustomerMenu_BT.Dock = DockStyle.Top;
            CustomerMenu_BT.FlatStyle = FlatStyle.Flat;
            CustomerMenu_BT.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerMenu_BT.Location = new Point(0, 75);
            CustomerMenu_BT.Name = "CustomerMenu_BT";
            CustomerMenu_BT.Size = new Size(267, 75);
            CustomerMenu_BT.TabIndex = 2;
            CustomerMenu_BT.Text = "Customers";
            CustomerMenu_BT.UseVisualStyleBackColor = false;
            CustomerMenu_BT.Click += CustomerMenu_BT_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.GrayText;
            pictureBox1.Image = Properties.Resources.Categories;
            pictureBox1.Location = new Point(3, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // CategoriesMenu_BT
            // 
            CategoriesMenu_BT.BackColor = SystemColors.GrayText;
            CategoriesMenu_BT.Dock = DockStyle.Top;
            CategoriesMenu_BT.FlatStyle = FlatStyle.Flat;
            CategoriesMenu_BT.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CategoriesMenu_BT.Location = new Point(0, 0);
            CategoriesMenu_BT.Name = "CategoriesMenu_BT";
            CategoriesMenu_BT.Size = new Size(267, 75);
            CategoriesMenu_BT.TabIndex = 0;
            CategoriesMenu_BT.Text = "Categories";
            CategoriesMenu_BT.UseVisualStyleBackColor = false;
            CategoriesMenu_BT.Click += CategoriesMenu_BT_Click;
            // 
            // ManageOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1700, 966);
            Controls.Add(panel3);
            Controls.Add(label11);
            Controls.Add(OrderGV);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageOrders";
            Load += ManageOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderGV).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label ExitApp_Label;
        private Label label2;
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
        private Label MinimizedApp_Label;
        private DataGridView OrderGV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button UserMenu_BT;
        private Button ProductsMenu_BT;
        private Button OrderMenu_BT;
        private Button CustomerMenu_BT;
        private PictureBox pictureBox1;
        private Button CategoriesMenu_BT;
    }
}