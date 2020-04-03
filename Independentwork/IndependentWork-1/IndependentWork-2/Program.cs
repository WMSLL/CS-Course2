using System;

namespace IndependentWork_2
{
    class Program
    {
        static void Main(string[] args)
        {          
            while (true)
            {
                var num1 = EnterNum("Введите число");
                if (num1 > 5 && num1 < 10)
                {
                    Console.WriteLine("Число больше 5 и меньше 10");                   
                }
                else
                {
                    Console.WriteLine("Введино не корректное число");
                    continue;
                }
                break;
            }           
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
        static double EnterNum (string title)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(title);
                    return double.Parse(Console.ReadLine().Replace('.',','));
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
