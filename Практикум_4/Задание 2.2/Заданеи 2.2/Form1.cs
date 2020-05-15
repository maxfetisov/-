using System;
using System.Windows.Forms;

namespace Заданеи_2._2
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
            f((int)num.Value);
            output.Visible = true;
        }
        void f(int n, int s = 0)
        {
            if (n > 0)
            {
                for (int i = 0; i < s; i++)
                    output.Text += " ";
                for (int i = 0; i < n; i++)
                    output.Text += "*";
                output.Text += "\n";
                f(n - 1, s + 1);
            }
        }
    }
}
