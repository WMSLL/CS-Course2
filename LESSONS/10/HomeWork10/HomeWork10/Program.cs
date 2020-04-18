using System;

namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            var countArrey = 3;
            Employee[] employoees = new Employee[countArrey];
            for (int i = 0; i < countArrey; i++)
            {
                var name = InPutName("Укажите имя сотрудника");
                var age = InPutAge("Введите возраст сотрудника"); ;
                employoees[i] = new Employee(name, age);
            }
            for (int i = 0; i < countArrey; i++)
            {
                Console.WriteLine(employoees[i].OutPut());
            }
        }

        static int InPutAge(string title)
        {
            while (true)
            {
                Console.WriteLine(title);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Указано не числовое значение: повторите ввод");
                }
            }
        }
        static string InPutName(string title)
        {
            while (true)
            {
                Console.WriteLine(title);
                try
                {
                    return Console.ReadLine();
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Вы ввели пустое значение: повторите ввод");
                }
            }
        }
    }
}