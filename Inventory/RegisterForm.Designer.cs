namespace Inventory
{
    partial class RegisterForm
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
            panel_Register = new Panel();
            BackToLogin_BT = new Button();
            PhoneLabel_Text = new Label();
            FullNameLabel_Text = new Label();
            FullNameTB = new TextBox();
            clear_BT = new Button();
            TelephoneTB = new TextBox();
            Key_Picture = new PictureBox();
            HeadingLabel = new Label();
            ShowPassword_CheckBox = new CheckBox();
            Register_BT = new Button();
            PasswordLabel_Text = new Label();
            AccountLabel_Text = new Label();
            PasswordTB = new TextBox();
            UsernameTB = new TextBox();
            MinimizedLabel_TB = new Label();
            ExitLabel_TB = new Label();
            HeadingForm_Text = new Label();
            panel_Register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Key_Picture).BeginInit();
            SuspendLayout();
            // 
            // panel_Register
            // 
            panel_Register.BackColor = SystemColors.GrayText;
            panel_Register.Controls.Add(BackToLogin_BT);
            panel_Register.Controls.Add(PhoneLabel_Text);
            panel_Register.Controls.Add(FullNameLabel_Text);
            panel_Register.Controls.Add(FullNameTB);
            panel_Register.Controls.Add(clear_BT);
            panel_Register.Controls.Add(TelephoneTB);
            panel_Register.Controls.Add(Key_Picture);
            panel_Register.Controls.Add(HeadingLabel);
            panel_Register.Controls.Add(ShowPassword_CheckBox);
            panel_Register.Controls.Add(Register_BT);
            panel_Register.Controls.Add(PasswordLabel_Text);
            panel_Register.Controls.Add(AccountLabel_Text);
            panel_Register.Controls.Add(PasswordTB);
            panel_Register.Controls.Add(UsernameTB);
            panel_Register.Location = new Point(23, 36);
            panel_Register.Name = "panel_Register";
            panel_Register.Size = new Size(679, 356);
            panel_Register.TabIndex = 0;
            // 
            // BackToLogin_BT
            // 
            BackToLogin_BT.BackColor = SystemColors.GrayText;
            BackToLogin_BT.BackgroundImageLayout = ImageLayout.None;
            BackToLogin_BT.FlatStyle = FlatStyle.System;
            BackToLogin_BT.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BackToLogin_BT.ForeColor = SystemColors.ButtonHighlight;
            BackToLogin_BT.Location = new Point(31, 313);
            BackToLogin_BT.Margin = new Padding(1);
            BackToLogin_BT.Name = "BackToLogin_BT";
            BackToLogin_BT.Size = new Size(67, 30);
            BackToLogin_BT.TabIndex = 14;
            BackToLogin_BT.Text = "BACK";
            BackToLogin_BT.UseVisualStyleBackColor = false;
            BackToLogin_BT.Click += BackToRegister_Click;
            // 
            // PhoneLabel_Text
            // 
            PhoneLabel_Text.AutoSize = true;
            PhoneLabel_Text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneLabel_Text.ForeColor = SystemColors.ButtonHighlight;
            PhoneLabel_Text.Location = new Point(32, 256);
            PhoneLabel_Text.Margin = new Padding(1, 0, 1, 0);
            PhoneLabel_Text.Name = "PhoneLabel_Text";
            PhoneLabel_Text.Size = new Size(80, 21);
            PhoneLabel_Text.TabIndex = 13;
            PhoneLabel_Text.Text = "Telephone";
            // 
            // FullNameLabel_Text
            // 
            FullNameLabel_Text.AutoSize = true;
            FullNameLabel_Text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FullNameLabel_Text.ForeColor = SystemColors.ButtonHighlight;
            FullNameLabel_Text.Location = new Point(31, 157);
            FullNameLabel_Text.Margin = new Padding(1, 0, 1, 0);
            FullNameLabel_Text.Name = "FullNameLabel_Text";
            FullNameLabel_Text.Size = new Size(77, 21);
            FullNameLabel_Text.TabIndex = 12;
            FullNameLabel_Text.Text = "FullName";
            // 
            // FullNameTB
            // 
            FullNameTB.BackColor = SystemColors.GrayText;
            FullNameTB.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            FullNameTB.ForeColor = SystemColors.ButtonHighlight;
            FullNameTB.Location = new Point(179, 148);
            FullNameTB.Margin = new Padding(1);
            FullNameTB.Name = "FullNameTB";
            FullNameTB.Size = new Size(462, 34);
            FullNameTB.TabIndex = 2;
            // 
            // clear_BT
            // 
            clear_BT.BackColor = SystemColors.GrayText;
            clear_BT.FlatStyle = FlatStyle.System;
            clear_BT.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clear_BT.ForeColor = SystemColors.ButtonHighlight;
            clear_BT.Location = new Point(411, 313);
            clear_BT.Margin = new Padding(1);
            clear_BT.Name = "clear_BT";
            clear_BT.Size = new Size(230, 30);
            clear_BT.TabIndex = 7;
            clear_BT.Text = "CLEAR";
            clear_BT.TextAlign = ContentAlignment.MiddleLeft;
            clear_BT.UseVisualStyleBackColor = false;
            clear_BT.Click += btn_clear_Click;
            // 
            // TelephoneTB
            // 
            TelephoneTB.BackColor = SystemColors.GrayText;
            TelephoneTB.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TelephoneTB.ForeColor = SystemColors.ButtonHighlight;
            TelephoneTB.Location = new Point(178, 243);
            TelephoneTB.Margin = new Padding(1);
            TelephoneTB.Name = "TelephoneTB";
            TelephoneTB.Size = new Size(462, 34);
            TelephoneTB.TabIndex = 4;
            TelephoneTB.TextChanged += TelephoneTB_TextChanged;
            // 
            // Key_Picture
            // 
            Key_Picture.Image = Properties.Resources.Pngkey_Transparent;
            Key_Picture.Location = new Point(44, 27);
            Key_Picture.Name = "Key_Picture";
            Key_Picture.Size = new Size(84, 71);
            Key_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Key_Picture.TabIndex = 8;
            Key_Picture.TabStop = false;
            // 
            // HeadingLabel
            // 
            HeadingLabel.AutoSize = true;
            HeadingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HeadingLabel.ForeColor = SystemColors.ButtonHighlight;
            HeadingLabel.Location = new Point(179, 49);
            HeadingLabel.Name = "HeadingLabel";
            HeadingLabel.Size = new Size(94, 21);
            HeadingLabel.TabIndex = 10;
            HeadingLabel.Text = "Registration";
            // 
            // ShowPassword_CheckBox
            // 
            ShowPassword_CheckBox.AutoSize = true;
            ShowPassword_CheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShowPassword_CheckBox.ForeColor = Color.White;
            ShowPassword_CheckBox.Location = new Point(178, 287);
            ShowPassword_CheckBox.Margin = new Padding(1);
            ShowPassword_CheckBox.Name = "ShowPassword_CheckBox";
            ShowPassword_CheckBox.Size = new Size(134, 25);
            ShowPassword_CheckBox.TabIndex = 5;
            ShowPassword_CheckBox.Text = "ShowPassword";
            ShowPassword_CheckBox.UseVisualStyleBackColor = true;
            ShowPassword_CheckBox.CheckedChanged += ShowPassword_CheckBox_CheckedChanged;
            // 
            // Register_BT
            // 
            Register_BT.BackColor = SystemColors.GrayText;
            Register_BT.FlatStyle = FlatStyle.System;
            Register_BT.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Register_BT.ForeColor = SystemColors.ButtonHighlight;
            Register_BT.Location = new Point(178, 313);
            Register_BT.Margin = new Padding(1);
            Register_BT.Name = "Register_BT";
            Register_BT.Size = new Size(230, 30);
            Register_BT.TabIndex = 6;
            Register_BT.Text = "REGISTER";
            Register_BT.TextAlign = ContentAlignment.MiddleLeft;
            Register_BT.UseVisualStyleBackColor = false;
            Register_BT.Click += REGISTER_Click;
            // 
            // PasswordLabel_Text
            // 
            PasswordLabel_Text.AutoSize = true;
            PasswordLabel_Text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel_Text.ForeColor = SystemColors.ButtonHighlight;
            PasswordLabel_Text.Location = new Point(32, 204);
            PasswordLabel_Text.Margin = new Padding(1, 0, 1, 0);
            PasswordLabel_Text.Name = "PasswordLabel_Text";
            PasswordLabel_Text.Size = new Size(76, 21);
            PasswordLabel_Text.TabIndex = 4;
            PasswordLabel_Text.Text = "Password";
            // 
            // AccountLabel_Text
            // 
            AccountLabel_Text.AutoSize = true;
            AccountLabel_Text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AccountLabel_Text.ForeColor = SystemColors.ButtonHighlight;
            AccountLabel_Text.Location = new Point(31, 110);
            AccountLabel_Text.Margin = new Padding(1, 0, 1, 0);
            AccountLabel_Text.Name = "AccountLabel_Text";
            AccountLabel_Text.Size = new Size(112, 21);
            AccountLabel_Text.TabIndex = 3;
            AccountLabel_Text.Text = "Account Name";
            // 
            // PasswordTB
            // 
            PasswordTB.BackColor = SystemColors.GrayText;
            PasswordTB.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTB.ForeColor = SystemColors.ButtonHighlight;
            PasswordTB.Location = new Point(178, 195);
            PasswordTB.Margin = new Padding(1);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(462, 34);
            PasswordTB.TabIndex = 3;
            PasswordTB.UseSystemPasswordChar = true;
            // 
            // UsernameTB
            // 
            UsernameTB.BackColor = SystemColors.GrayText;
            UsernameTB.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTB.ForeColor = SystemColors.ButtonHighlight;
            UsernameTB.Location = new Point(179, 101);
            UsernameTB.Margin = new Padding(1);
            UsernameTB.Name = "UsernameTB";
            UsernameTB.Size = new Size(462, 34);
            UsernameTB.TabIndex = 1;
            // 
            // MinimizedLabel_TB
            // 
            MinimizedLabel_TB.AutoSize = true;
            MinimizedLabel_TB.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            MinimizedLabel_TB.ForeColor = Color.White;
            MinimizedLabel_TB.Location = new Point(680, -5);
            MinimizedLabel_TB.Margin = new Padding(1, 0, 1, 0);
            MinimizedLabel_TB.Name = "MinimizedLabel_TB";
            MinimizedLabel_TB.Size = new Size(22, 30);
            MinimizedLabel_TB.TabIndex = 8;
            MinimizedLabel_TB.Text = "_";
            MinimizedLabel_TB.Click += MinimizedLabel_TB_Click;
            // 
            // ExitLabel_TB
            // 
            ExitLabel_TB.AutoSize = true;
            ExitLabel_TB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ExitLabel_TB.ForeColor = Color.White;
            ExitLabel_TB.Location = new Point(704, 7);
            ExitLabel_TB.Margin = new Padding(1, 0, 1, 0);
            ExitLabel_TB.Name = "ExitLabel_TB";
            ExitLabel_TB.Size = new Size(21, 25);
            ExitLabel_TB.TabIndex = 9;
            ExitLabel_TB.Text = "x";
            ExitLabel_TB.Click += ExitLabel_TB_Click;
            // 
            // HeadingForm_Text
            // 
            HeadingForm_Text.AutoSize = true;
            HeadingForm_Text.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            HeadingForm_Text.ForeColor = SystemColors.ButtonHighlight;
            HeadingForm_Text.Location = new Point(10, 7);
            HeadingForm_Text.Name = "HeadingForm_Text";
            HeadingForm_Text.Size = new Size(226, 15);
            HeadingForm_Text.TabIndex = 11;
            HeadingForm_Text.Text = "Inventory Managment System Register";
            // 
            // RegisterForm
            // 
            AcceptButton = Register_BT;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(732, 404);
            Controls.Add(MinimizedLabel_TB);
            Controls.Add(HeadingForm_Text);
            Controls.Add(ExitLabel_TB);
            Controls.Add(panel_Register);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel_Register.ResumeLayout(false);
            panel_Register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Key_Picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_Register;
        private Label HeadingLabel;
        private TextBox PasswordTB;
        private TextBox UsernameTB;
        private Label PasswordLabel_Text;
        private Label AccountLabel_Text;
        private CheckBox ShowPassword_CheckBox;
        private Button Register_BT;
        private PictureBox Key_Picture;
        private Label ExitLabel_TB;
        private Button clear_BT;
        private Label HeadingForm_Text;
        private Label MinimizedLabel_TB;
        private Label PhoneLabel_Text;
        private Label FullNameLabel_Text;
        private TextBox FullNameTB;
        private TextBox TelephoneTB;
        private Button BackToLogin_BT;
    }
}