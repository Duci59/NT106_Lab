namespace Lab4
{
    partial class Menu
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
            bai1 = new Button();
            bai2 = new Button();
            bai3 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            SuspendLayout();
            // 
            // bai1
            // 
            bai1.Location = new Point(65, 38);
            bai1.Name = "bai1";
            bai1.Size = new Size(108, 60);
            bai1.TabIndex = 0;
            bai1.Text = "Bài 1";
            bai1.UseVisualStyleBackColor = true;
            bai1.Click += bai1_Click;
            // 
            // bai2
            // 
            bai2.Location = new Point(283, 38);
            bai2.Name = "bai2";
            bai2.Size = new Size(108, 60);
            bai2.TabIndex = 1;
            bai2.Text = "Bài 2";
            bai2.UseVisualStyleBackColor = true;
            bai2.Click += bai2_Click;
            // 
            // bai3
            // 
            bai3.Location = new Point(65, 144);
            bai3.Name = "bai3";
            bai3.Size = new Size(108, 60);
            bai3.TabIndex = 2;
            bai3.Text = "Bài 3";
            bai3.UseVisualStyleBackColor = true;
            bai3.Click += bai3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(283, 144);
            button1.Name = "button1";
            button1.Size = new Size(108, 60);
            button1.TabIndex = 3;
            button1.Text = "Bài 4";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 305);
            Controls.Add(button1);
            Controls.Add(bai3);
            Controls.Add(bai2);
            Controls.Add(bai1);
            Name = "Menu";
            Text = "Form1";
            Load += Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button bai1;
        private Button bai2;
        private Button bai3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
    }
}
