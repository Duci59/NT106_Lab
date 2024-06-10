using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MailKit;
using MailKit.Net.Imap;
using MimeKit;

namespace Lab5
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        ImapClient client = new ImapClient();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string server = "imap.gmail.com";
                int port = Convert.ToInt32(993);
                string username = textBox1.Text;
                string password = textBox2.Text;
                client.Connect(server, port, true);
                client.Authenticate(username, password);
                button1.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                IMailFolder inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                for (int i = 0; i < 15; i++)
                {
                    MimeMessage message = inbox.GetMessage(i);
                    ListViewItem mail = new ListViewItem();
                    mail.Tag = message;
                    mail.Text = i.ToString();
                    mail.SubItems.Add(message.From.ToString());
                    mail.SubItems.Add(message.Subject);
                    mail.SubItems.Add(message.Date.ToString());
                    listView1.Items.Add(mail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            IMailFolder inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            for (int i = 0; i < 15; i++)
            {
                MimeMessage message = inbox.GetMessage(i);
                ListViewItem mail = new ListViewItem();
                mail.Tag = message;
                mail.Text = i.ToString();
                mail.SubItems.Add(message.From.ToString());
                mail.SubItems.Add(message.Subject);
                mail.SubItems.Add(message.Date.ToString());
                listView1.Items.Add(mail);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.Disconnect(true);
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            listView1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SMTP_Client client = new SMTP_Client("smtp.gmail.com", 587, textBox1.Text, textBox2.Text);
            SendMail bai4 = new SendMail();
            bai4.Tag = client;
            bai4.ShowDialog();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            Mail_detail item = new Mail_detail();
            item.Text = listView1.SelectedItems[0].SubItems[2].Text;
            item.Tag = listView1.SelectedItems[0].Tag;
            item.ShowDialog();
        }
    }
}
