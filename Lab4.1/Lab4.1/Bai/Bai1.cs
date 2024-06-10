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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private string GetHTML(string URL)
        {
            //Create a request for URL
            WebRequest request = WebRequest.Create(URL);
            //Get the response 
            WebResponse response = request.GetResponse();
            //Get the stream containing content return by the server
            Stream datastream = response.GetResponseStream();
            //Open the stream using a StreamReader for easy access
            StreamReader reader = new StreamReader(datastream);
            //Read the content
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            return responseFromServer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbhtml.Text = GetHTML(tburl.Text);
        }

        private void tburl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
