using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class SendMail : Form
    {
        public SendMail()
        {
            InitializeComponent();
            attachments = new List<string>();
        }
        SMTP_Client smtpclient = new SMTP_Client();
        private List<string> attachments;

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in ofd.FileNames)
                {
                    attachments.Add(fileName);
                    listBox1.Items.Add(fileName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(textBox2.Text.Trim());
            mail.From = new MailAddress(textBox1.Text.Trim());
            mail.Subject = textBox4.Text.Trim();
            mail.Body = richTextBox1.Text;
            foreach (string attachment in attachments)
            {
                mail.Attachments.Add(new Attachment(attachment));
            }

            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.EnableSsl = true;
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential(smtpclient.Get_username(), smtpclient.Get_pass());
            try
            {
                client.Send(mail);
                MessageBox.Show("Gui thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SendMail_Load(object sender, EventArgs e)
        {
            smtpclient = Tag as SMTP_Client;
            textBox1.Text = smtpclient.Get_username();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedAttachment = listBox1.SelectedItem.ToString();
                attachments.Remove(selectedAttachment);
                listBox1.Items.Remove(selectedAttachment);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn file cần xóa");
            }
        }
    }
}
