namespace Lab4.Bai
{
    partial class BAI4
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
            btnAdd = new Button();
            btnview = new Button();
            btndown = new Button();
            tbpath = new TextBox();
            btnGo = new Button();
            tburl = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnview);
            panel1.Controls.Add(btndown);
            panel1.Controls.Add(tbpath);
            panel1.Controls.Add(btnGo);
            panel1.Controls.Add(tburl);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1151, 582);
            panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(794, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 35);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add WebBrowser";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnview
            // 
            btnview.Location = new Point(962, 58);
            btnview.Name = "btnview";
            btnview.Size = new Size(150, 35);
            btnview.TabIndex = 16;
            btnview.Text = "View Source";
            btnview.UseVisualStyleBackColor = true;
            // 
            // btndown
            // 
            btndown.Location = new Point(794, 58);
            btndown.Name = "btndown";
            btndown.Size = new Size(149, 35);
            btndown.TabIndex = 15;
            btndown.Text = "Download HTML";
            btndown.UseVisualStyleBackColor = true;
            // 
            // tbpath
            // 
            tbpath.Location = new Point(27, 59);
            tbpath.Multiline = true;
            tbpath.Name = "tbpath";
            tbpath.Size = new Size(745, 34);
            tbpath.TabIndex = 14;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(991, 18);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(109, 33);
            btnGo.TabIndex = 13;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = true;
            // 
            // tburl
            // 
            tburl.Location = new Point(27, 22);
            tburl.Multiline = true;
            tburl.Name = "tburl";
            tburl.Size = new Size(747, 31);
            tburl.TabIndex = 12;
            // 
            // BAI4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 582);
            Controls.Add(panel1);
            Name = "BAI4";
            Text = "BAI4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAdd;
        private Button btnview;
        private Button btndown;
        private TextBox tbpath;
        private Button btnGo;
        private TextBox tburl;
    }
}