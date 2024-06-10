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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Specialized;
using System.Security.Policy;
using System.Collections;

namespace Lab4.Bai
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnpost_Click(object sender, EventArgs e)
        {
            byte[] bytearray = Encoding.UTF8.GetBytes(textBox1.Text);

            WebRequest request = WebRequest.Create(tburl.Text);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = bytearray.Length;
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(bytearray, 0, bytearray.Length);
            }

            using (WebResponse response = request.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        string responseFromServer = reader.ReadToEnd();
                        rtbhtml.Text = responseFromServer;
                    }
                }
            }
        }
    }
}
