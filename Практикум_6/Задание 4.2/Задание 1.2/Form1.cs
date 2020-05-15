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
            int[][] arr = Input();
            int[] negArr = new int[arr.Length];
            if (random.Checked)
            {
                inOut.Text = "";
                for (int i = 0; i < arr.Length; i++)
                {
                    for(int j = 0; j < arr[i].Length; j++)
                    {
                        inOut.Text += arr[i][j] + " ";
                    }
                    inOut.Text += "\n";
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                negArr[i] = Neg(arr[i]);
                if (negArr[i] < 0)
                {
                    inOut.Text += "Нет отрицательных элементов ";
                }
                else
                {
                   inOut.Text += negArr[i] + " ";
                }
            }
        }
     
        int[][] Input()
        {
            int[][] arr;
            if (!random.Checked)
            {
                string[] lines = inOut.Text.Trim().Split('\n');
                arr = new int[lines.Length][];
                Random rand = new Random();
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] digits = lines[i].Trim().Split(' ');
                    arr[i] = new int[digits.Length];
                    for (int j = 0; j < digits.Length; j++)
                    {
                        try
                        {
                            arr[i][j] = Convert.ToInt32(digits[j]);
                        }
                        catch
                        {
                            arr[i][j] = rand.Next() % 10;
                        }
                    }                 
                }
            }
            else
            {
                arr = new int[(int)n.Value][];
                Random rand = new Random();
                inOut.Text += "\n";
                for (int i = 0; i < n.Value; i++)
                {
                    arr[i] = new int[(int)n.Value];
                    for (int j = 0; j < n.Value; j++)
                    {                      
                        arr[i][j] = rand.Next() % 10;
                    }
                }
            }
            return arr;
        }
        static int Neg(int[] arr)
        {
            int index = -1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] < 0)
                {
                    index = i;
                }
            }
            return index;
        }
    }
}