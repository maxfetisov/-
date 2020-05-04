using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
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
