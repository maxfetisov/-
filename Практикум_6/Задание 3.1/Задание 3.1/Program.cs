using System;

namespace Задание_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите количество строк и столбцов в массиве: ");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введены некорректные данные");
                Console.ReadKey(); 
                Console.ReadKey();
                return;
            }
            if (n >= 0)
            {
                int norm = 0;
                int[][] arr2 = new int[n][];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Строка №{0}: ", i);
                    arr2[i] = Input(n);
                    norm += arr2[i][Max(arr2[i])];
                }
                Console.WriteLine("Норма матрицы равна " + norm);
            }
            else
            {
                Console.WriteLine("Введено некорректное число строк");
            }
            Console.ReadKey();
            Console.ReadKey();
        }
        static int[] Input(int n)
        {
            int[] arr;
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                try
                {
                    Console.Write("Введите элемент №{0}: ", i);
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Неверный ввод");
                    Random rand = new Random();
                    arr[i] = rand.Next();
                }
            }      
            return arr;
        }
        static int Max(int[] arr)
        {
            int max = arr[arr.Length - 1];
            int index = arr.Length - 1;
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }
            return index;
        }
    }
}
