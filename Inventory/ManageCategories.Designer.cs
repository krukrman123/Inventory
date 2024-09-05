namespace Inventory
{
    partial class ManageCategories
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
            label6 = new Label();
            label5 = new Label();
            categoryName_TB = new TextBox();
            categoryId_TB = new TextBox();
            CategoryGV = new DataGridView();
            label4 = new Label();
            btn_home = new Button();
            btn_delete = new Button();
            btn_edit = new Button();
            btn_add = new Button();
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
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryGV).BeginInit();
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
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1633, 120);
            panel1.TabIndex = 1;
            // 
            // MinimizedApp_Label
            // 
            MinimizedApp_Label.AutoSize = true;
            MinimizedApp_Label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            MinimizedApp_Label.ForeColor = Color.White;
            MinimizedApp_Label.Location = new Point(1561, 5);
            MinimizedApp_Label.Margin = new Padding(2, 0, 2, 0);
            MinimizedApp_Label.Name = "MinimizedApp_Label";
            MinimizedApp_Label.Size = new Size(29, 38);
            MinimizedApp_Label.TabIndex = 1;
            MinimizedApp_Label.Text = "_";
            MinimizedApp_Label.Click += MinimizedApp_Label_Click;
            // 
            // ExitApp_Label
            // 
            ExitApp_Label.AutoSize = true;
            ExitApp_Label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ExitApp_Label.ForeColor = Color.White;
            ExitApp_Label.Location = new Point(1594, 12);
            ExitApp_Label.Margin = new Padding(2, 0, 2, 0);
            ExitApp_Label.Name = "ExitApp_Label";
            ExitApp_Label.Size = new Size(28, 32);
            ExitApp_Label.TabIndex = 2;
            ExitApp_Label.Text = "X";
            ExitApp_Label.Click += ExitApp_Label_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 12);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(221, 32);
            label2.TabIndex = 14;
            label2.Text = "Manage Categories";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(341, 1043);
            label6.Name = "label6";
            label6.Size = new Size(165, 28);
            label6.TabIndex = 22;
            label6.Text = "Categorie Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(341, 940);
            label5.Name = "label5";
            label5.Size = new Size(136, 28);
            label5.TabIndex = 21;
            label5.Text = "Categories Id";
            // 
            // categoryName_TB
            // 
            categoryName_TB.BackColor = SystemColors.ControlLightLight;
            categoryName_TB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            categoryName_TB.ForeColor = SystemColors.ActiveCaptionText;
            categoryName_TB.Location = new Point(519, 1043);
            categoryName_TB.Margin = new Padding(2, 3, 2, 3);
            categoryName_TB.Name = "categoryName_TB";
            categoryName_TB.Size = new Size(340, 34);
            categoryName_TB.TabIndex = 5;
            // 
            // categoryId_TB
            // 
            categoryId_TB.BackColor = SystemColors.ControlLightLight;
            categoryId_TB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            categoryId_TB.ForeColor = SystemColors.ActiveCaptionText;
            categoryId_TB.Location = new Point(519, 933);
            categoryId_TB.Margin = new Padding(2, 3, 2, 3);
            categoryId_TB.Name = "categoryId_TB";
            categoryId_TB.ReadOnly = true;
            categoryId_TB.Size = new Size(340, 34);
            categoryId_TB.TabIndex = 4;
            categoryId_TB.KeyPress += category_TB_KeyPress;
            // 
            // CategoryGV
            // 
            CategoryGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CategoryGV.BackgroundColor = SystemColors.ButtonHighlight;
            CategoryGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryGV.Location = new Point(349, 220);
            CategoryGV.Margin = new Padding(2, 3, 2, 3);
            CategoryGV.Name = "CategoryGV";
            CategoryGV.RowHeadersWidth = 62;
            CategoryGV.RowTemplate.Height = 33;
            CategoryGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CategoryGV.Size = new Size(1238, 613);
            CategoryGV.TabIndex = 9;
            CategoryGV.CellContentClick += CategoryGV_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(810, 140);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(325, 50);
            label4.TabIndex = 10;
            label4.Text = "CATEGORIES LIST";
            // 
            // btn_home
            // 
            btn_home.BackColor = Color.FromArgb(192, 0, 0);
            btn_home.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_home.ForeColor = SystemColors.ControlLightLight;
            btn_home.Location = new Point(1498, 1168);
            btn_home.Margin = new Padding(2, 3, 2, 3);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(119, 65);
            btn_home.TabIndex = 3;
            btn_home.Text = "Home";
            btn_home.UseVisualStyleBackColor = false;
            btn_home.Click += btn_home_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(192, 0, 0);
            btn_delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = SystemColors.ControlLightLight;
            btn_delete.Location = new Point(733, 1168);
            btn_delete.Margin = new Padding(2, 3, 2, 3);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(119, 65);
            btn_delete.TabIndex = 8;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(192, 0, 0);
            btn_edit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edit.ForeColor = SystemColors.ControlLightLight;
            btn_edit.Location = new Point(542, 1168);
            btn_edit.Margin = new Padding(2, 3, 2, 3);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(119, 65);
            btn_edit.TabIndex = 7;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(192, 0, 0);
            btn_add.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.ForeColor = SystemColors.ControlLightLight;
            btn_add.Location = new Point(341, 1168);
            btn_add.Margin = new Padding(2, 3, 2, 3);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(119, 65);
            btn_add.TabIndex = 6;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
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
            panel3.Location = new Point(0, 120);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(305, 1160);
            panel3.TabIndex = 30;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.user;
            pictureBox5.Location = new Point(3, 424);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(83, 56);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Product;
            pictureBox4.Location = new Point(3, 320);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(83, 56);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.order;
            pictureBox3.Location = new Point(3, 219);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(83, 56);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Customers;
            pictureBox2.Location = new Point(3, 119);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(83, 56);
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
            UserMenu_BT.Location = new Point(0, 400);
            UserMenu_BT.Margin = new Padding(3, 4, 3, 4);
            UserMenu_BT.Name = "UserMenu_BT";
            UserMenu_BT.Size = new Size(305, 100);
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
            ProductsMenu_BT.Location = new Point(0, 300);
            ProductsMenu_BT.Margin = new Padding(3, 4, 3, 4);
            ProductsMenu_BT.Name = "ProductsMenu_BT";
            ProductsMenu_BT.Size = new Size(305, 100);
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
            OrderMenu_BT.Location = new Point(0, 200);
            OrderMenu_BT.Margin = new Padding(3, 4, 3, 4);
            OrderMenu_BT.Name = "OrderMenu_BT";
            OrderMenu_BT.Size = new Size(305, 100);
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
            CustomerMenu_BT.Location = new Point(0, 100);
            CustomerMenu_BT.Margin = new Padding(3, 4, 3, 4);
            CustomerMenu_BT.Name = "CustomerMenu_BT";
            CustomerMenu_BT.Size = new Size(305, 100);
            CustomerMenu_BT.TabIndex = 2;
            CustomerMenu_BT.Text = "Customers";
            CustomerMenu_BT.UseVisualStyleBackColor = false;
            CustomerMenu_BT.Click += CustomerMenu_BT_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.GrayText;
            pictureBox1.Image = Properties.Resources.Categories;
            pictureBox1.Location = new Point(3, 17);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // CategoriesMenu_BT
            // 
            CategoriesMenu_BT.BackColor = SystemColors.ControlDark;
            CategoriesMenu_BT.Dock = DockStyle.Top;
            CategoriesMenu_BT.FlatStyle = FlatStyle.Flat;
            CategoriesMenu_BT.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CategoriesMenu_BT.Location = new Point(0, 0);
            CategoriesMenu_BT.Margin = new Padding(3, 4, 3, 4);
            CategoriesMenu_BT.Name = "CategoriesMenu_BT";
            CategoriesMenu_BT.Size = new Size(305, 100);
            CategoriesMenu_BT.TabIndex = 0;
            CategoriesMenu_BT.Text = "Categories";
            CategoriesMenu_BT.UseVisualStyleBackColor = false;
            CategoriesMenu_BT.Click += CategoriesMenu_BT_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Desktop;
            label7.Location = new Point(1498, 1249);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(129, 17);
            label7.TabIndex = 13;
            label7.Text = "Version 1.0";
            // 
            // ManageCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1633, 1280);
            Controls.Add(label7);
            Controls.Add(panel3);
            Controls.Add(btn_home);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(label4);
            Controls.Add(CategoryGV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(categoryName_TB);
            Controls.Add(categoryId_TB);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCategories";
            Load += ManageCategories_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryGV).EndInit();
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
        private Label label6;
        private Label label5;
        private TextBox categoryName_TB;
        private TextBox categoryId_TB;
        private DataGridView CategoryGV;
        private Label label4;
        private Button btn_home;
        private Button btn_delete;
        private Button btn_edit;
        private Button btn_add;
        private Label MinimizedApp_Label;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button CategoriesMenu_BT;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button UserMenu_BT;
        private Button ProductsMenu_BT;
        private Button OrderMenu_BT;
        private Button CustomerMenu_BT;
        private Label label7;
    }
}