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
            output.Text += "\n";
            for (double i = (double)a.Value; i <= (double)b.Value; i += (double)h.Value)
            {
                double y;
                f(i, out y);
                output.Text += "f(" + i + ") = " + y + "\n";
            }
            output.Visible = true;
        }
        double f(double x)
        {
            if (x < 0) 
                return 0;
            else if (x == 1) 
                return 1;
            else 
                return x * x + 1;
        }
        static void f(double x, out double y)
        {
            if (x < 0)
                y = 0;
            else if (x == 1)
                y = 1;
            else
                y = x * x + 1;
        }
    }
}
