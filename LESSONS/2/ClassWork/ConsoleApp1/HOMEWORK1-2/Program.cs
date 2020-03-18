using System;

namespace HOMEWORK1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите тип операции(+,-,/,*,%,^)");

            var operationType = Console.ReadLine();

            if (operationType == "+")
            {
                Console.WriteLine("Сумма:");
                Console.WriteLine(number1 + number2);
            }
            else             if (operationType == "-")
            {
                Console.WriteLine("Разница:");
                Console.WriteLine(number1 - number2);
            }
            else             if (operationType == "/")
            {
                Console.WriteLine("деление:");
                Console.WriteLine(number1 / number2);
            }
            else             if (operationType == "%")
            {
                Console.WriteLine("Остаток:");
                Console.WriteLine(number1 % number2);
            }
            else            if (operationType == "^")
            {
                Console.WriteLine("Степень:");
                Console.WriteLine(Math.Pow(number1, number2));
            }
            else            if (operationType == "*")
            {
                Console.WriteLine("Произведение:");
                Console.WriteLine(number1* number2);
            }
            else
            {
                Console.WriteLine("Вы ввели не верный символ");
                
            }
            Console.WriteLine("Нажмити любую клавишу");
            Console.ReadKey();
        }
    }
}
