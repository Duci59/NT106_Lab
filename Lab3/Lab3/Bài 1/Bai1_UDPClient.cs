using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Lab3
{
    public partial class Bai1_UDPClient : Form
    {
        public Bai1_UDPClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            Byte[] sendbytes = Encoding.UTF8.GetBytes(richTextBox1.Text);
            udpClient.Send(sendbytes, sendbytes.Length, textBox1.Text, int.Parse(textBox2.Text.Trim()));
        }
    }
}
