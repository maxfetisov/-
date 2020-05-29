using System;
using System.IO;
using System.Text;

namespace Задание_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("functions.txt", Encoding.Default);
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
                    Console.WriteLine($"{i + 1}) f({func[func.Length - 1]}): {functions[i].Calculate(Convert.ToDouble(func[func.Length - 1]))}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{i + 1}) {e.Message}");
                }             
            }
            Console.ReadKey();
        }
    }
}