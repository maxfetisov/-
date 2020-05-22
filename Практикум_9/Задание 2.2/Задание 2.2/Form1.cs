using System;
using System.IO;
using System.Windows.Forms;

namespace Задание_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            submit.Click += Submit_Click;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            output.Text = "";
            string[] lines = File.ReadAllLines("text.txt");
            foreach (string item in lines)
            {
                if (item.Trim().Length < n.Value)
                {
                    output.Text += item + "\n";
                }
            }
        }
    }
}
