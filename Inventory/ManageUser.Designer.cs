namespace Inventory
{
    partial class ManageUser
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
            ExitAapp_Label = new Label();
            label2 = new Label();
            userNameTB = new TextBox();
            fullNameTB = new TextBox();
            passwordTB = new TextBox();
            TelephoneTB = new TextBox();
            btn_add = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            btn_home = new Button();
            UsersGV = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
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
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGV).BeginInit();
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
            panel1.Controls.Add(ExitAapp_Label);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1429, 90);
            panel1.TabIndex = 0;
            // 
            // MinimizedApp_Label
            // 
            MinimizedApp_Label.AutoSize = true;
            MinimizedApp_Label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            MinimizedApp_Label.ForeColor = Color.White;
            MinimizedApp_Label.Location = new Point(1366, 4);
            MinimizedApp_Label.Margin = new Padding(2, 0, 2, 0);
            MinimizedApp_Label.Name = "MinimizedApp_Label";
            MinimizedApp_Label.Size = new Size(22, 30);
            MinimizedApp_Label.TabIndex = 39;
            MinimizedApp_Label.Text = "_";
            MinimizedApp_Label.Click += MinimizedApp_Label_Click;
            // 
            // ExitAapp_Label
            // 
            ExitAapp_Label.AutoSize = true;
            ExitAapp_Label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ExitAapp_Label.ForeColor = Color.White;
            ExitAapp_Label.Location = new Point(1395, 9);
            ExitAapp_Label.Margin = new Padding(2, 0, 2, 0);
            ExitAapp_Label.Name = "ExitAapp_Label";
            ExitAapp_Label.Size = new Size(23, 25);
            ExitAapp_Label.TabIndex = 2;
            ExitAapp_Label.Text = "X";
            ExitAapp_Label.Click += ExitAapp_Label_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 1;
            label2.Text = "Manage Users";
            // 
            // userNameTB
            // 
            userNameTB.BackColor = SystemColors.ControlLightLight;
            userNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userNameTB.ForeColor = SystemColors.ActiveCaptionText;
            userNameTB.Location = new Point(447, 650);
            userNameTB.Margin = new Padding(2);
            userNameTB.Name = "userNameTB";
            userNameTB.Size = new Size(298, 29);
            userNameTB.TabIndex = 1;
            // 
            // fullNameTB
            // 
            fullNameTB.BackColor = SystemColors.ControlLightLight;
            fullNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fullNameTB.ForeColor = SystemColors.ActiveCaptionText;
            fullNameTB.Location = new Point(447, 709);
            fullNameTB.Margin = new Padding(2);
            fullNameTB.Name = "fullNameTB";
            fullNameTB.Size = new Size(298, 29);
            fullNameTB.TabIndex = 2;
            // 
            // passwordTB
            // 
            passwordTB.BackColor = SystemColors.ControlLightLight;
            passwordTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTB.ForeColor = SystemColors.ActiveCaptionText;
            passwordTB.Location = new Point(447, 760);
            passwordTB.Margin = new Padding(2);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(298, 29);
            passwordTB.TabIndex = 3;
            // 
            // TelephoneTB
            // 
            TelephoneTB.BackColor = SystemColors.ControlLightLight;
            TelephoneTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TelephoneTB.ForeColor = SystemColors.ActiveCaptionText;
            TelephoneTB.Location = new Point(447, 812);
            TelephoneTB.Margin = new Padding(2);
            TelephoneTB.Name = "TelephoneTB";
            TelephoneTB.Size = new Size(298, 29);
            TelephoneTB.TabIndex = 4;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(192, 0, 0);
            btn_add.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.ForeColor = SystemColors.ControlLightLight;
            btn_add.Location = new Point(298, 876);
            btn_add.Margin = new Padding(2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(104, 49);
            btn_add.TabIndex = 5;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(192, 0, 0);
            btn_edit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edit.ForeColor = SystemColors.ControlLightLight;
            btn_edit.Location = new Point(474, 876);
            btn_edit.Margin = new Padding(2);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(104, 49);
            btn_edit.TabIndex = 6;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(192, 0, 0);
            btn_delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = SystemColors.ControlLightLight;
            btn_delete.Location = new Point(641, 876);
            btn_delete.Margin = new Padding(2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(104, 49);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_home
            // 
            btn_home.BackColor = Color.FromArgb(192, 0, 0);
            btn_home.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_home.ForeColor = SystemColors.ControlLightLight;
            btn_home.Location = new Point(1311, 876);
            btn_home.Margin = new Padding(2);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(104, 49);
            btn_home.TabIndex = 8;
            btn_home.Text = "Home";
            btn_home.UseVisualStyleBackColor = false;
            btn_home.Click += btn_home_Click;
            // 
            // UsersGV
            // 
            UsersGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UsersGV.BackgroundColor = SystemColors.ButtonHighlight;
            UsersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersGV.Location = new Point(305, 165);
            UsersGV.Margin = new Padding(2);
            UsersGV.Name = "UsersGV";
            UsersGV.RowHeadersWidth = 62;
            UsersGV.RowTemplate.Height = 33;
            UsersGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UsersGV.Size = new Size(1083, 460);
            UsersGV.TabIndex = 11;
            UsersGV.CellContentClick += UsersGV_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(709, 105);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(169, 40);
            label4.TabIndex = 12;
            label4.Text = "USERS LIST";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(305, 658);
            label5.Name = "label5";
            label5.Size = new Size(87, 21);
            label5.TabIndex = 13;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(305, 709);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 14;
            label6.Text = "Full Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(305, 763);
            label7.Name = "label7";
            label7.Size = new Size(82, 21);
            label7.TabIndex = 15;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(305, 820);
            label8.Name = "label8";
            label8.Size = new Size(59, 21);
            label8.TabIndex = 16;
            label8.Text = "Phone";
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
            panel3.TabIndex = 31;
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
            UserMenu_BT.BackColor = SystemColors.ControlDark;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(1311, 937);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 13);
            label1.TabIndex = 32;
            label1.Text = "Version 1.0";
            // 
            // ManageUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1429, 960);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(UsersGV);
            Controls.Add(btn_home);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(TelephoneTB);
            Controls.Add(passwordTB);
            Controls.Add(fullNameTB);
            Controls.Add(userNameTB);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ManageUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += ManageUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGV).EndInit();
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
        private Label label2;
        private Label ExitAapp_Label;
        private TextBox userNameTB;
        private TextBox fullNameTB;
        private TextBox passwordTB;
        private TextBox TelephoneTB;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_delete;
        private Button btn_home;
        private DataGridView UsersGV;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label MinimizedApp_Label;
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
        private Label label1;
    }
}