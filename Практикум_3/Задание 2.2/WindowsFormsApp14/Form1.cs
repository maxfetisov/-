using System;
using System.Windows.Forms;

namespace WindowsFormsApp14
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
            for (double i = (double)a.Value; i <= (double)b.Value; i += (double)h.Value)
            {
                output.Text += "f(" + i + ") = " + f(i) + "\n";
            }
            output.Visible = true;
        }
        double f(double x)
        {
            if (x < 0) return 0;
            else if (x == 1) return 1;
            else return x * x + 1;
        }
    }
}
