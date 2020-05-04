using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B;
            try
            {
                Console.Write("Введите A: ");
                A = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите B: ");
                B = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неверный ввод");
                Console.ReadKey();
                return;
            }
            if (A + 1 <= B)
            {
                int i = (int)A + 1;
                while (i <= B)
                {
                    if (i > 0)
                    {
                        Console.Write(i + " ");
                    }
                    i++;
                }
                Console.WriteLine();
                i = (int)A + 1;
                do
                {
                    if (i > 0)
                    {
                        Console.Write(i + " ");
                    }
                    i++;
                } while (i <= B);
                Console.WriteLine();
                for (i = (int)A + 1; i <= B; i++)
                {
                    if (i > 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("A больше B");
            }
            Console.ReadKey();
        }
    }
}
