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
                int[][] arr = new int[n][];
                int[] negArr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Строка №{0}: ", i);
                    arr[i] = Input(n);
                    negArr[i] = Neg(arr[i]);
                }
                Console.WriteLine("Массив номеров отрицательных элементов: ");
                for(int i = 0; i < n; i++)
                {
                    if (negArr[i] < 0)
                    {
                        Console.Write("Нет отрицательных элементов ");
                    }
                    else
                    {
                        Console.Write(negArr[i] + " ");
                    }
                }
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
        static int Neg(int[] arr)
        {
            int index = -1;
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] < 0)
                {
                    index = i;
                }
            }
            return index;
        }
    }
}
