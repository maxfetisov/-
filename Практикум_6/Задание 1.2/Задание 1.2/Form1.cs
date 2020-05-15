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
            array1.CheckedChanged += Array1_CheckedChanged;
        }

        private void Array1_CheckedChanged(object sender, EventArgs e)
        {
            if (array2.Checked)
            {
                if (random.Checked)
                {
                    mLabel.Visible = true;
                    m.Visible = true;
                }
            }
            else
            {
                if (random.Checked)
                {
                    mLabel.Visible = false;
                    m.Visible = false;
                }
            }
        }

        private void Random_CheckedChanged(object sender, EventArgs e)
        {
            inOut.ReadOnly = random.Checked;
            mLabel.Visible = m.Visible = random.Checked && array2.Checked;
            nLabel.Visible = n.Visible = random.Checked;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (array1.Checked)
            {
                int[] arr = Input1();
                if (random.Checked)
                {
                    inOut.Text = "";
                    for(int i = 0; i < arr.Length; i++)
                    {
                        inOut.Text += arr[i] + " ";
                    }
                }
                Find(arr, (int)k.Value);
            }
            else
            {
                int[][] arr = Input2();
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
                for(int i = 0; i < arr.Length; i++)
                {
                    Find(arr[i], (int)k.Value);
                }
            }
        }

        int[] Input1()
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
        
        int[][] Input2()
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
                    arr[i] = new int[(int)m.Value];
                    for (int j = 0; j < m.Value; j++)
                    {                      
                        arr[i][j] = rand.Next() % 10;
                    }
                }
            }
            return arr;
        }
        void Find(int[] arr, int k)
        {
            inOut.Text += "\n";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > k)
                {
                    inOut.Text += i + " ";
                }
            }
        }
    }
}