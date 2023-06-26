using System;

namespace Lesson_5_HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[100];
            int i = 0;
            int sum = 0;
            while (i < mas.Length)
            {
                mas[i] = new Random().Next(-100, 101);
                if (i%2 != 0) sum = sum + mas[i];
                i++;
            }
            Console.WriteLine("Сумма элементов, стоящих на нечетных позициях равна " + sum);
        }
    }
}
