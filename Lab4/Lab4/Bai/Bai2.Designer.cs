namespace Lab4.Bai
{
    partial class Bai2
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
            rtbhtml = new RichTextBox();
            btnpost = new Button();
            tburl = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // rtbhtml
            // 
            rtbhtml.Location = new Point(72, 100);
            rtbhtml.Name = "rtbhtml";
            rtbhtml.Size = new Size(492, 319);
            rtbhtml.TabIndex = 5;
            rtbhtml.Text = "";
            // 
            // btnpost
            // 
            btnpost.Location = new Point(472, 4);
            btnpost.Name = "btnpost";
            btnpost.Size = new Size(92, 36);
            btnpost.TabIndex = 4;
            btnpost.Text = "POST";
            btnpost.UseVisualStyleBackColor = true;
            btnpost.Click += btnpost_Click;
            // 
            // tburl
            // 
            tburl.Location = new Point(72, 11);
            tburl.Name = "tburl";
            tburl.Size = new Size(364, 27);
            tburl.TabIndex = 3;
            tburl.Text = "http://www.contoso.com/PostAccepter.aspx";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(364, 27);
            textBox1.TabIndex = 6;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 446);
            Controls.Add(textBox1);
            Controls.Add(rtbhtml);
            Controls.Add(btnpost);
            Controls.Add(tburl);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbhtml;
        private Button btnpost;
        private TextBox tburl;
        private TextBox textBox1;
    }
}