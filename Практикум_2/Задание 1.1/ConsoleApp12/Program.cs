using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            try
            {
                Console.Write("Введите x: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите y: ");
                y = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка");
                Console.ReadKey();
                return;
            }
            if (y > 0 && y < 70 && x > 0 && x < 70 && x > y)
                Console.WriteLine("Да");
            else if (y < 0 || y > 70 || x < 0 || x > 70 || x < y)
                Console.WriteLine("Нет");
            else
                Console.WriteLine("На гранцие");
            Console.ReadKey();
        }
    }
}