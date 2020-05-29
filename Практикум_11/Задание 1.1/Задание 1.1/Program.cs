using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(-4, -7, -5);
            Console.WriteLine("Тругольник 1:");
            triangle.Output();
            if (triangle.Valid)
            {
                Console.WriteLine("Площадь: {0}, Периметр: {1}", triangle.Area(), triangle.Perimeter());
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }
            triangle.A = 12;
            triangle.B = 4;
            triangle.C = 3;
            Console.WriteLine("Тругольник 2:");
            triangle.Output();
            if (triangle.Valid)
            {
                Console.WriteLine("Площадь: {0}, Периметр: {1}", triangle.Area(), triangle.Perimeter());
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }
            Console.WriteLine("Тругольник 3:");
            triangle.Output();
            Console.WriteLine("Площадь: {0}, Периметр: {1}", triangle.Area(), triangle.Perimeter());
            triangle.A = 2;
            triangle.B = 4;
            triangle.C = 3;
            Console.WriteLine("Тругольник 4:");
            triangle.Output();
            if (triangle.Valid)
            {
                Console.WriteLine("Площадь: {0}, Периметр: {1}", triangle.Area(), triangle.Perimeter());
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }
            Console.ReadKey();
        }
    }
}
