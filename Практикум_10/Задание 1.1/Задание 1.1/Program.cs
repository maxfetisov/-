using System;
using System.IO;

namespace Задание_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Directory.Exists("C:\\temp"))
            {
                if (Directory.GetDirectories("C:\\temp").Length == 0)
                {
                    Directory.CreateDirectory("C:\\temp\\К1");
                    Directory.CreateDirectory("C:\\temp\\К2");
                    File.Create("C:\\temp\\К1\\t1.txt").Close();
                    File.Create("C:\\temp\\К1\\t2.txt").Close();
                    File.WriteAllText("C:\\temp\\К1\\t1.txt", "Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
                    File.WriteAllText("C:\\temp\\К1\\t2.txt", "Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
                    File.Create("C:\\temp\\К2\\t3.txt").Close();
                    File.WriteAllText("C:\\temp\\К2\\t3.txt", File.ReadAllText("C:\\temp\\К1\\t1.txt") + "\n" + File.ReadAllText("C:\\temp\\К1\\t2.txt"));
                    FileInfo t1 = new FileInfo("C:\\temp\\К1\\t1.txt");
                    Console.WriteLine("Полное имя: {0}, Размер: {1}, Последнее время записи: {2}", t1.FullName, t1.Length, t1.LastWriteTime);
                    FileInfo t2 = new FileInfo("C:\\temp\\К1\\t2.txt");
                    Console.WriteLine("Полное имя: {0}, Размер: {1}, Последнее время записи: {2}", t2.FullName, t2.Length, t2.LastWriteTime);
                    FileInfo t3 = new FileInfo("C:\\temp\\К2\\t3.txt");
                    Console.WriteLine("Полное имя: {0}, Размер: {1}, Последнее время записи: {2}", t3.FullName, t3.Length, t3.LastWriteTime);
                    t2.MoveTo("C:\\temp\\К2\\t2.txt");
                    t1.CopyTo("C:\\temp\\К2\\t1.txt");
                    Directory.Move("C:\\temp\\К2", "C:\\temp\\All");
                    Directory.Delete("C:\\temp\\К1", true);
                    string[] f = Directory.GetFiles("C:\\temp\\All");
                    Console.WriteLine("\nФайлы папки All: ");
                    foreach(string item in f)
                    {
                        FileInfo t = new FileInfo(item);
                        Console.WriteLine("Полное имя: {0}, Размер: {1}, Последнее время записи: {2}", t.FullName, t.Length, t.LastWriteTime);
                    }
                }
                else
                {
                    Console.WriteLine("Папка temp не пуста");
                }
            }
            else
            {
                Console.WriteLine("Папки temp не существует");
            }
            Console.ReadKey();
        }
    }
}