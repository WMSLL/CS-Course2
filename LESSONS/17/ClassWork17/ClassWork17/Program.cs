using System;
using System.Threading;

namespace ClassWork17
{
    enum Task
    {
        Standart,Complex
    }
    class Program
    {
        delegate void WorkHandel (Task task, int seconds);
        static void Main(string[] args)
        {
            WorkHandel d = workOne;
            d += workTwo;
            d += workThree;
        }

        private static void workOne(Task task, int seconds)
        {
            Thread.Sleep(seconds);
            Console.WriteLine($" workOne {task} {seconds}");
        }

        private static void workTwo(Task task, int seconds)
        {
            Thread.Sleep(seconds);
            Console.WriteLine($" workTwo {task} {seconds}");
        }

        private static void workThree(Task task, int seconds)
        {
            Thread.Sleep(seconds);
            Console.WriteLine($"workThree {task} {seconds}");
        }
    }
}
