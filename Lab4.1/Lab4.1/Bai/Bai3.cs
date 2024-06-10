using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4._1.Bai
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            if (tburl.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập URL", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tburl.Focus();
                return;
            }
            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(tburl.Text);
            myClient.DownloadFile(tburl.Text.Trim(), tbstore.Text.Trim());
            MessageBox.Show("Tải thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            StreamReader streamReader = new StreamReader(response);
            rtbhtml.Text = streamReader.ReadToEnd();
            response.Close();
        }
    }
}
