using System;

namespace Задание_1._1
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
                Console.WriteLine("Некорректные данные");
                Console.ReadKey();
                Console.ReadKey();
                return;
            }
            if (h > 0)
            {
                for (double i = a; i < b; i += h)
                {
                    try
                    {
                        Console.WriteLine("f({0}) = {1}", i, f(i));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("f({0}) = {1}", i, e.Message);
                    }
                }
            }
            else
            {
                Console.WriteLine("Введен некорректный шаг");
            }
            Console.ReadKey();
            Console.ReadKey();
        }
        static double f(double x)
        {
            if (x <= 1)
            {
                throw new Exception("Функция не определена");
            }
            return Math.Log(x * x * x * x - 1) * Math.Log(1 + x);
        }
    }
}