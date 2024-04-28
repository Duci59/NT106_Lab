using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
                Environment.SpecialFolder root = dialog.RootFolder;
            }
            DirectoryInfo di = new DirectoryInfo(dialog.SelectedPath);
            FileInfo[] fiarr = di.GetFiles();
            foreach (FileInfo fi in fiarr)
            {
                ListViewItem item = new ListViewItem(fi.Name);
                item.SubItems.Add(fi.Length.ToString());
                item.SubItems.Add(fi.Extension.ToString());
                item.SubItems.Add(fi.CreationTime.ToString());
                listView1.Items.Add(item);
            }
        }
    }
}
