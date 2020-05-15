using System;
using System.Windows.Forms;

namespace Задание_2
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
            for (double i = (double)a.Value; i < (double)b.Value; i += (double)h.Value)
            {
                try
                {
                    output.Text += "f(" + i + ") = " + f(i) + "\n";
                }
                catch (Exception ex)
                {
                    output.Text += "f(" + i + ") = " + ex.Message + "\n";
                }
            }
        }
        static double f(double x)
        {
            if (x <= 1)
            {
                throw new Exception("Функция не определена");
            }
            return Math.Log(x * x * x * x - 1) * Math.Log(1 + x);
        }
    }
}
