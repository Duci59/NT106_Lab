namespace Lab5
{
    partial class Bai4
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
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listView1 = new ListView();
            NoEmail = new ColumnHeader();
            Source = new ColumnHeader();
            title = new ColumnHeader();
            time = new ColumnHeader();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 50);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Tài Khoản";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(111, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(506, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "vochinh231@gmail.com";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(111, 47);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(506, 27);
            textBox2.TabIndex = 3;
            textBox2.Text = "sxct fhwa mvqh icka";
            // 
            // button1
            // 
            button1.Location = new Point(12, 89);
            button1.Name = "button1";
            button1.Size = new Size(119, 45);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(178, 91);
            button2.Name = "button2";
            button2.Size = new Size(123, 43);
            button2.TabIndex = 5;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(361, 91);
            button3.Name = "button3";
            button3.Size = new Size(98, 43);
            button3.TabIndex = 6;
            button3.Text = "Send";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(519, 91);
            button4.Name = "button4";
            button4.Size = new Size(98, 43);
            button4.TabIndex = 7;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // listView1
            // 
            listView1.Alignment = ListViewAlignment.SnapToGrid;
            listView1.Columns.AddRange(new ColumnHeader[] { NoEmail, Source, title, time });
            listView1.GridLines = true;
            listView1.Location = new Point(24, 153);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(600, 342);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.Click += listView1_Click;
            listView1.FullRowSelect = true;
            // 
            // NoEmail
            // 
            NoEmail.Text = "#";
            NoEmail.Width = 40;
            // 
            // Source
            // 
            Source.Text = "From";
            Source.Width = 200;
            // 
            // title
            // 
            title.Text = "Subject";
            title.Width = 150;
            // 
            // time
            // 
            time.Text = "Date Time";
            time.Width = 200;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 519);
            Controls.Add(listView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai4";
            Text = "Bai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListView listView1;
        private ColumnHeader NoEmail;
        private ColumnHeader Source;
        private ColumnHeader title;
        private ColumnHeader time;
    }
}