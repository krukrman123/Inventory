namespace Inventory
{
    partial class ManageProductsAdd
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
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label11 = new Label();
            label13 = new Label();
            btn_clear = new Button();
            FileNameTB = new TextBox();
            label12 = new Label();
            CatCombo = new ComboBox();
            label9 = new Label();
            descriptionTB = new TextBox();
            label8 = new Label();
            productPriceTB = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            productQTYTB = new TextBox();
            productNameTB = new TextBox();
            productIDTB = new TextBox();
            btn_Add = new Button();
            textProductTb = new TextBox();
            PictureBox = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1611, 120);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(680, 68);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(250, 32);
            label2.TabIndex = 1;
            label2.Text = "Manage Products Add";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(495, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(618, 50);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.MenuHighlight;
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label13);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 1086);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1611, 51);
            panel3.TabIndex = 69;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Lucida Console", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.HighlightText;
            label11.Location = new Point(1482, 19);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(118, 17);
            label11.TabIndex = 2;
            label11.Text = "Version 1.0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Lucida Console", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.HighlightText;
            label13.Location = new Point(662, 13);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(318, 24);
            label13.TabIndex = 1;
            label13.Text = "Devolop By Adam Dobias";
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(192, 0, 0);
            btn_clear.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clear.ForeColor = SystemColors.ControlLightLight;
            btn_clear.Location = new Point(399, 727);
            btn_clear.Margin = new Padding(2, 3, 2, 3);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(123, 39);
            btn_clear.TabIndex = 9;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            // 
            // FileNameTB
            // 
            FileNameTB.BackColor = SystemColors.GrayText;
            FileNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FileNameTB.ForeColor = SystemColors.ButtonHighlight;
            FileNameTB.Location = new Point(182, 661);
            FileNameTB.Margin = new Padding(2, 3, 2, 3);
            FileNameTB.Name = "FileNameTB";
            FileNameTB.Size = new Size(340, 34);
            FileNameTB.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(23, 579);
            label12.Name = "label12";
            label12.Size = new Size(92, 28);
            label12.TabIndex = 88;
            label12.Text = "Category";
            // 
            // CatCombo
            // 
            CatCombo.BackColor = SystemColors.GrayText;
            CatCombo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CatCombo.ForeColor = SystemColors.ButtonHighlight;
            CatCombo.FormattingEnabled = true;
            CatCombo.Location = new Point(182, 579);
            CatCombo.Margin = new Padding(3, 4, 3, 4);
            CatCombo.Name = "CatCombo";
            CatCombo.Size = new Size(340, 36);
            CatCombo.TabIndex = 6;
            CatCombo.Text = "Product Category";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(19, 511);
            label9.Name = "label9";
            label9.Size = new Size(112, 28);
            label9.TabIndex = 87;
            label9.Text = "Description";
            // 
            // descriptionTB
            // 
            descriptionTB.BackColor = SystemColors.GrayText;
            descriptionTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionTB.ForeColor = SystemColors.ButtonHighlight;
            descriptionTB.Location = new Point(182, 507);
            descriptionTB.Margin = new Padding(2, 3, 2, 3);
            descriptionTB.Name = "descriptionTB";
            descriptionTB.Size = new Size(340, 34);
            descriptionTB.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(19, 437);
            label8.Name = "label8";
            label8.Size = new Size(128, 28);
            label8.TabIndex = 86;
            label8.Text = "Product Price";
            // 
            // productPriceTB
            // 
            productPriceTB.BackColor = SystemColors.GrayText;
            productPriceTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productPriceTB.ForeColor = SystemColors.ButtonHighlight;
            productPriceTB.Location = new Point(182, 433);
            productPriceTB.Margin = new Padding(2, 3, 2, 3);
            productPriceTB.Name = "productPriceTB";
            productPriceTB.Size = new Size(340, 34);
            productPriceTB.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(18, 369);
            label7.Name = "label7";
            label7.Size = new Size(113, 28);
            label7.TabIndex = 85;
            label7.Text = "ProductQty";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(19, 303);
            label6.Name = "label6";
            label6.Size = new Size(138, 28);
            label6.TabIndex = 83;
            label6.Text = "Product Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(19, 227);
            label5.Name = "label5";
            label5.Size = new Size(105, 28);
            label5.TabIndex = 81;
            label5.Text = "Product ID";
            // 
            // productQTYTB
            // 
            productQTYTB.BackColor = SystemColors.GrayText;
            productQTYTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productQTYTB.ForeColor = SystemColors.ButtonHighlight;
            productQTYTB.Location = new Point(182, 367);
            productQTYTB.Margin = new Padding(2, 3, 2, 3);
            productQTYTB.Name = "productQTYTB";
            productQTYTB.Size = new Size(340, 34);
            productQTYTB.TabIndex = 3;
            // 
            // productNameTB
            // 
            productNameTB.BackColor = SystemColors.GrayText;
            productNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productNameTB.ForeColor = SystemColors.ButtonHighlight;
            productNameTB.Location = new Point(182, 299);
            productNameTB.Margin = new Padding(2, 3, 2, 3);
            productNameTB.Name = "productNameTB";
            productNameTB.Size = new Size(340, 34);
            productNameTB.TabIndex = 2;
            // 
            // productIDTB
            // 
            productIDTB.BackColor = SystemColors.GrayText;
            productIDTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productIDTB.ForeColor = SystemColors.Control;
            productIDTB.Location = new Point(182, 224);
            productIDTB.Margin = new Padding(2, 3, 2, 3);
            productIDTB.Name = "productIDTB";
            productIDTB.ReadOnly = true;
            productIDTB.Size = new Size(340, 34);
            productIDTB.TabIndex = 11;
            productIDTB.KeyPress += productIDTB_KeyPress;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(192, 0, 0);
            btn_Add.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Add.ForeColor = SystemColors.ControlLightLight;
            btn_Add.Location = new Point(38, 987);
            btn_Add.Margin = new Padding(2, 3, 2, 3);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(499, 79);
            btn_Add.TabIndex = 10;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // textProductTb
            // 
            textProductTb.BackColor = SystemColors.GrayText;
            textProductTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textProductTb.ForeColor = SystemColors.ButtonHighlight;
            textProductTb.Location = new Point(593, 767);
            textProductTb.Margin = new Padding(2, 3, 2, 3);
            textProductTb.Multiline = true;
            textProductTb.Name = "textProductTb";
            textProductTb.Size = new Size(990, 297);
            textProductTb.TabIndex = 8;
            // 
            // PictureBox
            // 
            PictureBox.BorderStyle = BorderStyle.Fixed3D;
            PictureBox.Image = Properties.Resources.user;
            PictureBox.Location = new Point(593, 164);
            PictureBox.Margin = new Padding(3, 4, 3, 4);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(990, 553);
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 92;
            PictureBox.TabStop = false;
            PictureBox.Click += PictureBox_Click;
            // 
            // ManageProductsAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1611, 1137);
            Controls.Add(textProductTb);
            Controls.Add(PictureBox);
            Controls.Add(btn_Add);
            Controls.Add(btn_clear);
            Controls.Add(FileNameTB);
            Controls.Add(label12);
            Controls.Add(CatCombo);
            Controls.Add(label9);
            Controls.Add(descriptionTB);
            Controls.Add(label8);
            Controls.Add(productPriceTB);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(productQTYTB);
            Controls.Add(productNameTB);
            Controls.Add(productIDTB);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1629, 1184);
            Name = "ManageProductsAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageProductsAdd";
            Load += ManageProductsAdd_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Label label11;
        private Label label13;
        public Button btn_clear;
        private TextBox FileNameTB;
        private Label label12;
        private ComboBox CatCombo;
        private Label label9;
        private TextBox descriptionTB;
        private Label label8;
        private TextBox productPriceTB;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox productQTYTB;
        private TextBox productNameTB;
        private TextBox productIDTB;
        public Button btn_Add;
        private TextBox textProductTb;
        private PictureBox PictureBox;
    }
}