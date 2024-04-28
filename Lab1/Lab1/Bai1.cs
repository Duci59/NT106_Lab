using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long sum = 0;
            if (int.TryParse(textBox1.Text.Trim(), out int num1) && int.TryParse(textBox2.Text.Trim(), out int num2))
            {
                num1 = int.Parse(textBox1.Text.Trim());
                num2 = int.Parse(textBox2.Text.Trim());
                sum = num1 + num2;
                textBox3.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text= string.Empty;
            textBox2.Text= string.Empty;
            textBox3.Text= string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
