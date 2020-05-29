using System;
using System.Windows.Forms;

namespace Задание_1._2
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
        public void Output(RichTextBox output)
        {
            output.Text += "Сторона a: " + a + ", Сторона b: " + b + ", Сторона c: " + c + "\n";
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
        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        {
                            return a;
                        }
                    case 1:
                        {
                            return b;
                        }
                    case 2:
                        {
                            return c;
                        }
                    default:
                        {
                            throw new Exception("Недопустимый индекс");
                        }
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        {
                            a = value;
                            break;
                        }
                    case 1:
                        {
                            b = value;
                            break;
                        }
                    case 2:
                        {
                            c = value;
                            break;
                        }
                    default:
                        {
                            throw new Exception("Недопустимый индекс");
                        }
                }
            }
        }
        public static Triangle operator ++(Triangle triangle)
        {
            triangle.a++;
            triangle.b++;
            triangle.c++;
            return triangle;
        }
        public static Triangle operator --(Triangle triangle)
        {
            triangle.a--;
            triangle.b--;
            triangle.c--;
            return triangle;
        }
        public static bool operator true(Triangle triangle)
        {
            if (triangle.a > 0 && triangle.b > 0 && triangle.c > 0)
            {
                if (triangle.a + triangle.b > triangle.c && triangle.a + triangle.c > triangle.b && triangle.b + triangle.c > triangle.a)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
        public static bool operator false(Triangle triangle)
        {
            if (triangle.a <= 0 || triangle.b <= 0 || triangle.c <= 0)
            {
                return true;
            }
            else
            {
                if (triangle.a + triangle.b <= triangle.c || triangle.a + triangle.c <= triangle.b || triangle.b + triangle.c <= triangle.a)
                    return true;
                else
                    return false;
            }
        }
        public static Triangle operator *(Triangle triangle, int scal)
        {
            triangle.a *= scal;
            triangle.b *= scal;
            triangle.c *= scal;
            return triangle;
        }
        public static explicit operator String(Triangle triangle)
        {
            return $"{triangle.a};{triangle.b};{triangle.c}";
        }
        public static explicit operator Triangle(string str)
        {
            return new Triangle(Convert.ToInt32(str.Split(';')[0]), Convert.ToInt32(str.Split(';')[1]), Convert.ToInt32(str.Split(';')[2]));
        }
    }
}
