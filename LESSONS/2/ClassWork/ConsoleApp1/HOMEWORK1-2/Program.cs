using System;

namespace HOMEWORK1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");

            string a = Console.ReadLine();

            int number1 = int.Parse(a);

            Console.WriteLine("Введите второе число");

            string b = Console.ReadLine();

            int number2 = int.Parse(b);

            Console.WriteLine("Введите тип операции(+,-,/,*,%,^)");

            var t = Console.ReadLine();

            if (t=="+")
            {
                Console.WriteLine("Сумма:");
                Console.WriteLine(number1 + number2);
            }
            else
            if (t=="-")
            {
                Console.WriteLine("Разница:");
                Console.WriteLine(number1 - number2);
            }
            else
            if (t == "/")
            {
                Console.WriteLine("деление:");
                Console.WriteLine(number1 / number2);
            }
            else
            if (t == "%")
            {
                Console.WriteLine("Остаток:");
                Console.WriteLine(number1 % number2);
            }
            else
            if (t == "^")
            {
                Console.WriteLine("Степень:");
                Console.WriteLine(Math.Pow(number1, number2));
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
