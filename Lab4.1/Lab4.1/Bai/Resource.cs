﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4._1.Bai
{
    public partial class Resource : Form
    {
        public Resource()
        {
            InitializeComponent();
        }

        private void Resource_Load(object sender, EventArgs e)
        {

        }
        public void SetSource(string source)
        {
            tbViewSource.Text = source;
        }
    }
}
