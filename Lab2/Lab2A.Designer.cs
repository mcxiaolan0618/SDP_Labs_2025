namespace Lab2
{
    partial class Lab2A
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
            gb1 = new GroupBox();
            rb3 = new RadioButton();
            rb1 = new RadioButton();
            rb2 = new RadioButton();
            gb2 = new GroupBox();
            rb4 = new RadioButton();
            rb5 = new RadioButton();
            lb1 = new Label();
            txtNum1 = new TextBox();
            bt1 = new Button();
            lbResult = new Label();
            gb1.SuspendLayout();
            gb2.SuspendLayout();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.Controls.Add(rb3);
            gb1.Controls.Add(rb1);
            gb1.Controls.Add(rb2);
            gb1.Location = new Point(50, 50);
            gb1.Name = "gb1";
            gb1.Size = new Size(200, 141);
            gb1.TabIndex = 2;
            gb1.TabStop = false;
            gb1.Text = "Wine List";
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Location = new Point(19, 102);
            rb3.Name = "rb3";
            rb3.Size = new Size(129, 19);
            rb3.TabIndex = 3;
            rb3.TabStop = true;
            rb3.Text = "Beer (1 dozen) ($75)";
            rb3.UseVisualStyleBackColor = true;
            rb3.CheckedChanged += rb3_CheckedChanged;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(19, 22);
            rb1.Name = "rb1";
            rb1.Size = new Size(87, 19);
            rb1.TabIndex = 0;
            rb1.TabStop = true;
            rb1.Text = "Wine ($250)";
            rb1.UseVisualStyleBackColor = true;
            rb1.CheckedChanged += rb1_CheckedChanged;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(19, 62);
            rb2.Name = "rb2";
            rb2.Size = new Size(121, 19);
            rb2.TabIndex = 2;
            rb2.TabStop = true;
            rb2.Text = "White Wine ($180)";
            rb2.UseVisualStyleBackColor = true;
            rb2.CheckedChanged += rb2_CheckedChanged;
            // 
            // gb2
            // 
            gb2.Controls.Add(rb4);
            gb2.Controls.Add(rb5);
            gb2.Location = new Point(285, 50);
            gb2.Name = "gb2";
            gb2.Size = new Size(200, 100);
            gb2.TabIndex = 3;
            gb2.TabStop = false;
            gb2.Text = "Payment";
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.Location = new Point(19, 22);
            rb4.Name = "rb4";
            rb4.Size = new Size(49, 19);
            rb4.TabIndex = 0;
            rb4.TabStop = true;
            rb4.Text = "VISA";
            rb4.UseVisualStyleBackColor = true;
            rb4.CheckedChanged += rb4_CheckedChanged;
            // 
            // rb5
            // 
            rb5.AutoSize = true;
            rb5.Location = new Point(19, 59);
            rb5.Name = "rb5";
            rb5.Size = new Size(86, 19);
            rb5.TabIndex = 2;
            rb5.TabStop = true;
            rb5.Text = "MasterCard";
            rb5.UseVisualStyleBackColor = true;
            rb5.CheckedChanged += rb5_CheckedChanged;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(285, 164);
            lb1.Name = "lb1";
            lb1.Size = new Size(26, 15);
            lb1.TabIndex = 4;
            lb1.Text = "Qty";
            // 
            // txtNum1
            // 
            txtNum1.BackColor = SystemColors.Window;
            txtNum1.BorderStyle = BorderStyle.None;
            txtNum1.Location = new Point(323, 164);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(67, 16);
            txtNum1.TabIndex = 6;
            // 
            // bt1
            // 
            bt1.Location = new Point(396, 160);
            bt1.Name = "bt1";
            bt1.Size = new Size(75, 23);
            bt1.TabIndex = 7;
            bt1.Text = "Calculate";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // lbResult
            // 
            lbResult.BackColor = SystemColors.Control;
            lbResult.BorderStyle = BorderStyle.Fixed3D;
            lbResult.Location = new Point(55, 207);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(416, 52);
            lbResult.TabIndex = 8;
            // 
            // Lab2A
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResult);
            Controls.Add(bt1);
            Controls.Add(txtNum1);
            Controls.Add(lb1);
            Controls.Add(gb2);
            Controls.Add(gb1);
            Name = "Lab2A";
            Text = "FrmLab2A";
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            gb2.ResumeLayout(false);
            gb2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb1;
        private RadioButton rb3;
        private RadioButton rb1;
        private RadioButton rb2;
        private GroupBox gb2;
        private RadioButton rb4;
        private RadioButton rb5;
        private Label lb1;
        private TextBox txtNum1;
        private Button bt1;
        private Label lbResult;
    }
}
