namespace Lab4._1
{
    partial class Form1
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
            button1 = new Button();
            bai3 = new Button();
            bai2 = new Button();
            bai1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(275, 139);
            button1.Name = "button1";
            button1.Size = new Size(108, 60);
            button1.TabIndex = 7;
            button1.Text = "Bài 4";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bai3
            // 
            bai3.Location = new Point(57, 139);
            bai3.Name = "bai3";
            bai3.Size = new Size(108, 60);
            bai3.TabIndex = 6;
            bai3.Text = "Bài 3";
            bai3.UseVisualStyleBackColor = true;
            bai3.Click += bai3_Click;
            // 
            // bai2
            // 
            bai2.Location = new Point(275, 33);
            bai2.Name = "bai2";
            bai2.Size = new Size(108, 60);
            bai2.TabIndex = 5;
            bai2.Text = "Bài 2";
            bai2.UseVisualStyleBackColor = true;
            bai2.Click += bai2_Click;
            // 
            // bai1
            // 
            bai1.Location = new Point(57, 33);
            bai1.Name = "bai1";
            bai1.Size = new Size(108, 60);
            bai1.TabIndex = 4;
            bai1.Text = "Bài 1";
            bai1.UseVisualStyleBackColor = true;
            bai1.Click += bai1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 270);
            Controls.Add(button1);
            Controls.Add(bai3);
            Controls.Add(bai2);
            Controls.Add(bai1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button bai3;
        private Button bai2;
        private Button bai1;
    }
}
