using System;
using System.IO;

namespace Задание_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите количество элементов: ");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                    throw new Exception();
            }
            catch
            {
                Console.WriteLine("Введено некорректное значение");
                Console.ReadKey();
                return;
            }
            FileStream file = new FileStream("file.dat", FileMode.Create);
            BinaryWriter bin = new BinaryWriter(file);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите элемент №{0}: ", i);
                double num;
                try
                {
                    num = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введено некорректное значение");
                    Console.ReadKey();
                    return;
                }
                bin.Write(num);
            }
            bin.Close();
            file = new FileStream("file.dat", FileMode.Open);
            BinaryReader binR = new BinaryReader(file);
            long length = file.Length;
            double sum = 0, count = 0;
            for(long i = 0; i < length; i += 16)
            {
                file.Seek(i, SeekOrigin.Begin);
                sum += binR.ReadDouble();
                count++;
            }
            binR.Close();
            file.Close();
            sum /= count;
            Console.WriteLine("Среднее арифметическое элементов на четных позициях: " + sum);
            Console.ReadKey();
        }
    }
}
