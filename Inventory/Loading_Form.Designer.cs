namespace Inventory
{
    partial class Loading_Form
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ProgressBar1 = new CircularProgressBar.CircularProgressBar();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(189, 26);
            label1.Name = "label1";
            label1.Size = new Size(761, 62);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY MANAGMENT SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(359, 107);
            label2.Name = "label2";
            label2.Size = new Size(388, 24);
            label2.TabIndex = 1;
            label2.Text = "Devolop by Adams Indastries";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Console", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(973, 487);
            label7.Name = "label7";
            label7.Size = new Size(118, 17);
            label7.TabIndex = 2;
            label7.Text = "Version 1.0";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // ProgressBar1
            // 
            ProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            ProgressBar1.AnimationSpeed = 500;
            ProgressBar1.BackColor = SystemColors.GrayText;
            ProgressBar1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            ProgressBar1.ForeColor = SystemColors.ButtonHighlight;
            ProgressBar1.InnerColor = SystemColors.GrayText;
            ProgressBar1.InnerMargin = 2;
            ProgressBar1.InnerWidth = -1;
            ProgressBar1.Location = new Point(391, 148);
            ProgressBar1.Margin = new Padding(3, 4, 3, 4);
            ProgressBar1.MarqueeAnimationSpeed = 3000;
            ProgressBar1.Minimum = 1;
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.OuterColor = SystemColors.ButtonShadow;
            ProgressBar1.OuterMargin = -25;
            ProgressBar1.OuterWidth = 26;
            ProgressBar1.ProgressColor = Color.ForestGreen;
            ProgressBar1.ProgressWidth = 15;
            ProgressBar1.SecondaryFont = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            ProgressBar1.Size = new Size(314, 300);
            ProgressBar1.StartAngle = 270;
            ProgressBar1.Style = ProgressBarStyle.Continuous;
            ProgressBar1.SubscriptColor = SystemColors.ButtonHighlight;
            ProgressBar1.SubscriptMargin = new Padding(10, -35, 0, 0);
            ProgressBar1.SubscriptText = ".";
            ProgressBar1.SuperscriptColor = SystemColors.ButtonHighlight;
            ProgressBar1.SuperscriptMargin = new Padding(10, 35, 0, 0);
            ProgressBar1.SuperscriptText = "";
            ProgressBar1.TabIndex = 5;
            ProgressBar1.TextMargin = new Padding(8, 8, 0, 0);
            ProgressBar1.Value = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1063, -6);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(39, 52);
            label5.TabIndex = 6;
            label5.Text = "-";
            label5.Click += label5_Click;
            // 
            // Loading_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1103, 520);
            Controls.Add(label5);
            Controls.Add(ProgressBar1);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Loading_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label7;
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar ProgressBar1;
        private Label label5;
    }
}