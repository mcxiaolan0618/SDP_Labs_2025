namespace Lab3
{
    partial class Lab3B
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
            lbl1 = new Label();
            txt1 = new TextBox();
            lbl2 = new Label();
            txt2 = new TextBox();
            btn1 = new Button();
            lblvalue1 = new Label();
            lblvalue2 = new Label();
            lblY1 = new Label();
            lblY2 = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(31, 29);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(51, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Amount";
            // 
            // txt1
            // 
            txt1.Location = new Point(134, 26);
            txt1.Name = "txt1";
            txt1.Size = new Size(220, 23);
            txt1.TabIndex = 1;
            txt1.TextAlign = HorizontalAlignment.Right;
            // 
            // lbl2
            // 
            lbl2.Location = new Point(31, 87);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(100, 34);
            lbl2.TabIndex = 2;
            lbl2.Text = "Interest Rate (Annual)";
            // 
            // txt2
            // 
            txt2.Location = new Point(134, 87);
            txt2.Name = "txt2";
            txt2.Size = new Size(220, 23);
            txt2.TabIndex = 3;
            txt2.TextAlign = HorizontalAlignment.Right;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.Info;
            btn1.Location = new Point(31, 146);
            btn1.Name = "btn1";
            btn1.Size = new Size(323, 41);
            btn1.TabIndex = 4;
            btn1.Text = "Start Calulatuin";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += this.btn1_Click;
            // 
            // lblvalue1
            // 
            lblvalue1.Location = new Point(31, 219);
            lblvalue1.Name = "lblvalue1";
            lblvalue1.Size = new Size(100, 34);
            lblvalue1.TabIndex = 5;
            lblvalue1.Text = "Value alter 10 years";
            // 
            // lblvalue2
            // 
            lblvalue2.BorderStyle = BorderStyle.Fixed3D;
            lblvalue2.Location = new Point(137, 219);
            lblvalue2.Name = "lblvalue2";
            lblvalue2.Size = new Size(217, 34);
            lblvalue2.TabIndex = 6;
            // 
            // lblY1
            // 
            lblY1.Location = new Point(31, 293);
            lblY1.Name = "lblY1";
            lblY1.Size = new Size(100, 32);
            lblY1.TabIndex = 7;
            lblY1.Text = "Years to reach $1M";
            // 
            // lblY2
            // 
            lblY2.BorderStyle = BorderStyle.Fixed3D;
            lblY2.Location = new Point(137, 291);
            lblY2.Name = "lblY2";
            lblY2.Size = new Size(217, 34);
            lblY2.TabIndex = 8;
            // 
            // Lab3B
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(lblY2);
            Controls.Add(lblY1);
            Controls.Add(lblvalue2);
            Controls.Add(lblvalue1);
            Controls.Add(btn1);
            Controls.Add(txt2);
            Controls.Add(lbl2);
            Controls.Add(txt1);
            Controls.Add(lbl1);
            Name = "Lab3B";
            Text = "Compound Interest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txt1;
        private Label lbl2;
        private TextBox txt2;
        private Button btn1;
        private Label lblvalue1;
        private Label lblvalue2;
        private Label lblY1;
        private Label lblY2;
    }
}