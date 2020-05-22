using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            String str = input.Text;
            char[] s = { ' ' };
            char[] t = { '.', ',', '\'', '\"', ';', ':', '?', '!', '%', '\\', '|', '*', '$', '#', '@', '+', '-', '№', '^', '(', ')', '&' };
            String[] lines = str.Split(s, StringSplitOptions.RemoveEmptyEntries);
            Regex pattern = new Regex("^(0?[1-9]|[12][0-9]|3[01])[.](0?[1-9]|1[0-2])[.]2020$");
            output.Text = "Даты сообщения:\n";
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Trim(t);
                if (pattern.IsMatch(lines[i]))
                {
                    output.Text += lines[i] + "\n";
                }
            }
        }
    }
}
