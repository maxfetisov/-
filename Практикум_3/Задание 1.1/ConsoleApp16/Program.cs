using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            try
            {
                Console.Write("Введите число: ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неверный ввод");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Получившееся число: " + f(number));
            Console.ReadKey();
        }
        static int f(int x)
        {
            bool f = true;
            if(x < 0)
            {
                x *= -1;
                f = false;
            }
            string str = x.ToString();
            if (str.Length == 3)
            {
                char[] letters = str.ToCharArray();
                char buf = letters[0];
                letters[0] = letters[2];
                letters[2] = buf;
                str = string.Join("", letters);
            }
            if (f)
            {
                return Convert.ToInt32(str);
            }
            else
            {
                return Convert.ToInt32(str) * -1;
            }
        }
    }
}