using MimeKit;
using System;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Mail_detail : Form
    {
        public Mail_detail()
        {
            InitializeComponent();
        }


        private async void Mail_detail_Load(object sender, EventArgs e)
        {
            MimeMessage message = Tag as MimeMessage;

            if (message == null)
            {
                MessageBox.Show("Error: The email message is null.");
                return;
            }

            textBox1.Text = message.From.ToString();
            Text = message.Subject;
            textBox2.Text = message.To.ToString();
            textBox3.Text = message.Subject;

            try
            {
                await webView21.EnsureCoreWebView2Async(null);

                if (string.IsNullOrEmpty(message.HtmlBody))
                {
                    MessageBox.Show("The HTML body of the email is empty.");
                }
                else
                {
                    webView21.NavigateToString(message.HtmlBody);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing WebView2: {ex.Message}");
            }
        }
    }
}
