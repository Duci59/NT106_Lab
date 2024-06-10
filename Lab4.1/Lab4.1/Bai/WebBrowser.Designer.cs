namespace Lab4._1.Bai
{
    partial class WebBrowser
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
            tbPath = new TextBox();
            btnViewSource = new Button();
            btnDowHTML = new Button();
            tbAddress = new TextBox();
            btnGo = new Button();
            pnWeb = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // tbPath
            // 
            tbPath.Location = new Point(12, 60);
            tbPath.Margin = new Padding(3, 4, 3, 4);
            tbPath.Multiline = true;
            tbPath.Name = "tbPath";
            tbPath.Size = new Size(1016, 38);
            tbPath.TabIndex = 5;
            tbPath.Text = "D:\\Lab4 LTMCB";
            // 
            // btnViewSource
            // 
            btnViewSource.AutoSize = true;
            btnViewSource.BackColor = SystemColors.ButtonFace;
            btnViewSource.Location = new Point(1188, 59);
            btnViewSource.Margin = new Padding(3, 4, 3, 4);
            btnViewSource.Name = "btnViewSource";
            btnViewSource.Size = new Size(123, 39);
            btnViewSource.TabIndex = 6;
            btnViewSource.Text = "ViewSource";
            btnViewSource.UseVisualStyleBackColor = false;
            btnViewSource.Click += btnViewSource_Click;
            // 
            // btnDowHTML
            // 
            btnDowHTML.AutoSize = true;
            btnDowHTML.BackColor = SystemColors.ButtonFace;
            btnDowHTML.Location = new Point(1034, 60);
            btnDowHTML.Margin = new Padding(3, 4, 3, 4);
            btnDowHTML.Name = "btnDowHTML";
            btnDowHTML.Size = new Size(135, 39);
            btnDowHTML.TabIndex = 4;
            btnDowHTML.Text = "Download HTML ";
            btnDowHTML.UseVisualStyleBackColor = false;
            btnDowHTML.Click += btnDowHTML_Click;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(12, 13);
            tbAddress.Margin = new Padding(3, 4, 3, 4);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(1075, 38);
            tbAddress.TabIndex = 2;
            // 
            // btnGo
            // 
            btnGo.AutoSize = true;
            btnGo.BackColor = SystemColors.ButtonFace;
            btnGo.Location = new Point(1105, 12);
            btnGo.Margin = new Padding(3, 4, 3, 4);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(120, 39);
            btnGo.TabIndex = 1;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = false;
            btnGo.Click += btnGo_Click;
            // 
            // pnWeb
            // 
            pnWeb.Location = new Point(12, 117);
            pnWeb.Margin = new Padding(3, 4, 3, 4);
            pnWeb.Name = "pnWeb";
            pnWeb.Size = new Size(1299, 608);
            pnWeb.TabIndex = 3;
            // 
            // WebBrowser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 738);
            Controls.Add(tbAddress);
            Controls.Add(btnDowHTML);
            Controls.Add(pnWeb);
            Controls.Add(tbPath);
            Controls.Add(btnGo);
            Controls.Add(btnViewSource);
            Margin = new Padding(3, 4, 3, 4);
            Name = "WebBrowser";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnViewSource;
        private System.Windows.Forms.Button btnDowHTML;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.FlowLayoutPanel pnWeb;
    }
}

