using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите день недели: ");
            string day = Console.ReadLine().ToLower().Trim();
            switch (day) 
            {
                case "1":
                case "понедельник":
                    {
                        Console.WriteLine("Расписание: 12.00, 14.00, 20.00");
                        break;
                    }
                case "2":
                case "вторник":
                    {
                        Console.WriteLine("Расписание: 11.00, 14.00, 17.00");
                        break;
                    }
                case "3":
                case "среда":
                    {
                        Console.WriteLine("Расписание: 10.00, 12.00, 19.00");
                        break;
                    }
                case "4":
                case "четверг":
                    {
                        Console.WriteLine("Расписание: 13.00, 15.00, 26.00");
                        break;
                    }
                case "5":
                case "пятница":
                    {
                        Console.WriteLine("Расписание: 8.00, 9.00, 13.00");
                        break;
                    }
                case "6":
                case "суббота":
                    {
                        Console.WriteLine("Расписание: выходной");
                        break;
                    }
                case "7":
                case "воскресенье":
                    {
                        Console.WriteLine("Расписание: выходной");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Введен не день недели");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
