using System;
using System.Windows.Forms;

namespace WindowsFormsApp7
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
            outputLabel.Text = "Радиус окружности равен: " + Convert.ToDouble(l.Value)/(2 * Math.PI);
            outputLabel.Visible = true;
        }
    }
}
