using System;

namespace IndependentWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = EnterNum("Введите первое число");
            var num2 = EnterNum("Введите второе число");
            if (num1 > num2)
            {
                Console.WriteLine($"Первое число {num1} больше чем второе {num2} ");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"Второе число {num2} больше чем первое {num1} ");
            }
            else
            {
                Console.WriteLine($"Оба числа {num2} и {num1} равны");
            }
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
        static double EnterNum(string title)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(title);
                    return double.Parse(Console.ReadLine().Replace('.', ','));
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Введен не числовое значение");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Превышина максимальный значение числа , максимально значение :{double.MaxValue}");
                }
            }
        }
    }
}
