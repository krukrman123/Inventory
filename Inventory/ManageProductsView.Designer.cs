namespace Inventory
{
    partial class ManageProductsView
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
            label6 = new Label();
            label7 = new Label();
            FileNameTB = new TextBox();
            CatCombo = new ComboBox();
            descriptionTB = new TextBox();
            productPriceTB = new TextBox();
            productQTYTB = new TextBox();
            productNameTB = new TextBox();
            productIDTB = new TextBox();
            label12 = new Label();
            label9 = new Label();
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textProductTb = new TextBox();
            PictureBox = new PictureBox();
            panel3 = new Panel();
            label11 = new Label();
            label13 = new Label();
            btn_clear = new Button();
            btn_delete = new Button();
            btn_edit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1611, 120);
            panel1.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(662, 70);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(258, 32);
            label6.TabIndex = 1;
            label6.Text = "Manage Products View";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(502, 9);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(618, 50);
            label7.TabIndex = 0;
            label7.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // FileNameTB
            // 
            FileNameTB.BackColor = SystemColors.GrayText;
            FileNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FileNameTB.ForeColor = SystemColors.ButtonHighlight;
            FileNameTB.Location = new Point(157, 577);
            FileNameTB.Margin = new Padding(2, 3, 2, 3);
            FileNameTB.Name = "FileNameTB";
            FileNameTB.Size = new Size(341, 34);
            FileNameTB.TabIndex = 59;
            // 
            // CatCombo
            // 
            CatCombo.BackColor = SystemColors.GrayText;
            CatCombo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CatCombo.ForeColor = SystemColors.ButtonHighlight;
            CatCombo.FormattingEnabled = true;
            CatCombo.Location = new Point(157, 515);
            CatCombo.Margin = new Padding(3, 4, 3, 4);
            CatCombo.Name = "CatCombo";
            CatCombo.Size = new Size(341, 36);
            CatCombo.TabIndex = 58;
            CatCombo.Text = "Product Category";
            // 
            // descriptionTB
            // 
            descriptionTB.BackColor = SystemColors.GrayText;
            descriptionTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionTB.ForeColor = SystemColors.ButtonHighlight;
            descriptionTB.Location = new Point(157, 443);
            descriptionTB.Margin = new Padding(2, 3, 2, 3);
            descriptionTB.Name = "descriptionTB";
            descriptionTB.Size = new Size(341, 34);
            descriptionTB.TabIndex = 57;
            // 
            // productPriceTB
            // 
            productPriceTB.BackColor = SystemColors.GrayText;
            productPriceTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productPriceTB.ForeColor = SystemColors.ButtonHighlight;
            productPriceTB.Location = new Point(157, 369);
            productPriceTB.Margin = new Padding(2, 3, 2, 3);
            productPriceTB.Name = "productPriceTB";
            productPriceTB.Size = new Size(341, 34);
            productPriceTB.TabIndex = 56;
            // 
            // productQTYTB
            // 
            productQTYTB.BackColor = SystemColors.GrayText;
            productQTYTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productQTYTB.ForeColor = SystemColors.ButtonHighlight;
            productQTYTB.Location = new Point(157, 303);
            productQTYTB.Margin = new Padding(2, 3, 2, 3);
            productQTYTB.Name = "productQTYTB";
            productQTYTB.Size = new Size(341, 34);
            productQTYTB.TabIndex = 55;
            // 
            // productNameTB
            // 
            productNameTB.BackColor = SystemColors.GrayText;
            productNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productNameTB.ForeColor = SystemColors.ButtonHighlight;
            productNameTB.Location = new Point(157, 235);
            productNameTB.Margin = new Padding(2, 3, 2, 3);
            productNameTB.Name = "productNameTB";
            productNameTB.Size = new Size(341, 34);
            productNameTB.TabIndex = 54;
            // 
            // productIDTB
            // 
            productIDTB.BackColor = SystemColors.GrayText;
            productIDTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productIDTB.ForeColor = SystemColors.ControlDark;
            productIDTB.Location = new Point(157, 160);
            productIDTB.Margin = new Padding(2, 3, 2, 3);
            productIDTB.Name = "productIDTB";
            productIDTB.ReadOnly = true;
            productIDTB.Size = new Size(341, 34);
            productIDTB.TabIndex = 53;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(24, 515);
            label12.Name = "label12";
            label12.Size = new Size(92, 28);
            label12.TabIndex = 65;
            label12.Text = "Category";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(21, 447);
            label9.Name = "label9";
            label9.Size = new Size(112, 28);
            label9.TabIndex = 64;
            label9.Text = "Description";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(21, 373);
            label8.Name = "label8";
            label8.Size = new Size(128, 28);
            label8.TabIndex = 63;
            label8.Text = "Product Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(19, 305);
            label1.Name = "label1";
            label1.Size = new Size(113, 28);
            label1.TabIndex = 62;
            label1.Text = "ProductQty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(21, 239);
            label2.Name = "label2";
            label2.Size = new Size(138, 28);
            label2.TabIndex = 61;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(21, 163);
            label3.Name = "label3";
            label3.Size = new Size(105, 28);
            label3.TabIndex = 60;
            label3.Text = "Product ID";
            // 
            // textProductTb
            // 
            textProductTb.BackColor = SystemColors.GrayText;
            textProductTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textProductTb.ForeColor = SystemColors.ButtonHighlight;
            textProductTb.Location = new Point(696, 704);
            textProductTb.Margin = new Padding(2, 3, 2, 3);
            textProductTb.Multiline = true;
            textProductTb.Name = "textProductTb";
            textProductTb.Size = new Size(911, 260);
            textProductTb.TabIndex = 67;
            // 
            // PictureBox
            // 
            PictureBox.BorderStyle = BorderStyle.Fixed3D;
            PictureBox.Image = Properties.Resources.user;
            PictureBox.Location = new Point(696, 143);
            PictureBox.Margin = new Padding(3, 4, 3, 4);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(903, 553);
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 66;
            PictureBox.TabStop = false;
            PictureBox.Click += PictureBox_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.MenuHighlight;
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label13);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 972);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1611, 51);
            panel3.TabIndex = 68;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Lucida Console", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.HighlightText;
            label11.Location = new Point(1489, 20);
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
            btn_clear.Location = new Point(379, 659);
            btn_clear.Margin = new Padding(2, 3, 2, 3);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(119, 39);
            btn_clear.TabIndex = 72;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(192, 0, 0);
            btn_delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = SystemColors.ControlLightLight;
            btn_delete.Location = new Point(307, 880);
            btn_delete.Margin = new Padding(2, 3, 2, 3);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(191, 65);
            btn_delete.TabIndex = 70;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(192, 0, 0);
            btn_edit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edit.ForeColor = SystemColors.ControlLightLight;
            btn_edit.Location = new Point(27, 880);
            btn_edit.Margin = new Padding(2, 3, 2, 3);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(191, 65);
            btn_edit.TabIndex = 69;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // ManageProductsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1611, 1023);
            Controls.Add(btn_clear);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(panel3);
            Controls.Add(textProductTb);
            Controls.Add(PictureBox);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(FileNameTB);
            Controls.Add(CatCombo);
            Controls.Add(descriptionTB);
            Controls.Add(productPriceTB);
            Controls.Add(productQTYTB);
            Controls.Add(productNameTB);
            Controls.Add(productIDTB);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1629, 1070);
            Name = "ManageProductsView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageProductsView";
            Load += ManageProductsView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label7;
        private Label label12;
        private Label label9;
        private Label label8;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private Label label11;
        private Label label13;
        public TextBox productIDTB;
        public TextBox FileNameTB;
        public ComboBox CatCombo;
        public TextBox descriptionTB;
        public TextBox productPriceTB;
        public TextBox productQTYTB;
        public TextBox productNameTB;
        public TextBox textProductTb;
        public PictureBox PictureBox;
        public Button btn_clear;
        public Button btn_delete;
        public Button btn_edit;
    }
}