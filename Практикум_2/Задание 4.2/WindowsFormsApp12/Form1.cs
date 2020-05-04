using System;
using System.Windows.Forms;

namespace WindowsFormsApp12
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
            output.Visible = true;
            for(int i = 4; i >= 0; i--)
            {
                for(int j = 0; j <= i; j++)
                {
                    output.Text += j + " ";
                }
                output.Text += "\n";
            }
            output.Text += "\n";
        }
    }
}