using System;
using System.Text.RegularExpressions;

namespace Задание_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сообщение: ");
            String str = Console.ReadLine();
            char[] s = { ' ' };
            char[] t = { '.', ',', '\'', '\"', ';', ':', '?', '!', '%', '\\', '|', '*', '$', '#', '@', '+', '-', '№', '^', '(', ')', '&' };
            String[] lines = str.Split(s, StringSplitOptions.RemoveEmptyEntries);
            Regex pattern = new Regex("^(0?[1-9]|[12][0-9]|3[01])[.](0?[1-9]|1[0-2])[.]2020$");
            Console.WriteLine("Даты сообщения:");
            for(int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Trim(t);
                if (pattern.IsMatch(lines[i]))
                {
                    Console.WriteLine(lines[i]);
                }
            }
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
