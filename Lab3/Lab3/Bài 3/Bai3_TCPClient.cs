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
using System.Net;

namespace Lab3.Bài_3
{
    public partial class Bai3_TCPClient : Form
    {
        public Bai3_TCPClient()
        {
            InitializeComponent();
        }

        Client client;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null)
                    client.Send();
                else
                    MessageBox.Show("Chưa kết nối đến server.", "Notice");
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Không thể gửi dữ liệu đến server.", "Notice");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (client == null || !client.IsConnected)
                {
                    client = new Client();
                    client.Connect();
                    button3.Enabled = true;
                    button2.Enabled = false;
                    button1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Đã có kết nối đến server.", "Notice");
                }
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Không thể kết nối server.", "Notice");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null)
                {
                    client.Disconnect();
                    button3.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled=true;
                }
                else
                    MessageBox.Show("Chưa kết nối đến server.", "Notice");
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Không thể đóng kết nối đến server.", "Notice");
            }
        }
        class Client
        {
            int serverport = 8080;
            IPAddress serverAddr = IPAddress.Parse("10.0.103.198");
            TcpClient client = new TcpClient();

            public bool IsConnected
            {
                get { return client.Connected; }
            }

            public void Connect()
            {
                client.Connect(serverAddr, serverport);
            }
            public void Send()
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello server\n");
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
            }
            public void Disconnect()
            {
                Byte[] data = System.Text.Encoding.UTF8.GetBytes("Quit\n");
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                stream.Close();
                client.Close();
            }
        }
    }
}
