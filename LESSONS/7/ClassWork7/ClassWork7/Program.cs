using System;

namespace ClassWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число ");
            var num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число ");
            var num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Произведение чисел"+ num1+" И " + num2 +" равна"+ (num1*num2).ToString("0.###"));

            Console.WriteLine("Сумма "+(num1+num2).ToString("0.###"));

            Console.WriteLine($"Вычитание: {(num1-num2).ToString("0.###")}");
        }

       
    }
}
