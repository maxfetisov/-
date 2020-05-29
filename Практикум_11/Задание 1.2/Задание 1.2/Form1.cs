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
            Triangle triangle = new Triangle((int)a.Value, (int)b.Value, (int)c.Value);
            triangle.Output(output);
            if (triangle.Valid)
            {
                output.Text += "Площадь: " + triangle.Area() + ", Периметр: " + triangle.Perimeter() + "\n";
            }
            else
            {
                output.Text += "Треугольник не существует\n";
            }
        }
    }
}
