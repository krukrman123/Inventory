namespace Inventory
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_Login = new Panel();
            btn_clear = new Button();
            pictureBox1 = new PictureBox();
            HeadingLabel_Text = new Label();
            Password_CheckBox = new CheckBox();
            LOGIN = new Button();
            label4 = new Label();
            label3 = new Label();
            PasswordTB = new TextBox();
            Username_TB = new TextBox();
            CreateNewAccount_BT = new Button();
            ExitApp_Label = new Label();
            label1 = new Label();
            MinizedApp_Label = new Label();
            panel1 = new Panel();
            label7 = new Label();
            panel_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Login
            // 
            panel_Login.BackColor = SystemColors.GrayText;
            panel_Login.Controls.Add(btn_clear);
            panel_Login.Controls.Add(pictureBox1);
            panel_Login.Controls.Add(HeadingLabel_Text);
            panel_Login.Controls.Add(Password_CheckBox);
            panel_Login.Controls.Add(LOGIN);
            panel_Login.Controls.Add(label4);
            panel_Login.Controls.Add(label3);
            panel_Login.Controls.Add(PasswordTB);
            panel_Login.Controls.Add(Username_TB);
            panel_Login.Location = new Point(24, 27);
            panel_Login.Name = "panel_Login";
            panel_Login.Size = new Size(679, 263);
            panel_Login.TabIndex = 0;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = SystemColors.GrayText;
            btn_clear.FlatStyle = FlatStyle.System;
            btn_clear.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clear.ForeColor = SystemColors.ButtonHighlight;
            btn_clear.Location = new Point(412, 224);
            btn_clear.Margin = new Padding(2);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(229, 30);
            btn_clear.TabIndex = 9;
            btn_clear.Text = "CLEAR";
            btn_clear.TextAlign = ContentAlignment.MiddleLeft;
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pngkey_Transparent;
            pictureBox1.Location = new Point(44, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // HeadingLabel_Text
            // 
            HeadingLabel_Text.AutoSize = true;
            HeadingLabel_Text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HeadingLabel_Text.ForeColor = SystemColors.ButtonHighlight;
            HeadingLabel_Text.Location = new Point(179, 50);
            HeadingLabel_Text.Name = "HeadingLabel_Text";
            HeadingLabel_Text.Size = new Size(217, 21);
            HeadingLabel_Text.TabIndex = 1;
            HeadingLabel_Text.Text = "Inventory Managment system";
            // 
            // Password_CheckBox
            // 
            Password_CheckBox.AutoSize = true;
            Password_CheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Password_CheckBox.ForeColor = Color.White;
            Password_CheckBox.Location = new Point(179, 196);
            Password_CheckBox.Margin = new Padding(2);
            Password_CheckBox.Name = "Password_CheckBox";
            Password_CheckBox.Size = new Size(134, 25);
            Password_CheckBox.TabIndex = 7;
            Password_CheckBox.Text = "ShowPassword";
            Password_CheckBox.UseVisualStyleBackColor = true;
            Password_CheckBox.CheckedChanged += Password_CheckBox_CheckedChanged;
            // 
            // LOGIN
            // 
            LOGIN.BackColor = SystemColors.GrayText;
            LOGIN.FlatStyle = FlatStyle.System;
            LOGIN.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LOGIN.ForeColor = SystemColors.ButtonHighlight;
            LOGIN.Location = new Point(179, 224);
            LOGIN.Margin = new Padding(2);
            LOGIN.Name = "LOGIN";
            LOGIN.Size = new Size(229, 30);
            LOGIN.TabIndex = 5;
            LOGIN.Text = "LOGIN";
            LOGIN.TextAlign = ContentAlignment.MiddleLeft;
            LOGIN.UseVisualStyleBackColor = false;
            LOGIN.Click += LOGIN_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(74, 153);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(32, 115);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 3;
            label3.Text = "Account Name";
            // 
            // PasswordTB
            // 
            PasswordTB.BackColor = SystemColors.GrayText;
            PasswordTB.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTB.ForeColor = SystemColors.ButtonHighlight;
            PasswordTB.Location = new Point(179, 153);
            PasswordTB.Margin = new Padding(2);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(462, 34);
            PasswordTB.TabIndex = 2;
            PasswordTB.Text = "Type Password";
            PasswordTB.UseSystemPasswordChar = true;
            // 
            // Username_TB
            // 
            Username_TB.BackColor = SystemColors.GrayText;
            Username_TB.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Username_TB.ForeColor = SystemColors.ButtonHighlight;
            Username_TB.Location = new Point(179, 110);
            Username_TB.Margin = new Padding(2);
            Username_TB.Name = "Username_TB";
            Username_TB.Size = new Size(462, 34);
            Username_TB.TabIndex = 1;
            Username_TB.Text = "Type Username";
            // 
            // CreateNewAccount_BT
            // 
            CreateNewAccount_BT.BackColor = SystemColors.GrayText;
            CreateNewAccount_BT.FlatStyle = FlatStyle.System;
            CreateNewAccount_BT.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CreateNewAccount_BT.ForeColor = SystemColors.ButtonHighlight;
            CreateNewAccount_BT.Location = new Point(235, 31);
            CreateNewAccount_BT.Margin = new Padding(2);
            CreateNewAccount_BT.Name = "CreateNewAccount_BT";
            CreateNewAccount_BT.Size = new Size(404, 30);
            CreateNewAccount_BT.TabIndex = 10;
            CreateNewAccount_BT.Text = "CREATE NEW ACCOUNT...";
            CreateNewAccount_BT.TextAlign = ContentAlignment.MiddleLeft;
            CreateNewAccount_BT.UseVisualStyleBackColor = false;
            CreateNewAccount_BT.Click += CreateNewAccount_BT_Click;
            // 
            // ExitApp_Label
            // 
            ExitApp_Label.AutoSize = true;
            ExitApp_Label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ExitApp_Label.ForeColor = Color.White;
            ExitApp_Label.Location = new Point(697, 7);
            ExitApp_Label.Margin = new Padding(2, 0, 2, 0);
            ExitApp_Label.Name = "ExitApp_Label";
            ExitApp_Label.Size = new Size(23, 25);
            ExitApp_Label.TabIndex = 3;
            ExitApp_Label.Text = "X";
            ExitApp_Label.Click += ExitApp_Label_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(209, 15);
            label1.TabIndex = 4;
            label1.Text = "Inventory Managment System Login";
            // 
            // MinizedApp_Label
            // 
            MinizedApp_Label.AutoSize = true;
            MinizedApp_Label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            MinizedApp_Label.ForeColor = Color.White;
            MinizedApp_Label.Location = new Point(668, 0);
            MinizedApp_Label.Margin = new Padding(2, 0, 2, 0);
            MinizedApp_Label.Name = "MinizedApp_Label";
            MinizedApp_Label.Size = new Size(22, 30);
            MinizedApp_Label.TabIndex = 5;
            MinizedApp_Label.Text = "_";
            MinizedApp_Label.Click += MinizedApp_Label_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(CreateNewAccount_BT);
            panel1.Location = new Point(24, 296);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 90);
            panel1.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(72, 35);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(143, 21);
            label7.TabIndex = 10;
            label7.Text = "Dont Have Account";
            // 
            // LoginForm
            // 
            AcceptButton = LOGIN;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(732, 403);
            Controls.Add(panel1);
            Controls.Add(MinizedApp_Label);
            Controls.Add(label1);
            Controls.Add(ExitApp_Label);
            Controls.Add(panel_Login);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel_Login.ResumeLayout(false);
            panel_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_Login;
        private Label HeadingLabel_Text;
        private TextBox PasswordTB;
        private TextBox Username_TB;
        private Label label4;
        private Label label3;
        private CheckBox Password_CheckBox;
        private Button LOGIN;
        private PictureBox pictureBox1;
        private Label ExitApp_Label;
        private Button btn_clear;
        private Label label1;
        private Label MinizedApp_Label;
        private Button CreateNewAccount_BT;
        private Panel panel1;
        private Label label7;
    }
}