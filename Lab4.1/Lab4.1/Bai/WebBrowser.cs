using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using Microsoft.VisualBasic;

namespace Lab4._1.Bai
{
    public partial class WebBrowser : Form
    {   // Khai báo đối tượng WebBrowser
        System.Windows.Forms.WebBrowser webBrowser;
        // Danh sách các liên kết đã truy cập
        List<string> links = new List<string>();
        // Số lượng liên kết đã truy cập
        int countlinks = 0;
        public WebBrowser()
        {
            InitializeComponent();
            // Tạo một đối tượng WebBrowser mới thiết lập chiều dài chiều rộng hiển thị webBrowser 
            webBrowser = new System.Windows.Forms.WebBrowser();
            webBrowser.Height = 608;
            webBrowser.Width = 1299;
            // Thêm đối tượng WebBrowser vào Panel pnWeb
            pnWeb.Controls.Add(webBrowser);
            // Thêm đối tượng WebBrowser vào Panel pnWeb
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAddress.Text))
                // Điều hướng đến địa chỉ URL được nhập
                webBrowser.Navigate(tbAddress.Text);
            // Lưu trữ liên kết đã truy cập vào danh sách
            links.Add(tbAddress.Text);
            countlinks++;
        }

        private void btnDowHTML_Click(object sender, EventArgs e)
        {
            string url = tbAddress.Text;
            string folderPath = tbPath.Text;

            // Kiểm tra URL và đường dẫn hợp lệ
            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(folderPath))
            {
                MessageBox.Show("Please enter both URL and folder path.");
                return;
            }

            // Kiểm tra xem thư mục có tồn tại không
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("The folder path does not exist. Please check and try again.");
                return;
            }

            try
            {
                DownloadWebsiteSource(url, folderPath);
                MessageBox.Show("Download completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void DownloadWebsiteSource(string url, string folderPath)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load(url);

            // Save the HTML source
            string source = document.DocumentNode.OuterHtml;
            string fileName = Path.GetFileName(url);
            string filePath = Path.Combine(folderPath, fileName + ".html");
            File.WriteAllText(filePath, source);

            // Download images and related files
            DownloadSource(document.DocumentNode, folderPath);
        }


        void DownloadSource(HtmlAgilityPack.HtmlNode node, string folderPath)
        {
            if (node.NodeType == HtmlAgilityPack.HtmlNodeType.Element)
            {
                if (node.Name == "img" || node.Name == "link" || node.Name == "script")
                {
                    string sourceUrl = node.GetAttributeValue("src", null) ?? node.GetAttributeValue("href", null);

                    if (!string.IsNullOrEmpty(sourceUrl))
                    {
                        // Xử lý đường dẫn tương đối
                        Uri baseUri = new Uri(sourceUrl);
                        Uri absoluteUri = new Uri(baseUri, sourceUrl);

                        // Lấy tên tệp tin từ URL
                        string fileName = Path.GetFileName(absoluteUri.LocalPath);
                        string filePath = Path.Combine(folderPath, fileName);

                        // Tải và lưu tệp tin
                        using (WebClient client = new WebClient())
                        {
                            try
                            {
                                client.DownloadFile(absoluteUri, filePath);
                            }
                            catch (Exception ex)
                            {
                                // Ghi log lỗi và tiếp tục
                                Console.WriteLine($"Error downloading {sourceUrl}: {ex.Message}");
                            }
                        }
                    }
                }
            }
            foreach (HtmlAgilityPack.HtmlNode childNode in node.ChildNodes)
            {
                DownloadSource(childNode, folderPath);
            }
        }

        private void btnViewSource_Click(object sender, EventArgs e)
        {
            string url = tbAddress.Text;
            // Tải nguồn của trang web
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load(url);
            // Lưu trữ nguồn của trang web vào biến source
            string source = document.DocumentNode.OuterHtml;
            // Hiển thị nguồn trong một cửa sổ Resource
            using (Resource viewSourceForm = new Resource())
            {
                viewSourceForm.SetSource(source);
                viewSourceForm.ShowDialog();
            }
        }
    }
}
