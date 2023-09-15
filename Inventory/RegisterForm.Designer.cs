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
            BackToRegister = new Button();
            label8 = new Label();
            label7 = new Label();
            FullNameTB = new TextBox();
            btn_clear = new Button();
            TelephoneTB = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            checkBox1 = new CheckBox();
            REGISTER = new Button();
            label4 = new Label();
            label3 = new Label();
            PasswordTB = new TextBox();
            UsernameTB = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            panel_Register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_Register
            // 
            panel_Register.BackColor = SystemColors.GrayText;
            panel_Register.Controls.Add(BackToRegister);
            panel_Register.Controls.Add(label8);
            panel_Register.Controls.Add(label7);
            panel_Register.Controls.Add(FullNameTB);
            panel_Register.Controls.Add(btn_clear);
            panel_Register.Controls.Add(TelephoneTB);
            panel_Register.Controls.Add(pictureBox1);
            panel_Register.Controls.Add(label2);
            panel_Register.Controls.Add(checkBox1);
            panel_Register.Controls.Add(REGISTER);
            panel_Register.Controls.Add(label4);
            panel_Register.Controls.Add(label3);
            panel_Register.Controls.Add(PasswordTB);
            panel_Register.Controls.Add(UsernameTB);
            panel_Register.Location = new Point(26, 48);
            panel_Register.Margin = new Padding(3, 4, 3, 4);
            panel_Register.Name = "panel_Register";
            panel_Register.Size = new Size(776, 475);
            panel_Register.TabIndex = 0;
            // 
            // BackToRegister
            // 
            BackToRegister.BackColor = SystemColors.GrayText;
            BackToRegister.BackgroundImageLayout = ImageLayout.None;
            BackToRegister.FlatStyle = FlatStyle.System;
            BackToRegister.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BackToRegister.ForeColor = SystemColors.ButtonHighlight;
            BackToRegister.Location = new Point(35, 417);
            BackToRegister.Margin = new Padding(1);
            BackToRegister.Name = "BackToRegister";
            BackToRegister.Size = new Size(77, 40);
            BackToRegister.TabIndex = 14;
            BackToRegister.Text = "BACK";
            BackToRegister.UseVisualStyleBackColor = false;
            BackToRegister.Click += BackToRegister_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(37, 341);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(101, 28);
            label8.TabIndex = 13;
            label8.Text = "Telephone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(35, 209);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(95, 28);
            label7.TabIndex = 12;
            label7.Text = "FullName";
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
            // btn_clear
            // 
            btn_clear.BackColor = SystemColors.GrayText;
            btn_clear.FlatStyle = FlatStyle.System;
            btn_clear.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clear.ForeColor = SystemColors.ButtonHighlight;
            btn_clear.Location = new Point(470, 417);
            btn_clear.Margin = new Padding(1);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(263, 40);
            btn_clear.TabIndex = 7;
            btn_clear.Text = "CLEAR";
            btn_clear.TextAlign = ContentAlignment.MiddleLeft;
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pngkey_Transparent;
            pictureBox1.Location = new Point(81, 36);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(205, 65);
            label2.Name = "label2";
            label2.Size = new Size(271, 28);
            label2.TabIndex = 10;
            label2.Text = "Inventory Managment system";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(203, 383);
            checkBox1.Margin = new Padding(1);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(163, 32);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "ShowPassword";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // REGISTER
            // 
            REGISTER.BackColor = SystemColors.GrayText;
            REGISTER.FlatStyle = FlatStyle.System;
            REGISTER.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            REGISTER.ForeColor = SystemColors.ButtonHighlight;
            REGISTER.Location = new Point(203, 417);
            REGISTER.Margin = new Padding(1);
            REGISTER.Name = "REGISTER";
            REGISTER.Size = new Size(263, 40);
            REGISTER.TabIndex = 6;
            REGISTER.Text = "REGISTER";
            REGISTER.TextAlign = ContentAlignment.MiddleLeft;
            REGISTER.UseVisualStyleBackColor = false;
            REGISTER.Click += REGISTER_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(37, 272);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(35, 147);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(141, 28);
            label3.TabIndex = 3;
            label3.Text = "Account Name";
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
            UsernameTB.Name = "UsernameTB";
            UsernameTB.Size = new Size(527, 41);
            UsernameTB.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(777, -7);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(28, 37);
            label5.TabIndex = 8;
            label5.Text = "_";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(805, 9);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(25, 32);
            label6.TabIndex = 9;
            label6.Text = "x";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(284, 20);
            label1.TabIndex = 11;
            label1.Text = "Inventory Managment System Register";
            // 
            // RegisterForm
            // 
            AcceptButton = REGISTER;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(837, 539);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(panel_Register);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel_Register.ResumeLayout(false);
            panel_Register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_Register;
        private Label label2;
        private TextBox PasswordTB;
        private TextBox UsernameTB;
        private Label label4;
        private Label label3;
        private CheckBox checkBox1;
        private Button REGISTER;
        private PictureBox pictureBox1;
        private Label label6;
        private Button btn_clear;
        private Label label1;
        private Label label5;
        private Label label8;
        private Label label7;
        private TextBox FullNameTB;
        private TextBox TelephoneTB;
        private Button BackToRegister;
    }
}