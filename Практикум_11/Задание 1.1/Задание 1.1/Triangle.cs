using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1._1
{
    class Triangle
    {
        private int a, b, c;
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Output()
        {
            Console.WriteLine("Сторона a: {0}, Сторона b: {1}, Сторона c: {2}", a, b, c);
        }
        public double Area()
        {
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public int Perimeter() => a + b + c;
        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }
        public bool Valid
        {
            get
            {
                if (a > 0 && b > 0 && c > 0)
                {
                    if (a + b > c && a + c > b && b + c > a)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
        }
    }
}
