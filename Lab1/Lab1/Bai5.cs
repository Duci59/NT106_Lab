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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] s = textBox1.Text.Split(' ');
            float[] f = new float[s.Length];
            string mes = "", Xeploai = "";
            float max = -1, min = 11, sum = 0, pass = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!(float.TryParse(s[i].Trim(), out f[i])))
                {
                    MessageBox.Show("so thu " + (i + 1).ToString() + " khong hop le!", "error");
                    return;
                }
                if (f[i] < 0 || 10 < f[i])
                {
                    MessageBox.Show("so thu " + (i + 1).ToString() + " khong hop le!", "error");
                    return;
                }
                sum = sum + f[i];
                if (f[i] > max) max = f[i];
                if (f[i] < min) min = f[i];
                if (f[i] >= 5) ++pass;
                mes = mes + "Môn " + (i + 1).ToString() + ": " + s[i].Trim() + "đ" + "         ";

            }
            tbdau.Text = pass.ToString();
            tbkodau.Text = (s.Length - pass).ToString();
            tbMax.Text = max.ToString() + "đ";
            tbmin.Text = min.ToString() + "đ";
            tbdtb.Text = Math.Round(sum / f.Length, 2).ToString();
            double dtb = Math.Round(sum / (f.Length), 2);
            richTextBox1.Text = mes;
            if ((dtb >= 8.5) && (min >= 6.5)) Xeploai = "Giỏi";
            else if ((dtb >= 6.5) && (min >= 5)) Xeploai = "Khá";
            else if ((dtb >= 5) && (min >= 3.5)) Xeploai = "Trung bình";
            else if ((dtb >= 3.5) && (min >= 2)) Xeploai = "Yếu";
            else Xeploai = "Kém";
            tbxl.Text = Xeploai;
        }
    }
}
