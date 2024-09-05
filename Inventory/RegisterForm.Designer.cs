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
            HeadingForm_Text = new Label();
            MinizedApp_Label = new Label();
            ExitApp_Label = new Label();
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
            panel_Register.Location = new Point(26, 48);
            panel_Register.Margin = new Padding(3, 4, 3, 4);
            panel_Register.Name = "panel_Register";
            panel_Register.Size = new Size(776, 475);
            panel_Register.TabIndex = 0;
            // 
            // BackToLogin_BT
            // 
            BackToLogin_BT.BackColor = SystemColors.GrayText;
            BackToLogin_BT.BackgroundImageLayout = ImageLayout.None;
            BackToLogin_BT.FlatStyle = FlatStyle.System;
            BackToLogin_BT.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BackToLogin_BT.ForeColor = SystemColors.ButtonHighlight;
            BackToLogin_BT.Location = new Point(35, 417);
            BackToLogin_BT.Margin = new Padding(1);
            BackToLogin_BT.Name = "BackToLogin_BT";
            BackToLogin_BT.Size = new Size(77, 40);
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
            PhoneLabel_Text.Location = new Point(37, 341);
            PhoneLabel_Text.Margin = new Padding(1, 0, 1, 0);
            PhoneLabel_Text.Name = "PhoneLabel_Text";
            PhoneLabel_Text.Size = new Size(101, 28);
            PhoneLabel_Text.TabIndex = 13;
            PhoneLabel_Text.Text = "Telephone";
            // 
            // FullNameLabel_Text
            // 
            FullNameLabel_Text.AutoSize = true;
            FullNameLabel_Text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FullNameLabel_Text.ForeColor = SystemColors.ButtonHighlight;
            FullNameLabel_Text.Location = new Point(35, 209);
            FullNameLabel_Text.Margin = new Padding(1, 0, 1, 0);
            FullNameLabel_Text.Name = "FullNameLabel_Text";
            FullNameLabel_Text.Size = new Size(95, 28);
            FullNameLabel_Text.TabIndex = 12;
            FullNameLabel_Text.Text = "FullName";
            // 
            // FullNameTB
            // 
            FullNameTB.BackColor = SystemColors.GrayText;
            FullNameTB.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            FullNameTB.ForeColor = SystemColors.ButtonHighlight;
            FullNameTB.Location = new Point(205, 197);
            FullNameTB.Margin = new Padding(1);
            FullNameTB.Name = "FullNameTB";
            FullNameTB.Size = new Size(527, 41);
            FullNameTB.TabIndex = 2;
            // 
            // clear_BT
            // 
            clear_BT.BackColor = SystemColors.GrayText;
            clear_BT.FlatStyle = FlatStyle.System;
            clear_BT.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clear_BT.ForeColor = SystemColors.ButtonHighlight;
            clear_BT.Location = new Point(470, 417);
            clear_BT.Margin = new Padding(1);
            clear_BT.Name = "clear_BT";
            clear_BT.Size = new Size(263, 40);
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
            TelephoneTB.Location = new Point(203, 324);
            TelephoneTB.Margin = new Padding(1);
            TelephoneTB.Name = "TelephoneTB";
            TelephoneTB.Size = new Size(527, 41);
            TelephoneTB.TabIndex = 4;
            TelephoneTB.TextChanged += TelephoneTB_TextChanged;
            // 
            // Key_Picture
            // 
            Key_Picture.Image = Properties.Resources.Pngkey_Transparent;
            Key_Picture.Location = new Point(50, 36);
            Key_Picture.Margin = new Padding(3, 4, 3, 4);
            Key_Picture.Name = "Key_Picture";
            Key_Picture.Size = new Size(96, 95);
            Key_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Key_Picture.TabIndex = 8;
            Key_Picture.TabStop = false;
            // 
            // HeadingLabel
            // 
            HeadingLabel.AutoSize = true;
            HeadingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HeadingLabel.ForeColor = SystemColors.ButtonHighlight;
            HeadingLabel.Location = new Point(205, 65);
            HeadingLabel.Name = "HeadingLabel";
            HeadingLabel.Size = new Size(117, 28);
            HeadingLabel.TabIndex = 10;
            HeadingLabel.Text = "Registration";
            // 
            // ShowPassword_CheckBox
            // 
            ShowPassword_CheckBox.AutoSize = true;
            ShowPassword_CheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShowPassword_CheckBox.ForeColor = Color.White;
            ShowPassword_CheckBox.Location = new Point(203, 383);
            ShowPassword_CheckBox.Margin = new Padding(1);
            ShowPassword_CheckBox.Name = "ShowPassword_CheckBox";
            ShowPassword_CheckBox.Size = new Size(163, 32);
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
            Register_BT.Location = new Point(203, 417);
            Register_BT.Margin = new Padding(1);
            Register_BT.Name = "Register_BT";
            Register_BT.Size = new Size(263, 40);
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
            PasswordLabel_Text.Location = new Point(37, 272);
            PasswordLabel_Text.Margin = new Padding(1, 0, 1, 0);
            PasswordLabel_Text.Name = "PasswordLabel_Text";
            PasswordLabel_Text.Size = new Size(93, 28);
            PasswordLabel_Text.TabIndex = 4;
            PasswordLabel_Text.Text = "Password";
            // 
            // AccountLabel_Text
            // 
            AccountLabel_Text.AutoSize = true;
            AccountLabel_Text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AccountLabel_Text.ForeColor = SystemColors.ButtonHighlight;
            AccountLabel_Text.Location = new Point(35, 147);
            AccountLabel_Text.Margin = new Padding(1, 0, 1, 0);
            AccountLabel_Text.Name = "AccountLabel_Text";
            AccountLabel_Text.Size = new Size(141, 28);
            AccountLabel_Text.TabIndex = 3;
            AccountLabel_Text.Text = "Account Name";
            // 
            // PasswordTB
            // 
            PasswordTB.BackColor = SystemColors.GrayText;
            PasswordTB.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTB.ForeColor = SystemColors.ButtonHighlight;
            PasswordTB.Location = new Point(203, 260);
            PasswordTB.Margin = new Padding(1);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(527, 41);
            PasswordTB.TabIndex = 3;
            PasswordTB.UseSystemPasswordChar = true;
            // 
            // UsernameTB
            // 
            UsernameTB.BackColor = SystemColors.GrayText;
            UsernameTB.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTB.ForeColor = SystemColors.ButtonHighlight;
            UsernameTB.Location = new Point(205, 135);
            UsernameTB.Margin = new Padding(1);
            UsernameTB.MaxLength = 10;
            UsernameTB.Name = "UsernameTB";
            UsernameTB.Size = new Size(527, 41);
            UsernameTB.TabIndex = 1;
            // 
            // HeadingForm_Text
            // 
            HeadingForm_Text.AutoSize = true;
            HeadingForm_Text.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            HeadingForm_Text.ForeColor = SystemColors.ButtonHighlight;
            HeadingForm_Text.Location = new Point(11, 9);
            HeadingForm_Text.Name = "HeadingForm_Text";
            HeadingForm_Text.Size = new Size(284, 20);
            HeadingForm_Text.TabIndex = 11;
            HeadingForm_Text.Text = "Inventory Managment System Register";
            // 
            // MinizedApp_Label
            // 
            MinizedApp_Label.AutoSize = true;
            MinizedApp_Label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            MinizedApp_Label.ForeColor = Color.White;
            MinizedApp_Label.Location = new Point(764, 3);
            MinizedApp_Label.Margin = new Padding(2, 0, 2, 0);
            MinizedApp_Label.Name = "MinizedApp_Label";
            MinizedApp_Label.Size = new Size(29, 38);
            MinizedApp_Label.TabIndex = 16;
            MinizedApp_Label.Text = "_";
            MinizedApp_Label.Click += MinizedApp_Label_Click;
            // 
            // ExitApp_Label
            // 
            ExitApp_Label.AutoSize = true;
            ExitApp_Label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ExitApp_Label.ForeColor = Color.White;
            ExitApp_Label.Location = new Point(798, 12);
            ExitApp_Label.Margin = new Padding(2, 0, 2, 0);
            ExitApp_Label.Name = "ExitApp_Label";
            ExitApp_Label.Size = new Size(28, 32);
            ExitApp_Label.TabIndex = 15;
            ExitApp_Label.Text = "X";
            ExitApp_Label.Click += ExitApp_Label_Click;
            // 
            // RegisterForm
            // 
            AcceptButton = Register_BT;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(837, 539);
            Controls.Add(MinizedApp_Label);
            Controls.Add(ExitApp_Label);
            Controls.Add(HeadingForm_Text);
            Controls.Add(panel_Register);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private Button clear_BT;
        private Label HeadingForm_Text;
        private Label PhoneLabel_Text;
        private Label FullNameLabel_Text;
        private TextBox FullNameTB;
        private TextBox TelephoneTB;
        private Button BackToLogin_BT;
        private Label MinizedApp_Label;
        private Label ExitApp_Label;
    }
}