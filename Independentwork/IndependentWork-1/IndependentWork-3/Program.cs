using System;

namespace IndependentWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = EnterNum("Введите число");
            if (num == 10 || num == 5)
            {
                Console.WriteLine("Введенное число либо навно 5 либо равно 10");
            }
            else
            {
                Console.WriteLine("Не известное число");
            }
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
                    Console.WriteLine("Ввели не числовое значение");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Превышено максимально-допустимое значение");
                }
            }
        }
    }
}
