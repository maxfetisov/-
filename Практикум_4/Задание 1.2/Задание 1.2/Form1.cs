using System;
using System.Windows.Forms;

namespace Задание_1._2
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
            output.Text = f((int)num.Value, 0, 5).ToString();
        }
        double f(int n, int i, double b)
        {
            if (n == 1)
            {
                return b;
            }
            if (i + 1 >= n)
            {
                return b / (i * i + i + 1);
            }
            return f(n, i + 1, b / (i * i + i + 1));
        }
    }
}
