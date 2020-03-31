using System;

namespace HomeWork6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var contribution = ReadNumeric("Введите сумму первоначального взноса в рублях");
            var percent = ReadNumeric("Введите ежедневный процент дохода в виде десятичной дроби(1%=0.01):");
            var amountSavings = ReadNumeric("Введите Желаемую сумму накопления в рублях:");
            decimal sumPercent;
            int countWhile = 0;
            do
            {
                sumPercent = (contribution / 100m) * (percent * 100);
                contribution += sumPercent;
                countWhile++;
            } while (contribution < amountSavings);
            Console.WriteLine($"Необходимое количество дней для накопления желаймой суммы в {amountSavings} руб:  {countWhile}");
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadLine();
        }


        static decimal ReadNumeric(string title)
        {
            for (; ; )
            {
                try
                {
                    Console.WriteLine(title);
                    return decimal.Parse(Console.ReadLine().Replace(".", ","));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не числовое значение,повторите ввод");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Вы Слишком большое значение,повторите ввод");
                }
            }
        }
    }
}

