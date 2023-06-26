using System;

namespace Lesson_5_HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[100];
            int i = 0;
            int count = 0;
            string post1 = null;
            string post2 = null;
            while (i < mas.Length)
            {
                mas[i] = new Random().Next(100, 1000);
                if (mas[i]%2 == 0) count++;
                i++;
            }
            if ((count%10 == 1))
            {
                post1 = "ло";
                post2 = "ое";
            }
            else if ((count%10 == 0) ^ (count%10 == 5) ^ (count%10 == 6) ^ (count%10 == 7) ^ (count%10 == 8) ^ (count%10 == 9))
            {
                post1 = "ел";
                post2 = "ых";
            }
            else
            {
                post1 = "ла";
                post2 = "ых";
            }

            Console.WriteLine("В массиве " + count + " четн" + post2 + " чис" + post1);
        }
    }
}
