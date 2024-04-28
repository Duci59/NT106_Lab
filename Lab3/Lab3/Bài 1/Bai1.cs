using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1_UDPServer server = new Bai1_UDPServer();
            server.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai1_UDPClient client = new Bai1_UDPClient();
            client.Show();
        }
    }
}
