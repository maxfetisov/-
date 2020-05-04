using System;
using System.Windows.Forms;

namespace WindowsFormsApp11
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
            double A, B;
            A = Convert.ToDouble(aNumericUpDown.Value);
            B = Convert.ToDouble(bNumericUpDown.Value);
            if (A + 1 <= B)
            {
                int i = (int)A + 1;
                while (i <= B)
                {
                    if (i > 0)
                    {
                        output.Text += i + " ";
                    }
                    i++;
                }
                output.Text += "\n";
                i = (int)A + 1;
                do
                {
                    if (i > 0)
                    {
                        output.Text += i + " ";
                    }
                    i++;
                } while (i <= B);
                output.Text += "\n";
                for (i = (int)A + 1; i <= B; i++)
                {
                    if (i > 0)
                    {
                        output.Text += i + " ";
                    }
                }
            }
            else
            {
                output.Text = "Неверный ввод";
            }
            output.Visible = true;
        }
    }
}
