using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Введите трехзначное число: ");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введены некорректные данные");
                Console.ReadKey();
                return;
            }
            if (number < 0)
                number *= -1;
            string strNumber = number.ToString();
            if (strNumber.Length == 3)
            {
                if (Convert.ToInt32(strNumber[0].ToString()) > Convert.ToInt32(strNumber[2].ToString()))
                    Console.WriteLine("Первая цифра больше");
                else if (Convert.ToInt32(strNumber[0].ToString()) < Convert.ToInt32(strNumber[2].ToString()))
                    Console.WriteLine("Последняя цифра больше");
                else
                    Console.WriteLine("Первая и последняя цифры равны");
            }
            else
            {
                Console.WriteLine("Введено некорректное число");
            }
            Console.ReadKey();
        }
    }
}
