
namespace Lab3
{
    partial class Lab3A
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
            cbomovie = new ComboBox();
            lbl1 = new Label();
            btnvote = new Button();
            SuspendLayout();
            // 
            // cbomovie
            // 
            cbomovie.FormattingEnabled = true;
            cbomovie.Items.AddRange(new object[] { "The Godfather", "Terminator", "Back To The Future", "Matrix" });
            cbomovie.Location = new Point(23, 58);
            cbomovie.Name = "cbomovie";
            cbomovie.Size = new Size(247, 23);
            cbomovie.TabIndex = 0;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(23, 24);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(247, 21);
            lbl1.TabIndex = 1;
            lbl1.Text = "My Choice of Best Movie Series";
            // 
            // btnvote
            // 
            btnvote.Location = new Point(23, 100);
            btnvote.Name = "btnvote";
            btnvote.Size = new Size(247, 23);
            btnvote.TabIndex = 2;
            btnvote.Text = "Cast Your Vote";
            btnvote.UseVisualStyleBackColor = true;
            btnvote.Click += btnvote_Click;
            // 
            // Lab3A
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 186);
            Controls.Add(btnvote);
            Controls.Add(lbl1);
            Controls.Add(cbomovie);
            Name = "Lab3A";
            Text = "FrmLab1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbomovie;
        private Label lbl1;
        private Button btnvote;
    }
}
