using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai1_UDPServer : Form
    {
        private UdpClient udpClient;
        private bool isServerRunning;

        public Bai1_UDPServer()
        {
            InitializeComponent();
            isServerRunning = false;
        }

        private void ServerThread()
        {
            udpClient = new UdpClient(8080);

            try
            {
                while (isServerRunning)
                {
                    IPEndPoint ipEndpoint = new IPEndPoint(IPAddress.Any, 0);
                    byte[] receiveBytes = udpClient.Receive(ref ipEndpoint);
                    string returnData = Encoding.UTF8.GetString(receiveBytes);
                    string message = ipEndpoint.Address.ToString() + ":" + returnData.ToString();

                    // Sử dụng Invoke để cập nhật giao diện từ luồng khác
                    richTextBox1.Invoke((MethodInvoker)delegate {
                        richTextBox1.AppendText(message + "\n");
                    });
                }
            }
            catch (SocketException ex)
            {
                // Xử lý các ngoại lệ khi có lỗi kết nối
                MessageBox.Show("SocketException: " + ex.Message);
            }
            finally
            {
                // Đảm bảo rằng UdpClient đã được giải phóng
                udpClient.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isServerRunning)
            {
                isServerRunning = true;
                button1.Enabled = false;

                // Bắt đầu luồng máy chủ
                Thread serverThread = new Thread(ServerThread);
                serverThread.Start();
            }
        }
    }
}
