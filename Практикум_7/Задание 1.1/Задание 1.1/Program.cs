using System;

namespace Задание_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.Write("Введите строку: ");
            String str = Console.ReadLine();
            for(int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    count++;
            }
            Console.WriteLine("Количество цифр в тексте: " + count);
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
