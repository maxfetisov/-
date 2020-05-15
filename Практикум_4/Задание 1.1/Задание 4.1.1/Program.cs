using System;

namespace Задание_4._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите номер члена последовательности: ");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введены некорректные данные");
                Console.ReadKey();
                Console.ReadKey();
                return;
            }
            if (n > 0)
            {
                Console.WriteLine(n + " член последовательности равен " + f(n, 1, 5));
            }
            else
            {
                Console.WriteLine("Введен некорректный номер члена");
            }
            Console.ReadKey();
            Console.ReadKey();
        }
        static double f(int n, int i, double b)
        {
            if(n == 1)
            {
                return b;
            }
            if(i + 1 >= n) 
            {
                return b / (i * i + i + 1);
            }
            return f(n, i + 1, b / (i * i + i + 1));
        }
    }
}