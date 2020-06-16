﻿using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Урок_13
{
    public partial class Form1 : Form
    {
        InstalledFontCollection fontList = new InstalledFontCollection();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily ff in fontList.Families)
            {
                listBox1.Items.Add(ff.Name);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(listBox1.Text, 20);
        }
    }
}
