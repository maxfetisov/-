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
            int count = 0;
            String str = input.Text;
            for(int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    count++;
            }
            output.Text = "Количество цифр: " + count;
        }
    }
}
