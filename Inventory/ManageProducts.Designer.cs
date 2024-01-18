namespace Inventory
{
    partial class ManageProducts
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
            MinimazedApp_Label = new Label();
            ExitApp_Label = new Label();
            label2 = new Label();
            label4 = new Label();
            btn_home = new Button();
            searchCombo_Products = new ComboBox();
            btn_sreach = new Button();
            btn_Refresh = new Button();
            label11 = new Label();
            ProductGV = new DataGridView();
            ProdID = new DataGridViewTextBoxColumn();
            ProdName = new DataGridViewTextBoxColumn();
            ProdQty = new DataGridViewTextBoxColumn();
            ProdPrice = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            ProdCat = new DataGridViewTextBoxColumn();
            ProdFile = new DataGridViewTextBoxColumn();
            ProdText = new DataGridViewTextBoxColumn();
            Picture = new DataGridViewImageColumn();
            btn_Add = new Button();
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
            ((System.ComponentModel.ISupportInitialize)ProductGV).BeginInit();
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
            panel1.Controls.Add(MinimazedApp_Label);
            panel1.Controls.Add(ExitApp_Label);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1587, 90);
            panel1.TabIndex = 2;
            // 
            // MinimazedApp_Label
            // 
            MinimazedApp_Label.AutoSize = true;
            MinimazedApp_Label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            MinimazedApp_Label.ForeColor = Color.White;
            MinimazedApp_Label.Location = new Point(1533, 2);
            MinimazedApp_Label.Margin = new Padding(2, 0, 2, 0);
            MinimazedApp_Label.Name = "MinimazedApp_Label";
            MinimazedApp_Label.Size = new Size(22, 30);
            MinimazedApp_Label.TabIndex = 45;
            MinimazedApp_Label.Text = "_";
            MinimazedApp_Label.Click += MinimazedApp_Label_Click;
            // 
            // ExitApp_Label
            // 
            ExitApp_Label.AutoSize = true;
            ExitApp_Label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ExitApp_Label.ForeColor = Color.White;
            ExitApp_Label.Location = new Point(1562, 9);
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
            label2.Location = new Point(11, 18);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 1;
            label2.Text = "Manage Products";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(709, 105);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(218, 40);
            label4.TabIndex = 31;
            label4.Text = "PRODUCT LIST";
            // 
            // btn_home
            // 
            btn_home.BackColor = Color.FromArgb(192, 0, 0);
            btn_home.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_home.ForeColor = SystemColors.ControlLightLight;
            btn_home.Location = new Point(1480, 874);
            btn_home.Margin = new Padding(2);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(104, 49);
            btn_home.TabIndex = 35;
            btn_home.Text = "Home";
            btn_home.UseVisualStyleBackColor = false;
            btn_home.Click += btn_home_Click;
            // 
            // searchCombo_Products
            // 
            searchCombo_Products.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchCombo_Products.FormattingEnabled = true;
            searchCombo_Products.Location = new Point(1142, 152);
            searchCombo_Products.Name = "searchCombo_Products";
            searchCombo_Products.Size = new Size(324, 29);
            searchCombo_Products.TabIndex = 41;
            searchCombo_Products.Text = "Select Category";
            // 
            // btn_sreach
            // 
            btn_sreach.BackColor = Color.FromArgb(192, 0, 0);
            btn_sreach.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sreach.ForeColor = SystemColors.ControlLightLight;
            btn_sreach.Location = new Point(1471, 152);
            btn_sreach.Margin = new Padding(2);
            btn_sreach.Name = "btn_sreach";
            btn_sreach.Size = new Size(105, 28);
            btn_sreach.TabIndex = 42;
            btn_sreach.Text = "Sreach";
            btn_sreach.UseVisualStyleBackColor = false;
            btn_sreach.Click += btn_sreach_Click;
            // 
            // btn_Refresh
            // 
            btn_Refresh.BackColor = Color.FromArgb(192, 0, 0);
            btn_Refresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Refresh.ForeColor = SystemColors.ControlLightLight;
            btn_Refresh.Location = new Point(539, 883);
            btn_Refresh.Margin = new Padding(2);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(231, 50);
            btn_Refresh.TabIndex = 43;
            btn_Refresh.Text = "Refresh";
            btn_Refresh.UseVisualStyleBackColor = false;
            btn_Refresh.Click += btn_Refresh_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Lucida Console", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.HighlightText;
            label11.Location = new Point(1480, 937);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(95, 14);
            label11.TabIndex = 2;
            label11.Text = "Version 1.0";
            // 
            // ProductGV
            // 
            ProductGV.AllowUserToOrderColumns = true;
            ProductGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductGV.BackgroundColor = SystemColors.ButtonHighlight;
            ProductGV.ColumnHeadersHeight = 34;
            ProductGV.Columns.AddRange(new DataGridViewColumn[] { ProdID, ProdName, ProdQty, ProdPrice, Description, ProdCat, ProdFile, ProdText, Picture });
            ProductGV.Location = new Point(290, 201);
            ProductGV.Name = "ProductGV";
            ProductGV.ReadOnly = true;
            ProductGV.RowHeadersWidth = 62;
            ProductGV.RowTemplate.Height = 25;
            ProductGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductGV.Size = new Size(1285, 658);
            ProductGV.TabIndex = 50;
            ProductGV.CellClick += ProductGV_CellClick;
            // 
            // ProdID
            // 
            ProdID.DataPropertyName = "ProdId";
            ProdID.FillWeight = 16.86007F;
            ProdID.HeaderText = "ProdId";
            ProdID.MinimumWidth = 8;
            ProdID.Name = "ProdID";
            ProdID.ReadOnly = true;
            // 
            // ProdName
            // 
            ProdName.DataPropertyName = "ProdName";
            ProdName.FillWeight = 16.86007F;
            ProdName.HeaderText = "ProdName";
            ProdName.MinimumWidth = 8;
            ProdName.Name = "ProdName";
            ProdName.ReadOnly = true;
            // 
            // ProdQty
            // 
            ProdQty.DataPropertyName = "ProdQty";
            ProdQty.FillWeight = 16.86007F;
            ProdQty.HeaderText = "ProdQty";
            ProdQty.MinimumWidth = 8;
            ProdQty.Name = "ProdQty";
            ProdQty.ReadOnly = true;
            // 
            // ProdPrice
            // 
            ProdPrice.DataPropertyName = "ProdPrice";
            ProdPrice.FillWeight = 16.86007F;
            ProdPrice.HeaderText = "ProdPrice";
            ProdPrice.MinimumWidth = 8;
            ProdPrice.Name = "ProdPrice";
            ProdPrice.ReadOnly = true;
            // 
            // Description
            // 
            Description.DataPropertyName = "ProdDesc";
            Description.FillWeight = 16.86007F;
            Description.HeaderText = "Description";
            Description.MinimumWidth = 8;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // ProdCat
            // 
            ProdCat.DataPropertyName = "ProdCat";
            ProdCat.FillWeight = 16.86007F;
            ProdCat.HeaderText = "ProdCat";
            ProdCat.MinimumWidth = 8;
            ProdCat.Name = "ProdCat";
            ProdCat.ReadOnly = true;
            // 
            // ProdFile
            // 
            ProdFile.DataPropertyName = "ProdFile";
            ProdFile.FillWeight = 16.86007F;
            ProdFile.HeaderText = "ProdFile";
            ProdFile.MinimumWidth = 8;
            ProdFile.Name = "ProdFile";
            ProdFile.ReadOnly = true;
            // 
            // ProdText
            // 
            ProdText.DataPropertyName = "ProdText";
            ProdText.FillWeight = 16.86007F;
            ProdText.HeaderText = "ProdText";
            ProdText.MinimumWidth = 8;
            ProdText.Name = "ProdText";
            ProdText.ReadOnly = true;
            // 
            // Picture
            // 
            Picture.DataPropertyName = "ProdImage";
            Picture.FillWeight = 45.87774F;
            Picture.HeaderText = "Picture";
            Picture.MinimumWidth = 8;
            Picture.Name = "Picture";
            Picture.ReadOnly = true;
            Picture.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(192, 0, 0);
            btn_Add.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Add.ForeColor = SystemColors.ControlLightLight;
            btn_Add.Location = new Point(290, 883);
            btn_Add.Margin = new Padding(2);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(231, 50);
            btn_Add.TabIndex = 75;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_add_Click;
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
            panel3.Size = new Size(267, 870);
            panel3.TabIndex = 76;
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
            ProductsMenu_BT.BackColor = SystemColors.ControlDark;
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
            OrderMenu_BT.BackColor = SystemColors.GrayText;
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
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1587, 960);
            Controls.Add(panel3);
            Controls.Add(label11);
            Controls.Add(btn_Add);
            Controls.Add(ProductGV);
            Controls.Add(btn_Refresh);
            Controls.Add(btn_sreach);
            Controls.Add(searchCombo_Products);
            Controls.Add(btn_home);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageProducts";
            Load += ManageProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductGV).EndInit();
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
        private Label label4;
        private Button btn_home;
        private ComboBox searchCombo_Products;
        private Button btn_sreach;
        private Button btn_Refresh;
        private Label label11;
        private Label MinimazedApp_Label;
        private DataGridView ProductGV;
        public Button btn_Add;
        private DataGridViewTextBoxColumn ProdID;
        private DataGridViewTextBoxColumn ProdName;
        private DataGridViewTextBoxColumn ProdQty;
        private DataGridViewTextBoxColumn ProdPrice;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn ProdCat;
        private DataGridViewTextBoxColumn ProdFile;
        private DataGridViewTextBoxColumn ProdText;
        private DataGridViewImageColumn Picture;
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