using System;

namespace Задание_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите количество звездочек: ");
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
            if (n >= 0)
            {
                f(n);
            }
            else
            {
                Console.WriteLine("Введено некорректное число звездочек");
            }
            Console.ReadKey();
            Console.ReadKey();
        }
        static void f(int n, int s = 0)
        {
            if (n > 0)
            {
                for (int i = 0; i < s; i++)
                    Console.Write(" ");
                for (int i = 0; i < n; i++)
                    Console.Write("*");
                Console.WriteLine();
                f(n - 1, s + 1);
            }
        }
    }
}
