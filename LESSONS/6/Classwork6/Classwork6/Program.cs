using System;

namespace Classwork6
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 10;
            int[] a = new int[count];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Random().Next(0,50);
            }

            int countWhile = 0;
            int sum=0;
            while (countWhile < count)
            {
                sum+= a[countWhile];
                countWhile++;

                Console.WriteLine($"{sum}");
            }
            Console.ReadKey();








            //string exit;
            //do
            //{
            //    Console.WriteLine("Введите текст");
            //     exit = Console.ReadLine();
            //    if(exit.Length<=15)
            //    {
            //        Console.WriteLine($"Enter string lenght{exit.Length}");
            //    }
            //    if (exit.Length > 15)
            //    {
            //        Console.WriteLine($"Too long string.try another {exit.Length}");
            //        continue;
            //    }
            //}
            //while (exit.ToLower()!="exit".ToLower());
            //
            //Console.WriteLine("Вышли из цикла");
            //Console.ReadKey();
        }

    }
}
