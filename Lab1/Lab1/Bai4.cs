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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1 == null)
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!");
            }
            else
            {
                if (comboBox1.Text == "Decimal" && int.TryParse(textBox1.Text.Trim(),out int n)) 
                {
                    if (comboBox2.Text == "Decimal")
                    {
                        textBox2.Text = textBox1.Text;
                    }
                    else if (comboBox2.Text == "Binary")
                    {
                        textBox2.Text = Convert.ToString(int.Parse(textBox1.Text.Trim()), 2);
                    }
                    else
                    {
                        textBox2.Text = "0x" + int.Parse(textBox1.Text.Trim()).ToString("X");
                    }
                }
                else if (comboBox1.Text == "Binary")
                {
                    if (comboBox2.Text == "Decimal")
                    {
                        textBox2.Text = Convert.ToInt32(textBox1.Text, 2).ToString();
                    }
                    else if (comboBox2.Text == "Binary")
                    {
                        textBox2.Text = textBox1.Text;
                    }
                    else
                    {
                        textBox2.Text = "0x" + Convert.ToInt32(textBox1.Text,2).ToString("X");
                    }
                }
                else
                {
                    if (comboBox2.Text == "Decimal")
                    {
                        textBox2.Text = Convert.ToInt32(textBox1.Text, 16).ToString();
                    }
                    else if (comboBox2.Text == "Binary")
                    {
                        textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 16),2);
                    }
                    else
                    {
                        textBox2.Text = textBox1.Text;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }
    }
}
