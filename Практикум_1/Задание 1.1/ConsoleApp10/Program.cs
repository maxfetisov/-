using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            double l;
            Console.Write("Введите длину окружности: ");
            try
            {
                l = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введены некорректные данные");
                Console.ReadKey();
                return;
            }
            if (l > 0)
            {
                Console.WriteLine("Радиус окружности равен: " + l / (2 * Math.PI));
            }
            else
            {
                Console.WriteLine("Введены некорректные данные");
            }
            Console.ReadKey();
        }
    }
}
