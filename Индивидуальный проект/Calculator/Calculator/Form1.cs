using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            submit.Click += Submit_Click;
            reset.Click += Reset_Click;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            gender.SelectedItem = null;
            year.Value = year.Minimum;
            warYear.Value = warYear.Minimum;
            warMonth.Value = warMonth.Minimum;
            warDays.Value = warDays.Minimum;
            child.Value = child.Minimum;
            stash.Value = stash.Minimum;
            money.Value = money.Minimum;
            coef.Text = "";
            pensionOutput.Text = "";
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if(gender.SelectedItem != null)
            {
                Pension pension = new Pension(gender.SelectedItem.ToString(), (uint)year.Value, (uint)(warYear.Value * 365 + warMonth.Value * 30 + warDays.Value), (uint)child.Value, (uint)stash.Value, money.Value);
                if (pension.IsValid())
                {
                    coef.Text = pension.GetCoefficient().ToString();
                    pensionOutput.Text = pension.GetPension().ToString();
                }
                else
                {
                    MessageBox.Show("Введены некорректные данные");
                }
            }
            else
            {
                MessageBox.Show("не указан пол");
            }
        }
    }
}
