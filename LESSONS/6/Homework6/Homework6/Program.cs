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
            int sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] % 2 != 0)
                {
                    continue;
                }
                sum++;
            }
            Console.WriteLine($"Введенное число {number} cодержит следующее колличество четных цифр: {sum}");
            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }

        static int ReadNumber(string title)
        {
            while (true)
            {
                int enterNum = 0;
                try
                {
                    Console.WriteLine(title);
                    enterNum = int.Parse(Console.ReadLine());
                    if ((enterNum < 0))
                    {
                        throw new FormatException();
                    }
                    if (enterNum > 2000000000)
                    {
                        throw new OverflowException();
                    }
                    return enterNum;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не числовое значение,или отрицательное3 число,повторите ввод");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Вы Слишком большое значение,повторите ввод");
                }
            }
        }

    }
}
