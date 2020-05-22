using System;

namespace Задание_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            String str = Console.ReadLine();
            char[] s = { ' ' };
            char[] t = { '.', ',', '\'', '\"', ';', ':', '?', '!', '%', '\\', '|', '*', '$', '#', '@', '+', '-', '№', '^', '(', ')', '&' };
            String[] lines = str.Split(s, StringSplitOptions.RemoveEmptyEntries);
            int min;
            String result;
            try
            {
                min = lines[0].Length;
                result = lines[0];
            }
            catch
            {
                Console.WriteLine("Введена пустая строка");
                Console.ReadKey();
                return;
            }
            for(int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Trim(t);
                if (lines[i].Length < min)
                {
                    if (!string.IsNullOrEmpty(lines[i]))
                    {
                        min = lines[i].Length;
                        result = lines[i];
                    }
                }
            }
            Console.WriteLine("Самое короткое слово в сообщении: " + result);
            Console.ReadKey();
        }
    }
}
