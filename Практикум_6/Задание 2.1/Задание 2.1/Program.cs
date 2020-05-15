using System;

namespace Задание_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr;
            Console.Write("Введите количество элементов в массиве: ");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                arr = Input(n);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Console.ReadKey();
                return;
            }
            int max = Max(arr);
            int min = Min(arr);
            double buf = arr[max];
            arr[max] = arr[min];
            arr[min] = buf;
            Console.WriteLine("итоговый массив: ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
            Console.ReadKey();
        }
        static double[] Input(int n)
        {
            double[] arr;
            if (n >= 0)
            {
                Random rand = new Random();
                arr = new double[n];
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
        static int Max(double[] arr)
        {
            double max = arr[arr.Length - 1];
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
        static int Min(double[] arr)
        {
            double min = arr[0];
            int index = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                }
            }
            return index;
        }
    }
}
