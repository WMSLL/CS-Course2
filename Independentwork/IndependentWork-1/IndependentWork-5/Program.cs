using System;

namespace IndependentWork_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var deposit = EnterNum("Введите сколько внесети дипозита");
            
            if (deposit < 100)
            {
                deposit += deposit * 0.05;
            }
            else if ((deposit >= 100 && deposit <= 200))
            {
                deposit += deposit * 0.07;
            }
            else if (deposit > 200)
            {
                deposit += deposit * 0.1;
            }
            deposit += 15;
            Console.WriteLine($" Сумма равна {deposit}");
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
