using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину окружности: ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Радиус окружности равен: " + l / (2 * Math.PI));
            Console.ReadKey();
        }
    }
}
