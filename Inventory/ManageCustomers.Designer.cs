namespace Inventory
{
    partial class ManageCustomers
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
            label4 = new Label();
            CustomerGV = new DataGridView();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            customerPhoneTB = new TextBox();
            customerNameTB = new TextBox();
            customerIdTB = new TextBox();
            btn_home = new Button();
            btn_delete = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            dataGridView1 = new DataGridView();
            dataGridView3 = new DataGridView();
            label8 = new Label();
            OrderLabel = new Label();
            label10 = new Label();
            AmoutLabel = new Label();
            label12 = new Label();
            DateLabel = new Label();
            dataGridView2 = new DataGridView();
            panel3 = new Panel();
            label11 = new Label();
            label13 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel3.SuspendLayout();
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
            label9.TabIndex = 38;
            label9.Text = "_";
            label9.Click += label9_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1361, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(28, 32);
            label3.TabIndex = 2;
            label3.Text = "X";
            label3.Click += label3_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(641, 67);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(221, 32);
            label2.TabIndex = 1;
            label2.Text = "Manage Customers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(421, 7);
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
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(839, 181);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(305, 50);
            label4.TabIndex = 14;
            label4.Text = "CUSTOMER LIST";
            // 
            // CustomerGV
            // 
            CustomerGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomerGV.BackgroundColor = SystemColors.ButtonHighlight;
            CustomerGV.ColumnHeadersHeight = 34;
            CustomerGV.Location = new Point(641, 268);
            CustomerGV.Margin = new Padding(2, 3, 2, 3);
            CustomerGV.Name = "CustomerGV";
            CustomerGV.RowHeadersWidth = 62;
            CustomerGV.RowTemplate.Height = 33;
            CustomerGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerGV.Size = new Size(735, 463);
            CustomerGV.TabIndex = 13;
            CustomerGV.CellContentClick += CustomerGV_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(49, 451);
            label7.Name = "label7";
            label7.Size = new Size(151, 28);
            label7.TabIndex = 23;
            label7.Text = "CustomerPhone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(49, 363);
            label6.Name = "label6";
            label6.Size = new Size(148, 28);
            label6.TabIndex = 22;
            label6.Text = "CustomerName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(49, 271);
            label5.Name = "label5";
            label5.Size = new Size(113, 28);
            label5.TabIndex = 21;
            label5.Text = "CustomerId";
            // 
            // customerPhoneTB
            // 
            customerPhoneTB.BackColor = SystemColors.GrayText;
            customerPhoneTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerPhoneTB.ForeColor = SystemColors.ButtonHighlight;
            customerPhoneTB.Location = new Point(223, 451);
            customerPhoneTB.Margin = new Padding(2, 3, 2, 3);
            customerPhoneTB.Name = "customerPhoneTB";
            customerPhoneTB.Size = new Size(340, 34);
            customerPhoneTB.TabIndex = 19;
            customerPhoneTB.KeyPress += customerPhoneTB_KeyPress;
            // 
            // customerNameTB
            // 
            customerNameTB.BackColor = SystemColors.GrayText;
            customerNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerNameTB.ForeColor = SystemColors.ButtonHighlight;
            customerNameTB.Location = new Point(223, 356);
            customerNameTB.Margin = new Padding(2, 3, 2, 3);
            customerNameTB.Name = "customerNameTB";
            customerNameTB.Size = new Size(340, 34);
            customerNameTB.TabIndex = 18;
            // 
            // customerIdTB
            // 
            customerIdTB.BackColor = SystemColors.GrayText;
            customerIdTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerIdTB.ForeColor = SystemColors.AppWorkspace;
            customerIdTB.Location = new Point(223, 268);
            customerIdTB.Margin = new Padding(2, 3, 2, 3);
            customerIdTB.Name = "customerIdTB";
            customerIdTB.ReadOnly = true;
            customerIdTB.Size = new Size(340, 34);
            customerIdTB.TabIndex = 17;
            customerIdTB.KeyPress += customerIdTB_KeyPress;
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
            btn_home.TabIndex = 28;
            btn_home.Text = "Home";
            btn_home.UseVisualStyleBackColor = false;
            btn_home.Click += btn_home_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(192, 0, 0);
            btn_delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = SystemColors.ControlLightLight;
            btn_delete.Location = new Point(426, 579);
            btn_delete.Margin = new Padding(2, 3, 2, 3);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(119, 65);
            btn_delete.TabIndex = 27;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click_1;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(192, 0, 0);
            btn_edit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edit.ForeColor = SystemColors.ControlLightLight;
            btn_edit.Location = new Point(246, 579);
            btn_edit.Margin = new Padding(2, 3, 2, 3);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(119, 65);
            btn_edit.TabIndex = 26;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(192, 0, 0);
            btn_add.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.ForeColor = SystemColors.ControlLightLight;
            btn_add.Location = new Point(58, 579);
            btn_add.Margin = new Padding(2, 3, 2, 3);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(119, 65);
            btn_add.TabIndex = 25;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.MediumVioletRed;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Location = new Point(88, 812);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(227, 141);
            dataGridView1.TabIndex = 29;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = Color.FromArgb(192, 192, 0);
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridView3.ColumnHeadersHeight = 34;
            dataGridView3.Location = new Point(817, 812);
            dataGridView3.Margin = new Padding(2, 3, 2, 3);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.RowTemplate.Height = 33;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(293, 141);
            dataGridView3.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.MediumVioletRed;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(88, 812);
            label8.Name = "label8";
            label8.Size = new Size(167, 32);
            label8.TabIndex = 32;
            label8.Text = "Orders Count";
            // 
            // OrderLabel
            // 
            OrderLabel.AutoSize = true;
            OrderLabel.BackColor = Color.MediumVioletRed;
            OrderLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            OrderLabel.ForeColor = SystemColors.ButtonHighlight;
            OrderLabel.Location = new Point(129, 860);
            OrderLabel.Name = "OrderLabel";
            OrderLabel.Size = new Size(139, 50);
            OrderLabel.TabIndex = 33;
            OrderLabel.Text = "Orders";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DodgerBlue;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(479, 812);
            label10.Name = "label10";
            label10.Size = new Size(176, 32);
            label10.TabIndex = 34;
            label10.Text = "Orders Amout";
            // 
            // AmoutLabel
            // 
            AmoutLabel.AutoSize = true;
            AmoutLabel.BackColor = Color.DodgerBlue;
            AmoutLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            AmoutLabel.ForeColor = SystemColors.ButtonHighlight;
            AmoutLabel.Location = new Point(515, 860);
            AmoutLabel.Name = "AmoutLabel";
            AmoutLabel.Size = new Size(141, 50);
            AmoutLabel.TabIndex = 35;
            AmoutLabel.Text = "Amout";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(192, 192, 0);
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(879, 812);
            label12.Name = "label12";
            label12.Size = new Size(192, 32);
            label12.TabIndex = 36;
            label12.Text = "Last Order Date";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.BackColor = Color.FromArgb(192, 192, 0);
            DateLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            DateLabel.ForeColor = SystemColors.ButtonHighlight;
            DateLabel.Location = new Point(817, 872);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(78, 37);
            DateLabel.TabIndex = 37;
            DateLabel.Text = "Date";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.DodgerBlue;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeight = 34;
            dataGridView2.Location = new Point(479, 812);
            dataGridView2.Margin = new Padding(2, 3, 2, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(227, 141);
            dataGridView2.TabIndex = 30;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlText;
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label13);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 982);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1400, 51);
            panel3.TabIndex = 38;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Lucida Console", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.HighlightText;
            label11.Location = new Point(1271, 16);
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
            label13.Location = new Point(517, 16);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(318, 24);
            label13.TabIndex = 1;
            label13.Text = "Devolop By Adam Dobias";
            // 
            // ManageCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1400, 1033);
            Controls.Add(panel3);
            Controls.Add(DateLabel);
            Controls.Add(label12);
            Controls.Add(AmoutLabel);
            Controls.Add(label10);
            Controls.Add(OrderLabel);
            Controls.Add(label8);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(btn_home);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(customerPhoneTB);
            Controls.Add(customerNameTB);
            Controls.Add(customerIdTB);
            Controls.Add(label4);
            Controls.Add(CustomerGV);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCustomers";
            Load += ManageCustomers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private DataGridView CustomerGV;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox customerPhoneTB;
        private TextBox customerNameTB;
        private Button btn_home;
        private Button btn_delete;
        private Button btn_edit;
        private Button btn_add;
        private TextBox customerIdTB;
        private DataGridView dataGridView1;
        private DataGridView dataGridView3;
        private Label label8;
        private Label OrderLabel;
        private Label label10;
        private Label AmoutLabel;
        private Label label12;
        private Label DateLabel;
        private Label label9;
        private DataGridView dataGridView2;
        private Panel panel3;
        private Label label11;
        private Label label13;
    }
}