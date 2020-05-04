using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, h;
            try
            {
                Console.Write("Введите начало интервала: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите конец интервала: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите шаг: ");
                h = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неверный ввод");
                Console.ReadKey();
                return;
            }
            if (h > 0)
            {
                for (double i = a; i <= b; i += h)
                {
                    Console.WriteLine("f({0}) = {1}", i, f(i));
                }
            }
            else
            {
                Console.WriteLine("Неккоректный шаг");
            }
            Console.ReadKey();
            Console.ReadKey();
        }
        static double f(double x)
        {
            if (x < 0) return 0;
            else if (x == 1) return 1;
            else return x * x + 1;
        }
    }
}