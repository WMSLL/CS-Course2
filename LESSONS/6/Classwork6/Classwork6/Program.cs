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
                Console.WriteLine("Введите 'exit' для выхода");
                 exit = Console.ReadLine();

            }
            while (exit!="exit");

            Console.WriteLine("Вышли из цикла");

            Console.ReadKey();
        }
    }
}
