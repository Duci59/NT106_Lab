using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3.Bài_3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai3_TCPServer server = new Bai3_TCPServer();
            server.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai3_TCPClient client = new Bai3_TCPClient();
            client.Show();  
        }
    }
}
