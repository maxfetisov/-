using System;
using System.IO;
using System.Text;
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
            if(DialogResult.OK == fileDialog.ShowDialog())
            {
                output.Text = "";
                string[] lines = File.ReadAllLines(fileDialog.FileName, Encoding.Default);
                Function[] functions = new Function[lines.Length];
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] func = lines[i].Split(';');
                    try
                    {
                        switch (func[0])
                        {
                            case "line":
                                {
                                    if (func.Length != 4) throw new Exception("Некорректное число параметров");
                                    functions[i] = new Line(Convert.ToDouble(func[1]), Convert.ToDouble(func[2]));
                                    break;
                                }
                            case "kub":
                                {
                                    if (func.Length != 5) throw new Exception("Некорректное число параметров");
                                    functions[i] = new Kub(Convert.ToDouble(func[1]), Convert.ToDouble(func[2]), Convert.ToDouble(func[3]));
                                    break;
                                }
                            case "hyperbola":
                                {
                                    if (func.Length != 4) throw new Exception("Некорректное число параметров");
                                    functions[i] = new Hyperbola(Convert.ToDouble(func[1]), Convert.ToDouble(func[2]));
                                    break;
                                }
                            default:
                                {
                                    throw new Exception("Несуществующая функция");
                                }
                        }
                        output.Text += $"{i + 1}) f({func[func.Length - 1]}): {functions[i].Calculate(Convert.ToDouble(func[func.Length - 1]))}\n";
                    }
                    catch (Exception ex)
                    {
                        output.Text += $"{i + 1}) {ex.Message}\n";
                    }
                }
            }
        }
    }
}
