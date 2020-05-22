using System;
using System.IO;
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
            double[] arr = Input();
            if (random.Checked)
            {
                inOut.Text = "";
                for (int i = 0; i < arr.Length; i++)
                {
                    inOut.Text += arr[i] + " ";
                }
            }
            FileStream file = new FileStream("file.dat", FileMode.Create);
            BinaryWriter bin = new BinaryWriter(file);
            for (int i = 0; i < arr.Length; i++)
            {
                bin.Write(arr[i]);
            }
            bin.Close();
            file = new FileStream("file.dat", FileMode.Open);
            BinaryReader binR = new BinaryReader(file);
            long length = file.Length;
            double sum = 0, count = 0;
            for (long i = 0; i < length; i += 16)
            {
                file.Seek(i, SeekOrigin.Begin);
                sum += binR.ReadDouble();
                count++;
            }
            binR.Close();
            file.Close();
            sum /= count;
            inOut.Text += "\nСреднее арифметическое элементов на четных позициях: " + sum;
        }

        double[] Input()
        {
            double[] arr;
            if (!random.Checked)
            {
                string[] lines;
                try
                {
                    lines = inOut.Text.Split('\n')[0].Trim().Split(' ');
                }
                catch
                {
                    return new double[0];
                }
                arr = new double[lines.Length];
                Random rand = new Random();
                for (int i = 0; i < lines.Length; i++)
                {
                    try
                    {
                        arr[i] = Convert.ToDouble(lines[i]);
                    }
                    catch
                    {
                        arr[i] = rand.NextDouble() % 10;
                    }
                }
            }
            else
            {
                arr = new double[(int)n.Value];
                Random rand = new Random();
                for (int i = 0; i < n.Value; i++)
                {
                    arr[i] = rand.NextDouble() * 10;
                }
            }
            return arr;
        }
    }
}