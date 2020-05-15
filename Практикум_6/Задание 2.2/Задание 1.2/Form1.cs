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
            random.CheckedChanged += Random_CheckedChanged;
        }

        private void Random_CheckedChanged(object sender, EventArgs e)
        {
            inOut.ReadOnly = random.Checked;
            nLabel.Visible = n.Visible = random.Checked;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            int[] arr = Input();
            if (random.Checked)
            {
                inOut.Text = "";
                for (int i = 0; i < arr.Length; i++)
                {
                    inOut.Text += arr[i] + " ";
                }
            }
            int max = Max(arr);
            int min = Min(arr);
            int buf = arr[max];
            arr[max] = arr[min];
            arr[min] = buf;
            inOut.Text += "\nИтоговый массив:\n";
            for(int i = 0; i < arr.Length; i++)
            {
                inOut.Text += arr[i] + " ";
            }
        }

        int[] Input()
        {
            int[] arr;
            if (!random.Checked)
            {
                string[] lines;
                try
                {
                    lines = inOut.Text.Split('\n')[0].Trim().Split(' ');
                }
                catch
                {
                    return new int[0];
                }
                arr = new int[lines.Length];
                Random rand = new Random();
                for (int i = 0; i < lines.Length; i++)
                {
                    try
                    {
                        arr[i] = Convert.ToInt32(lines[i]);
                    }
                    catch
                    {
                        arr[i] = rand.Next() % 10;
                    }
                }
            }
            else
            {
                arr = new int[(int)n.Value];
                Random rand = new Random();
                for (int i = 0; i < n.Value; i++)
                {
                    arr[i] = rand.Next() % 10;
                }
            }
            return arr;
        }
        int Max(int[] arr)
        {
            int max = arr[arr.Length - 1];
            int index = arr.Length - 1;
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }
            return index;
        }
        int Min(int[] arr)
        {
            int min = arr[0];
            int index = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                }
            }
            return index;
        }
    }
}