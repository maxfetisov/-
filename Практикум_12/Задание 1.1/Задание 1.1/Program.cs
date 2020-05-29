using System;

namespace Задание_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle;
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            try
            {
                triangle = (Triangle)str;           
            }
            catch
            {
                Console.WriteLine("Введена некорректная строка");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Тругольник 1:");
            triangle.Output();
            if (triangle)
            {
                triangle++;
                triangle.Output();
                triangle--;
                triangle.Output();
                triangle *= 3;
                triangle.Output();
                Console.WriteLine("Треугольник в строке: " + (string)triangle);
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }
            triangle[0] = 4;
            triangle[1] = 7;
            triangle[2] = 5;
            Console.WriteLine("Тругольник 2:");
            triangle.Output();
            if (triangle)
            {
                triangle++;
                triangle.Output();
                triangle--;
                triangle.Output();
                triangle *= 3;
                triangle.Output();
                Console.WriteLine("Треугольник в строке: " + (string)triangle);
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }
            triangle[0] = 1;
            triangle[1] = 7;
            triangle[2] = 1;
            Console.WriteLine("Тругольник 3:");
            triangle.Output();
            if (triangle)
            {
                triangle++;
                triangle.Output();
                triangle--;
                triangle.Output();
                triangle *= 3;
                triangle.Output();
                Console.WriteLine("Треугольник в строке: " + (string)triangle);
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }
            Console.ReadKey();
        }
    }
}
