using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp9
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
            float x, y;
            x = (float)xNumericUpDown.Value;
            y = (float)yNumericUpDown.Value;
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Point[] points = { new Point(pictureBox.Width / 2 + 0, pictureBox.Height / 2 - 0), new Point(pictureBox.Width / 2 + 70, pictureBox.Height / 2 - 0), new Point(pictureBox.Width / 2 + 70, pictureBox.Height / 2 - 70) };
            graphics.FillPolygon(Brushes.Aqua, points);
            graphics.DrawLine(new Pen(Color.Black, 2), points[0], points[1]);
            graphics.DrawLine(new Pen(Color.Black, 2), points[1], points[2]);
            graphics.DrawLine(new Pen(Color.Black, 2), points[0], points[2]);
            graphics.FillEllipse(Brushes.Red, pictureBox.Width / 2 + x - 2, pictureBox.Height / 2 - y - 2, 4, 4);
            pictureBox.Image = bitmap;
            if (x > 0 && x < 70 && y > 0 && y < 70 && x > y)
                output.Text = "Да";
            else if (x < 0 || x > 70 || y < 0 || y > 70 || x < y)
                output.Text = "Нет";
            else
                output.Text = "На границе";
            output.Visible = true;
        }
    }
}