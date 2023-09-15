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
            this.panel_Login = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.LOGIN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.CreateNewAccount_BT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Login
            // 
            this.panel_Login.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel_Login.Controls.Add(this.btn_clear);
            this.panel_Login.Controls.Add(this.pictureBox1);
            this.panel_Login.Controls.Add(this.label2);
            this.panel_Login.Controls.Add(this.checkBox1);
            this.panel_Login.Controls.Add(this.LOGIN);
            this.panel_Login.Controls.Add(this.label4);
            this.panel_Login.Controls.Add(this.label3);
            this.panel_Login.Controls.Add(this.PasswordTB);
            this.panel_Login.Controls.Add(this.UsernameTB);
            this.panel_Login.Location = new System.Drawing.Point(24, 27);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(679, 263);
            this.panel_Login.TabIndex = 0;
            this.panel_Login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Login_Paint);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_clear.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clear.Location = new System.Drawing.Point(412, 224);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(229, 30);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventory.Properties.Resources.Pngkey_Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(72, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(179, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inventory Managment system";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(179, 196);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 25);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "ShowPassword";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LOGIN
            // 
            this.LOGIN.BackColor = System.Drawing.SystemColors.GrayText;
            this.LOGIN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LOGIN.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LOGIN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LOGIN.Location = new System.Drawing.Point(179, 224);
            this.LOGIN.Margin = new System.Windows.Forms.Padding(2);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(229, 30);
            this.LOGIN.TabIndex = 5;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LOGIN.UseVisualStyleBackColor = false;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(74, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(32, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Account Name";
            // 
            // PasswordTB
            // 
            this.PasswordTB.BackColor = System.Drawing.SystemColors.GrayText;
            this.PasswordTB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordTB.Location = new System.Drawing.Point(179, 153);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(462, 34);
            this.PasswordTB.TabIndex = 2;
            this.PasswordTB.Text = "Type Password";
            this.PasswordTB.UseSystemPasswordChar = true;
            // 
            // UsernameTB
            // 
            this.UsernameTB.BackColor = System.Drawing.SystemColors.GrayText;
            this.UsernameTB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameTB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameTB.Location = new System.Drawing.Point(179, 110);
            this.UsernameTB.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(462, 34);
            this.UsernameTB.TabIndex = 1;
            this.UsernameTB.Text = "Type Username";
            // 
            // CreateNewAccount_BT
            // 
            this.CreateNewAccount_BT.BackColor = System.Drawing.SystemColors.GrayText;
            this.CreateNewAccount_BT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CreateNewAccount_BT.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateNewAccount_BT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateNewAccount_BT.Location = new System.Drawing.Point(235, 31);
            this.CreateNewAccount_BT.Margin = new System.Windows.Forms.Padding(2);
            this.CreateNewAccount_BT.Name = "CreateNewAccount_BT";
            this.CreateNewAccount_BT.Size = new System.Drawing.Size(404, 30);
            this.CreateNewAccount_BT.TabIndex = 10;
            this.CreateNewAccount_BT.Text = "CREATE NEW ACCOUNT...";
            this.CreateNewAccount_BT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateNewAccount_BT.UseVisualStyleBackColor = false;
            this.CreateNewAccount_BT.Click += new System.EventHandler(this.CreateNewAccount_BT_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(697, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inventory Managment System Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(668, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "_";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CreateNewAccount_BT);
            this.panel1.Location = new System.Drawing.Point(24, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 90);
            this.panel1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(72, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dont Have Account";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LOGIN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(732, 403);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel_Login);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_Login;
        private Label label2;
        private TextBox PasswordTB;
        private TextBox UsernameTB;
        private Label label4;
        private Label label3;
        private CheckBox checkBox1;
        private Button LOGIN;
        private PictureBox pictureBox1;
        private Label label6;
        private Button btn_clear;
        private Label label1;
        private Label label5;
        private Button CreateNewAccount_BT;
        private Panel panel1;
        private Label label7;
    }
}