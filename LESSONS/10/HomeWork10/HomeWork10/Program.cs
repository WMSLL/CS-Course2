using System;

namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            var countArrey = 3;
            Employee[] employoees = new Employee[countArrey];
            for (int i = 0; i < countArrey; i++)
            {
                Console.WriteLine("Имя");
                var name = Console.ReadLine();
                Console.WriteLine("Возраст");
                var age = int.Parse(Console.ReadLine());
                employoees[i] = new Employee(name, age);

            }
            Console.WriteLine(employoees[0].EndLine);
            Console.WriteLine(employoees[1].EndLine);
            Console.WriteLine(employoees[2].EndLine);
        }
    }
}