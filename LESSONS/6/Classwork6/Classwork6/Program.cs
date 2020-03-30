using System;

namespace Classwork6
{
    class Program
    {
        static void Main(string[] args)
        {

            var marks = new[]
            {
                new[] { 2,3,3,2,3},
                new[] { 2,4,3,5},
                null,
                new[] {5,5,5,5,},
                new[] {4}
            };

            double sum = 0.0;
            double sum2 = 0.0;
            for (int i = 0; i < marks.Length; i++)
            {
                 
                if (marks[i] == null)
                {
                    continue;
                }

                for (int j = 0; j < marks[i].Length; j++)
                {
                      sum += marks[i][j];                                       
                }
               
                Console.WriteLine($"{sum / marks[i].Length}");
                sum = 0;


            }
           
            Console.ReadKey();
            
            
            //int count = 10;
           //int[] a = new int[count];
           //
           //for (int i = 0; i < a.Length; i++)
           //{
           //    a[i] = new Random().Next(0,50);
           //}
           //
           //int countWhile = 0;
           //int sum=0;
           //while (countWhile < count)
           //{
           //    sum+= a[countWhile];
           //    countWhile++;
           //
           //    Console.WriteLine($"{sum}");
           //}
           //Console.ReadKey();








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
