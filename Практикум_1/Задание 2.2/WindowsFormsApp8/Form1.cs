using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
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
            string strNumber = num.Value.ToString();
            if (Convert.ToInt32(strNumber[0].ToString()) > Convert.ToInt32(strNumber[2].ToString()))
                output.Text = "Первая цифра больше";
            else if (Convert.ToInt32(strNumber[0].ToString()) < Convert.ToInt32(strNumber[2].ToString()))
                output.Text = "Последняя цифра больше";
            else
                output.Text = "Первая и последняя цифры равны";
            output.Visible = true;
        }
    }
}
