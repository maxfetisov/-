using System;
using System.Windows.Forms;

namespace WindowsFormsApp10
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
            string day = input.Text.ToLower().Trim();
            switch (day)
            {
                case "1":
                case "понедельник":
                    {
                        output.Text = "Расписание:\n12.00\n14.00\n20.00";
                        break;
                    }
                case "2":
                case "вторник":
                    {
                        output.Text = "Расписание:\n11.00\n14.00\n17.00";
                        break;
                    }
                case "3":
                case "среда":
                    {
                        output.Text = "Расписание:\n10.00\n12.00\n19.00";
                        break;
                    }
                case "4":
                case "четверг":
                    {
                        output.Text = "Расписание:\n13.00\n15.00\n16.00";
                        break;
                    }
                case "5":
                case "пятница":
                    {
                        output.Text = "Расписание:\n8.00\n9.00\n13.00";
                        break;
                    }
                case "6":
                case "суббота":
                    {
                        output.Text = "Расписание:\nвыходной";
                        break;
                    }
                case "7":
                case "воскресенье":
                    {
                        output.Text = "Расписание:\nвыходной";
                        break;
                    }
                default:
                    {
                        output.Text = "Введен не день недели";
                        break;
                    }
            }
            output.Visible = true;
        }
    }
}