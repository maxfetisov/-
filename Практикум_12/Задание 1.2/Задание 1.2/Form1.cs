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
            output.Text = "";
            Triangle triangle;
            try
            {
                triangle = (Triangle)str.Text;
            }
            catch
            {
                output.Text = "Некорректный ввод данных";
                return;
            }
            triangle.Output(output);
            if (triangle)
            {
                triangle++;
                output.Text += $"Сторона a: {triangle[0]}, Сторона b: {triangle[1]}, Сторона c: {triangle[2]}\n";
                triangle--;
                triangle.Output(output);
                triangle *= (int)scal.Value;
                triangle.Output(output);
                output.Text += "Треугольник в строке: " + (string)triangle;
            }
            else
            {
                output.Text += "Треугольник не существует";
            }
        }
    }
}
