using MailKit;
using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Security;

namespace Lab5
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new ImapClient();
            client.ServerCertificateValidationCallback = (s, c, h, e_ssl) => true;
            try
            {
                client.Connect("127.0.0.1", 993, true);
                try
                {
                    client.Authenticate(textBox1.Text, textBox2.Text);
                }
                catch (AuthenticationException)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                }
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                listView1.Clear();
                listView1.Columns.Add("Email", 350);
                listView1.Columns.Add("From", 250);
                listView1.Columns.Add("Thời gian", 250);
                listView1.View = View.Details;
                label4.Text = inbox.Count.ToString();
                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    ListViewItem name = new ListViewItem(message.Subject);

                    /*ListViewItem.ListViewSubItem from = new
                    ListViewItem.ListViewSubItem(name, message.From.ToString());*/
                    name.SubItems.Add(message.From.ToString());

                    /*ListViewItem.ListViewSubItem date = new
                    ListViewItem.ListViewSubItem(name, message.Date.Date.ToString());*/
                    name.SubItems.Add(message.Date.ToString());

                    listView1.Items.Add(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            client.Disconnect(true);

        }
    }
}
