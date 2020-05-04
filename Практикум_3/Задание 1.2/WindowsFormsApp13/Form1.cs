using System;
using System.Windows.Forms;

namespace WindowsFormsApp13
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
            int number = Convert.ToInt32(input.Value);
            output.Text = "Получившееся число: " + f(number);
            output.Visible = true;
        }
        int f(int x)
        {
            bool f = true;
            if(x < 0)
            {
                x *= -1;
                f = false;
            }
            string str = x.ToString();
            if (str.Length == 3)
            {
                char[] letters = str.ToCharArray();
                char buf = letters[0];
                letters[0] = letters[2];
                letters[2] = buf;
                str = string.Join("", letters);
            }
            if (f)
            {
                return Convert.ToInt32(str);
            }
            else
            {
                return Convert.ToInt32(str) * -1;
            }
        }
    }
}
