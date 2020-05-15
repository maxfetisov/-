using System;

namespace Задание_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("Введите количество элементов в массиве: ");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введены некорректные данные");
                Console.ReadKey();
                return;
            }
            try
            {
                int[] arr1 = Input(n);
                Console.Write("Введите число для поиска: ");
                int k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Номера всех чисел, больших заданного для поиска: ");
                Find(arr1, k);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Введите количество строк в массиве: ");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество столбцов в массиве: ");
                m = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введены некорректные данные");
                Console.ReadKey();
                return;
            }
            if (n >= 0)
            {
                int[][] arr2 = new int[n][];
                for(int i = 0; i < n; i++)
                {
                    Console.WriteLine("Строка №{0}: ", i);
                    try
                    {
                        arr2[i] = Input(m);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.ReadKey();
                        return;
                    }
                }
                Console.Write("Введите число для поиска: ");
                int k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Номера всех чисел, больших заданного для поиска: ");
                for(int i = 0; i < n; i++)
                {
                    Find(arr2[i], k);
                }
            }
            else
            {
                Console.WriteLine("Введено некорректное число строк");
            }
            Console.ReadKey();
        }

        static int[] Input(int n)
        {
            int[] arr;
            if (n >= 0)
            { 
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
            }
            else
            {
                throw new Exception("Некорректное число элементов");
            }
            return arr;
        }

        static void Find(int[] arr, int k)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > k)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
