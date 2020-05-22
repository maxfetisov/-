using System;
using System.IO;

namespace Задание_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину: ");
            int n;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0) throw new Exception("Длина не может быть отрицательной");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }
            string[] lines = File.ReadAllLines("text.txt");
            Console.WriteLine("Подходящие строки: ");
            foreach(string item in lines)
            {
                if(item.Trim().Length < n)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();
        }
    }
}
