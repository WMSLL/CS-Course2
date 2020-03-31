using System;
using System.Linq;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = ReadNumber("Введите положительное натуральное число не более 2-х миллиардов");
            int[] digits = number.ToString().Select(c => (int)char.GetNumericValue(c)).ToArray();
            for (int i = 0; i < number.ToString().Length; i++)
            {
                if (digits[i] % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(digits[i]);
            }
            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }

        static int ReadNumber(string title)
        {
            for (; ; )
            {
                try
                {
                    Console.WriteLine(title);
                    return int.Parse(Console.ReadLine());
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
