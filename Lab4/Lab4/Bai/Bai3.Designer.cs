namespace Lab4.Bai
{
    partial class Bai3
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
            tbstore = new TextBox();
            rtbhtml = new RichTextBox();
            btndown = new Button();
            tburl = new TextBox();
            SuspendLayout();
            // 
            // tbstore
            // 
            tbstore.Location = new Point(154, 68);
            tbstore.Name = "tbstore";
            tbstore.Size = new Size(364, 27);
            tbstore.TabIndex = 10;
            tbstore.Text = "D:\\Lab4 LTMCB\\uit.html";
            // 
            // rtbhtml
            // 
            rtbhtml.Location = new Point(154, 114);
            rtbhtml.Name = "rtbhtml";
            rtbhtml.Size = new Size(492, 319);
            rtbhtml.TabIndex = 9;
            rtbhtml.Text = "";
            // 
            // btndown
            // 
            btndown.Location = new Point(554, 18);
            btndown.Name = "btndown";
            btndown.Size = new Size(92, 36);
            btndown.TabIndex = 8;
            btndown.Text = "DOWN";
            btndown.UseVisualStyleBackColor = true;
            btndown.Click += btndown_Click;
            // 
            // tburl
            // 
            tburl.Location = new Point(154, 25);
            tburl.Name = "tburl";
            tburl.Size = new Size(364, 27);
            tburl.TabIndex = 7;
            tburl.Text = "http://uit.edu.vn";
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbstore);
            Controls.Add(rtbhtml);
            Controls.Add(btndown);
            Controls.Add(tburl);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbstore;
        private RichTextBox rtbhtml;
        private Button btndown;
        private TextBox tburl;
    }
}