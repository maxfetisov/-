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
            String str = input.Text;
            char[] s = { ' ' };
            char[] t = { '.', ',', '\'', '\"', ';', ':', '?', '!', '%', '\\', '|', '*', '$', '#', '@', '+', '-', '№', '^', '(', ')', '&' };
            String[] lines = str.Split(s, StringSplitOptions.RemoveEmptyEntries);
            int min;
            String result;
            try
            {
                min = lines[0].Length;
                result = lines[0];
            }
            catch
            {
                output.Text = "Введена пустая строка";
                return;
            }
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Trim(t);
                if (lines[i].Length < min)
                {
                    if (!string.IsNullOrEmpty(lines[i]))
                    {
                        min = lines[i].Length;
                        result = lines[i];
                    }
                }
            }
            output.Text = "Самое короткое слово в сообщении: " + result;
        }
    }
}
