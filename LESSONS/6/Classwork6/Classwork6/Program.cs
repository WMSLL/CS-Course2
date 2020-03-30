using System;

namespace Classwork6
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit;
            do
            {
                Console.WriteLine("Введите текст");
                 exit = Console.ReadLine();
                if(exit.Length<=15)
                {
                    Console.WriteLine($"Enter string lenght{exit.Length}");
                }
                if (exit.Length > 15)
                {
                    Console.WriteLine($"Too long string.try another {exit.Length}");
                }
            }
            while (exit!="exit");

            Console.WriteLine("Вышли из цикла");
            Console.ReadKey();
        }

    }
}
