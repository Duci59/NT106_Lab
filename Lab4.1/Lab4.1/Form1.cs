using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bai1_Click(object sender, EventArgs e)
        {
            Bai.Bai1 bai1 = new Bai.Bai1();
            bai1.Show();
        }

        private void bai2_Click(object sender, EventArgs e)
        {
            Bai.Bai2 bai2 = new Bai.Bai2(); 
            bai2.Show();
        }

        private void bai3_Click(object sender, EventArgs e)
        {
            Bai.Bai3 bai3 = new Bai.Bai3();
            bai3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai.WebBrowser bAI4 = new Bai.WebBrowser();
            bAI4.Show();
        }
    }
}
