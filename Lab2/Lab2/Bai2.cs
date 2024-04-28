using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox1.Text = content;
            //Ten cua file
            textBox1.Text = ofd.SafeFileName.ToString();
            //URL
            textBox2.Text = fs.Name.ToString();
            content = content.Replace("\r\n", "\r");
            //So ky tu
            textBox5.Text = content.Length.ToString();
            //So dong
            textBox3.Text = richTextBox1.Lines.Count().ToString();
            //So tu
            content = content.Replace('\r', ' ');
            string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';', ':', ','}, StringSplitOptions.RemoveEmptyEntries);
            textBox4.Text = source.Count().ToString();
            fs.Close();
        }
    }
}
