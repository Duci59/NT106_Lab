namespace Lab4.Bai
{
    partial class Bai1
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
            tburl = new TextBox();
            btnget = new Button();
            rtbhtml = new RichTextBox();
            SuspendLayout();
            // 
            // tburl
            // 
            tburl.Location = new Point(33, 34);
            tburl.Name = "tburl";
            tburl.Size = new Size(364, 27);
            tburl.TabIndex = 0;
            tburl.TextChanged += tburl_TextChanged;
            // 
            // btnget
            // 
            btnget.Location = new Point(433, 27);
            btnget.Name = "btnget";
            btnget.Size = new Size(92, 36);
            btnget.TabIndex = 1;
            btnget.Text = "GET";
            btnget.UseVisualStyleBackColor = true;
            btnget.Click += button1_Click;
            // 
            // rtbhtml
            // 
            rtbhtml.Location = new Point(33, 95);
            rtbhtml.Name = "rtbhtml";
            rtbhtml.Size = new Size(492, 319);
            rtbhtml.TabIndex = 2;
            rtbhtml.Text = "";
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 450);
            Controls.Add(rtbhtml);
            Controls.Add(btnget);
            Controls.Add(tburl);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tburl;
        private Button btnget;
        private RichTextBox rtbhtml;
    }
}