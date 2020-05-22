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
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("C:\\temp"))
            {
                if (Directory.GetDirectories("C:\\temp").Length == 0)
                {
                    output.Text = "";
                    Directory.CreateDirectory("C:\\temp\\К1");
                    Directory.CreateDirectory("C:\\temp\\К2");
                    File.Create("C:\\temp\\К1\\t1.txt").Close();
                    File.Create("C:\\temp\\К1\\t2.txt").Close();
                    File.WriteAllText("C:\\temp\\К1\\t1.txt", "Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
                    File.WriteAllText("C:\\temp\\К1\\t2.txt", "Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
                    File.Create("C:\\temp\\К2\\t3.txt").Close();
                    File.WriteAllText("C:\\temp\\К2\\t3.txt", File.ReadAllText("C:\\temp\\К1\\t1.txt") + "\n" + File.ReadAllText("C:\\temp\\К1\\t2.txt"));
                    FileInfo t1 = new FileInfo("C:\\temp\\К1\\t1.txt");
                    output.Text += "Полное имя: " + t1.FullName + ", Размер: " + t1.Length + ", Последнее время записи: " + t1.LastWriteTime + "\n";
                    FileInfo t2 = new FileInfo("C:\\temp\\К1\\t2.txt");
                    output.Text += "Полное имя: " + t2.FullName + ", Размер: " + t2.Length + ", Последнее время записи: " + t2.LastWriteTime + "\n";
                    FileInfo t3 = new FileInfo("C:\\temp\\К2\\t3.txt");
                    output.Text += "Полное имя: " + t3.FullName + ", Размер: " + t3.Length + ", Последнее время записи: " + t3.LastWriteTime + "\n";
                    t2.MoveTo("C:\\temp\\К2\\t2.txt");
                    t1.CopyTo("C:\\temp\\К2\\t1.txt");
                    Directory.Move("C:\\temp\\К2", "C:\\temp\\All");
                    Directory.Delete("C:\\temp\\К1", true);
                    string[] f = Directory.GetFiles("C:\\temp\\All");
                    output.Text += "\nФайлы папки All:\n";
                    foreach (string item in f)
                    {
                        FileInfo t = new FileInfo(item);
                        output.Text += "Полное имя: " + t.FullName + ", Размер: " + t.Length + ", Последнее время записи: " + t.LastWriteTime + "\n";
                    }
                }
                else
                {
                    output.Text = "Папка temp не пуста";
                }
            }
            else
            {
                output.Text = "Папки temp не существует";
            }
        }
    }
}
