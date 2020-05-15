using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
            int norm = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                norm += arr[i][Max(arr[i])];
            }
            inOut.Text += "\nНорма матрицы равна " + norm;
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
        static int Max(int[] arr)
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
    }
}