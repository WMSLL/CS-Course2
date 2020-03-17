using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите первое число");

            string a = Console.ReadLine();

            int number1 = int.Parse(a);

            Console.WriteLine("Введите второе число");

            string b = Console.ReadLine();

            int number2 = int.Parse(b);

            Console.WriteLine("Сумма:");

            Console.WriteLine(number1+number2);

            Console.WriteLine("Разница:");
            Console.WriteLine(number1 - number2);


            Console.WriteLine("Произведение:");
            Console.WriteLine(number1 * number2);

            Console.ReadKey();
        }
    }
}
