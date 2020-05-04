using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 4; i >= 0; i--)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
