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
            label9 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            label10 = new Label();
            label11 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGV).BeginInit();
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
            panel1.Size = new Size(1471, 120);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(1399, 3);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(29, 38);
            label9.TabIndex = 39;
            label9.Text = "_";
            label9.Click += label9_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1432, 9);
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
            label2.Location = new Point(642, 75);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(165, 32);
            label2.TabIndex = 1;
            label2.Text = "Manage Users";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(427, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(618, 50);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // userNameTB
            // 
            userNameTB.BackColor = SystemColors.GrayText;
            userNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userNameTB.ForeColor = SystemColors.ButtonHighlight;
            userNameTB.Location = new Point(187, 245);
            userNameTB.Margin = new Padding(2, 3, 2, 3);
            userNameTB.Name = "userNameTB";
            userNameTB.Size = new Size(340, 34);
            userNameTB.TabIndex = 1;
            // 
            // fullNameTB
            // 
            fullNameTB.BackColor = SystemColors.GrayText;
            fullNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fullNameTB.ForeColor = SystemColors.ButtonHighlight;
            fullNameTB.Location = new Point(187, 320);
            fullNameTB.Margin = new Padding(2, 3, 2, 3);
            fullNameTB.Name = "fullNameTB";
            fullNameTB.Size = new Size(340, 34);
            fullNameTB.TabIndex = 2;
            // 
            // passwordTB
            // 
            passwordTB.BackColor = SystemColors.GrayText;
            passwordTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTB.ForeColor = SystemColors.ButtonHighlight;
            passwordTB.Location = new Point(187, 392);
            passwordTB.Margin = new Padding(2, 3, 2, 3);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(340, 34);
            passwordTB.TabIndex = 3;
            // 
            // TelephoneTB
            // 
            TelephoneTB.BackColor = SystemColors.GrayText;
            TelephoneTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TelephoneTB.ForeColor = SystemColors.ButtonHighlight;
            TelephoneTB.Location = new Point(187, 461);
            TelephoneTB.Margin = new Padding(2, 3, 2, 3);
            TelephoneTB.Name = "TelephoneTB";
            TelephoneTB.Size = new Size(340, 34);
            TelephoneTB.TabIndex = 4;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(192, 0, 0);
            btn_add.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.ForeColor = SystemColors.ControlLightLight;
            btn_add.Location = new Point(42, 553);
            btn_add.Margin = new Padding(2, 3, 2, 3);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(119, 65);
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
            btn_edit.Location = new Point(229, 553);
            btn_edit.Margin = new Padding(2, 3, 2, 3);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(119, 65);
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
            btn_delete.Location = new Point(408, 553);
            btn_delete.Margin = new Padding(2, 3, 2, 3);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(119, 65);
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
            btn_home.Location = new Point(11, 139);
            btn_home.Margin = new Padding(2, 3, 2, 3);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(119, 65);
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
            UsersGV.Location = new Point(613, 233);
            UsersGV.Margin = new Padding(2, 3, 2, 3);
            UsersGV.Name = "UsersGV";
            UsersGV.RowHeadersWidth = 62;
            UsersGV.RowTemplate.Height = 33;
            UsersGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UsersGV.Size = new Size(837, 415);
            UsersGV.TabIndex = 11;
            UsersGV.CellContentClick += UsersGV_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(936, 139);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(219, 50);
            label4.TabIndex = 12;
            label4.Text = "USERS LIST";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(42, 248);
            label5.Name = "label5";
            label5.Size = new Size(99, 28);
            label5.TabIndex = 13;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(41, 323);
            label6.Name = "label6";
            label6.Size = new Size(100, 28);
            label6.TabIndex = 14;
            label6.Text = "Full Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(41, 395);
            label7.Name = "label7";
            label7.Size = new Size(93, 28);
            label7.TabIndex = 15;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(42, 464);
            label8.Name = "label8";
            label8.Size = new Size(67, 28);
            label8.TabIndex = 16;
            label8.Text = "Phone";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Lucida Console", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.HighlightText;
            label10.Location = new Point(1342, 23);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(118, 17);
            label10.TabIndex = 2;
            label10.Text = "Version 1.0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Lucida Console", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.HighlightText;
            label11.Location = new Point(556, 16);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(318, 24);
            label11.TabIndex = 1;
            label11.Text = "Devolop By Adam Dobias";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlText;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 665);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1471, 51);
            panel2.TabIndex = 30;
            // 
            // ManageUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1471, 716);
            Controls.Add(panel2);
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
            Margin = new Padding(2, 3, 2, 3);
            Name = "ManageUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += ManageUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGV).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
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
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel panel2;
    }
}