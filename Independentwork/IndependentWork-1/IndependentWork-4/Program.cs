using System;

namespace IndependentWork_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var deposit = EnterNum("Введите сколько внесети дипозита");
            var percent = 0;
            if (deposit < 100)
            {
                percent = 5;
            }
            else if ((deposit >= 100 && deposit <= 200))
            {
                percent = 7;
            }
            else if (deposit > 200)
            {
                percent = 10;
            }
            Console.WriteLine($" Сумма равна {deposit + (percent * deposit / 100)}        {percent * deposit / 100}");
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
