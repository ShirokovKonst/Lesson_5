using System;

namespace Lesson_5_HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] mas = new double[100];
            Random x = new Random();
            int i = 0;
            while (i < mas.Length)
            {
                mas[i] = Convert.ToDouble(x.Next(10, 100)/10.0);
                i++;
            }

            double max = mas[0];
            double min = mas[0];
            i = 0;

            while (i < mas.Length)
            {
                if (mas[i] > max) max = mas[i];
                if (mas[i] < min) min = mas[i];
                i++;
            }

            Console.WriteLine("Разница между максимальным и минимальным числами массива равна " + (max-min));
           
        }
    }
}
