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
            label9 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            label7 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryGV).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlText;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 120);
            panel1.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(1328, 0);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(29, 38);
            label9.TabIndex = 1;
            label9.Text = "_";
            label9.Click += label9_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1361, 7);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(28, 32);
            label3.TabIndex = 2;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(615, 70);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(221, 32);
            label2.TabIndex = 14;
            label2.Text = "Manage Categories";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(403, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(618, 50);
            label1.TabIndex = 13;
            label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(45, 377);
            label6.Name = "label6";
            label6.Size = new Size(154, 28);
            label6.TabIndex = 22;
            label6.Text = "Categorie Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(45, 275);
            label5.Name = "label5";
            label5.Size = new Size(127, 28);
            label5.TabIndex = 21;
            label5.Text = "Categories Id";
            // 
            // categoryName_TB
            // 
            categoryName_TB.BackColor = SystemColors.GrayText;
            categoryName_TB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            categoryName_TB.ForeColor = SystemColors.ButtonHighlight;
            categoryName_TB.Location = new Point(223, 377);
            categoryName_TB.Margin = new Padding(2, 3, 2, 3);
            categoryName_TB.Name = "categoryName_TB";
            categoryName_TB.Size = new Size(340, 34);
            categoryName_TB.TabIndex = 5;
            // 
            // categoryId_TB
            // 
            categoryId_TB.BackColor = SystemColors.GrayText;
            categoryId_TB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            categoryId_TB.ForeColor = SystemColors.AppWorkspace;
            categoryId_TB.Location = new Point(223, 268);
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
            CategoryGV.Location = new Point(641, 268);
            CategoryGV.Margin = new Padding(2, 3, 2, 3);
            CategoryGV.Name = "CategoryGV";
            CategoryGV.RowHeadersWidth = 62;
            CategoryGV.RowTemplate.Height = 33;
            CategoryGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CategoryGV.Size = new Size(735, 463);
            CategoryGV.TabIndex = 9;
            CategoryGV.CellContentClick += CategoryGV_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(839, 181);
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
            btn_home.Location = new Point(11, 125);
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
            btn_delete.Location = new Point(421, 452);
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
            btn_edit.Location = new Point(241, 452);
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
            btn_add.Location = new Point(53, 452);
            btn_add.Margin = new Padding(2, 3, 2, 3);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(119, 65);
            btn_add.TabIndex = 6;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Lucida Console", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.HighlightText;
            label7.Location = new Point(1271, 23);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(118, 17);
            label7.TabIndex = 12;
            label7.Text = "Version 1.0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Lucida Console", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.HighlightText;
            label8.Location = new Point(551, 16);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(318, 24);
            label8.TabIndex = 11;
            label8.Text = "Devolop By Adam Dobias";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlText;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 756);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1400, 51);
            panel2.TabIndex = 29;
            // 
            // ManageCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1400, 807);
            Controls.Add(panel2);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
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
        private Label label7;
        private Label label8;
        private Panel panel2;
        private Label label9;
    }
}