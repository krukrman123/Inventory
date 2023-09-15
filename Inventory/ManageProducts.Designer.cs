namespace Inventory
{
    partial class ManageProducts
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
            label_Minimize = new Label();
            label_Exit = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            btn_home = new Button();
            searchCombo_Products = new ComboBox();
            btn_sreach = new Button();
            btn_Refresh = new Button();
            label11 = new Label();
            label13 = new Label();
            panel3 = new Panel();
            ProductGV = new DataGridView();
            ProdID = new DataGridViewTextBoxColumn();
            ProdName = new DataGridViewTextBoxColumn();
            ProdQty = new DataGridViewTextBoxColumn();
            ProdPrice = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            ProdCat = new DataGridViewTextBoxColumn();
            ProdFile = new DataGridViewTextBoxColumn();
            ProdText = new DataGridViewTextBoxColumn();
            Picture = new DataGridViewImageColumn();
            btn_Add = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlText;
            panel1.Controls.Add(label_Minimize);
            panel1.Controls.Add(label_Exit);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1814, 120);
            panel1.TabIndex = 2;
            // 
            // label_Minimize
            // 
            label_Minimize.AutoSize = true;
            label_Minimize.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_Minimize.ForeColor = Color.White;
            label_Minimize.Location = new Point(1752, 2);
            label_Minimize.Margin = new Padding(2, 0, 2, 0);
            label_Minimize.Name = "label_Minimize";
            label_Minimize.Size = new Size(29, 38);
            label_Minimize.TabIndex = 45;
            label_Minimize.Text = "_";
            label_Minimize.Click += label10_Click;
            // 
            // label_Exit
            // 
            label_Exit.AutoSize = true;
            label_Exit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Exit.ForeColor = Color.White;
            label_Exit.Location = new Point(1785, 12);
            label_Exit.Margin = new Padding(2, 0, 2, 0);
            label_Exit.Name = "label_Exit";
            label_Exit.Size = new Size(28, 32);
            label_Exit.TabIndex = 2;
            label_Exit.Text = "X";
            label_Exit.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(824, 56);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 32);
            label2.TabIndex = 1;
            label2.Text = "Manage Products";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(610, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(618, 50);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(769, 146);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(280, 50);
            label4.TabIndex = 31;
            label4.Text = "PRODUCT LIST";
            // 
            // btn_home
            // 
            btn_home.BackColor = Color.FromArgb(192, 0, 0);
            btn_home.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_home.ForeColor = SystemColors.ControlLightLight;
            btn_home.Location = new Point(14, 266);
            btn_home.Margin = new Padding(2);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(264, 66);
            btn_home.TabIndex = 35;
            btn_home.Text = "Home";
            btn_home.UseVisualStyleBackColor = false;
            btn_home.Click += btn_home_Click;
            // 
            // searchCombo_Products
            // 
            searchCombo_Products.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchCombo_Products.FormattingEnabled = true;
            searchCombo_Products.Location = new Point(1304, 292);
            searchCombo_Products.Margin = new Padding(3, 4, 3, 4);
            searchCombo_Products.Name = "searchCombo_Products";
            searchCombo_Products.Size = new Size(370, 36);
            searchCombo_Products.TabIndex = 41;
            searchCombo_Products.Text = "Select Category";
            // 
            // btn_sreach
            // 
            btn_sreach.BackColor = Color.FromArgb(192, 0, 0);
            btn_sreach.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sreach.ForeColor = SystemColors.ControlLightLight;
            btn_sreach.Location = new Point(1680, 292);
            btn_sreach.Margin = new Padding(2);
            btn_sreach.Name = "btn_sreach";
            btn_sreach.Size = new Size(120, 38);
            btn_sreach.TabIndex = 42;
            btn_sreach.Text = "Sreach";
            btn_sreach.UseVisualStyleBackColor = false;
            btn_sreach.Click += btn_sreach_Click;
            // 
            // btn_Refresh
            // 
            btn_Refresh.BackColor = Color.FromArgb(192, 0, 0);
            btn_Refresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Refresh.ForeColor = SystemColors.ControlLightLight;
            btn_Refresh.Location = new Point(310, 266);
            btn_Refresh.Margin = new Padding(2);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(264, 66);
            btn_Refresh.TabIndex = 43;
            btn_Refresh.Text = "Refresh";
            btn_Refresh.UseVisualStyleBackColor = false;
            btn_Refresh.Click += btn_Refresh_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Lucida Console", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.HighlightText;
            label11.Location = new Point(1680, 20);
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
            label13.Location = new Point(731, 14);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(318, 24);
            label13.TabIndex = 1;
            label13.Text = "Devolop By Adam Dobias";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlText;
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label13);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 1204);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1814, 50);
            panel3.TabIndex = 44;
            // 
            // ProductGV
            // 
            ProductGV.AllowUserToOrderColumns = true;
            ProductGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductGV.ColumnHeadersHeight = 34;
            ProductGV.Columns.AddRange(new DataGridViewColumn[] { ProdID, ProdName, ProdQty, ProdPrice, Description, ProdCat, ProdFile, ProdText, Picture });
            ProductGV.Location = new Point(14, 350);
            ProductGV.Margin = new Padding(3, 4, 3, 4);
            ProductGV.Name = "ProductGV";
            ProductGV.ReadOnly = true;
            ProductGV.RowHeadersWidth = 62;
            ProductGV.RowTemplate.Height = 25;
            ProductGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductGV.Size = new Size(1786, 832);
            ProductGV.TabIndex = 50;
            ProductGV.CellClick += ProductGV_CellClick;
            // 
            // ProdID
            // 
            ProdID.DataPropertyName = "ProdId";
            ProdID.FillWeight = 16.86007F;
            ProdID.HeaderText = "ProdId";
            ProdID.MinimumWidth = 8;
            ProdID.Name = "ProdID";
            ProdID.ReadOnly = true;
            // 
            // ProdName
            // 
            ProdName.DataPropertyName = "ProdName";
            ProdName.FillWeight = 16.86007F;
            ProdName.HeaderText = "ProdName";
            ProdName.MinimumWidth = 8;
            ProdName.Name = "ProdName";
            ProdName.ReadOnly = true;
            // 
            // ProdQty
            // 
            ProdQty.DataPropertyName = "ProdQty";
            ProdQty.FillWeight = 16.86007F;
            ProdQty.HeaderText = "ProdQty";
            ProdQty.MinimumWidth = 8;
            ProdQty.Name = "ProdQty";
            ProdQty.ReadOnly = true;
            // 
            // ProdPrice
            // 
            ProdPrice.DataPropertyName = "ProdPrice";
            ProdPrice.FillWeight = 16.86007F;
            ProdPrice.HeaderText = "ProdPrice";
            ProdPrice.MinimumWidth = 8;
            ProdPrice.Name = "ProdPrice";
            ProdPrice.ReadOnly = true;
            // 
            // Description
            // 
            Description.DataPropertyName = "ProdDesc";
            Description.FillWeight = 16.86007F;
            Description.HeaderText = "Description";
            Description.MinimumWidth = 8;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // ProdCat
            // 
            ProdCat.DataPropertyName = "ProdCat";
            ProdCat.FillWeight = 16.86007F;
            ProdCat.HeaderText = "ProdCat";
            ProdCat.MinimumWidth = 8;
            ProdCat.Name = "ProdCat";
            ProdCat.ReadOnly = true;
            // 
            // ProdFile
            // 
            ProdFile.DataPropertyName = "ProdFile";
            ProdFile.FillWeight = 16.86007F;
            ProdFile.HeaderText = "ProdFile";
            ProdFile.MinimumWidth = 8;
            ProdFile.Name = "ProdFile";
            ProdFile.ReadOnly = true;
            // 
            // ProdText
            // 
            ProdText.DataPropertyName = "ProdText";
            ProdText.FillWeight = 16.86007F;
            ProdText.HeaderText = "ProdText";
            ProdText.MinimumWidth = 8;
            ProdText.Name = "ProdText";
            ProdText.ReadOnly = true;
            // 
            // Picture
            // 
            Picture.DataPropertyName = "ProdImage";
            Picture.FillWeight = 45.87774F;
            Picture.HeaderText = "Picture";
            Picture.MinimumWidth = 8;
            Picture.Name = "Picture";
            Picture.ReadOnly = true;
            Picture.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(192, 0, 0);
            btn_Add.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Add.ForeColor = SystemColors.ControlLightLight;
            btn_Add.Location = new Point(599, 266);
            btn_Add.Margin = new Padding(2);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(264, 66);
            btn_Add.TabIndex = 75;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_add_Click;
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1814, 1254);
            Controls.Add(btn_Add);
            Controls.Add(ProductGV);
            Controls.Add(panel3);
            Controls.Add(btn_Refresh);
            Controls.Add(btn_sreach);
            Controls.Add(searchCombo_Products);
            Controls.Add(btn_home);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageProducts";
            Load += ManageProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label_Exit;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button btn_home;
        private ComboBox searchCombo_Products;
        private Button btn_sreach;
        private Button btn_Refresh;
        private Label label11;
        private Label label13;
        private Panel panel3;
        private Label label_Minimize;
        private DataGridView ProductGV;
        public Button btn_Add;
        private DataGridViewTextBoxColumn ProdID;
        private DataGridViewTextBoxColumn ProdName;
        private DataGridViewTextBoxColumn ProdQty;
        private DataGridViewTextBoxColumn ProdPrice;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn ProdCat;
        private DataGridViewTextBoxColumn ProdFile;
        private DataGridViewTextBoxColumn ProdText;
        private DataGridViewImageColumn Picture;
    }
}