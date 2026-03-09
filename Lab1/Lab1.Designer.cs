namespace Lab1
{
    partial class Lab1
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
            lblNum1 = new Label();
            lblNum2 = new Label();
            txtNum1 = new TextBox();
            btnAdd = new Button();
            lblSum = new Label();
            txtNum3 = new TextBox();
            txtNum2 = new TextBox();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.BackColor = SystemColors.Control;
            lblNum1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNum1.ForeColor = SystemColors.WindowText;
            lblNum1.Location = new Point(199, 100);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(61, 26);
            lblNum1.TabIndex = 2;
            lblNum1.Text = "Num1";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.BackColor = SystemColors.Control;
            lblNum2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNum2.ForeColor = SystemColors.WindowText;
            lblNum2.Location = new Point(414, 100);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(64, 26);
            lblNum2.TabIndex = 4;
            lblNum2.Text = "Num2";
            // 
            // txtNum1
            // 
            txtNum1.BackColor = SystemColors.Info;
            txtNum1.Location = new Point(199, 129);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14F);
            btnAdd.Location = new Point(306, 164);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += this.btnAdd_Click;
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSum.Location = new Point(332, 207);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(50, 26);
            lblSum.TabIndex = 8;
            lblSum.Text = "Sum";
            // 
            // txtNum3
            // 
            txtNum3.BackColor = SystemColors.Info;
            txtNum3.Location = new Point(306, 236);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(100, 23);
            txtNum3.TabIndex = 9;
            // 
            // txtNum2
            // 
            txtNum2.BackColor = SystemColors.Info;
            txtNum2.Location = new Point(414, 129);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 10;
            // 
            // Lab1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNum2);
            Controls.Add(txtNum3);
            Controls.Add(lblSum);
            Controls.Add(btnAdd);
            Controls.Add(txtNum1);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "Lab1";
            Text = "FrmLab1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private Label lblNum2;
        private TextBox txtNum1;
        private Button btnAdd;
        private Label lblSum;
        private TextBox txtNum3;
        private TextBox txtNum2;
    }
}
