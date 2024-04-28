using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3.Bài_3
{
    public partial class Bai3_TCPServer : Form
    {
        public Bai3_TCPServer()
        {
            InitializeComponent();
        }
        void StartUnsafeThread()
        {
            int bytesRecieved = 0;
            byte[] recv = new byte[1];
            Socket clientSocket;
            Socket listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                );
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("10.0.103.198"), 8080);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);
            clientSocket = listenerSocket.Accept();
            richTextBox1.Text += "New client connected\n";
            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesRecieved = clientSocket.Receive(recv);
                    text += Encoding.UTF8.GetString(recv);
                }
                while (text[text.Length - 1] == '\n');
                richTextBox1.Text += text;
            }
            listenerSocket.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }
    }
}
