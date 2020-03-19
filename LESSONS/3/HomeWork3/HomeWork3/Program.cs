//Написать консольное приложение, запрашивающее у пользователя имена трех человек.Затем также запрашивающее возраст этих людей.Затем программа должна вывести на экран 
//информацию о людях и их возрастах через 4 года (см.пример на предпоследней странице презентации). Задание должно быть сделано с использованием массивов и циклов.

using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];

            int[] age = new int[3];

              for (var i =0;i<names.Length;i++)
            {
               Console.WriteLine($"Enter the name of the {i+1}st employee");
               names[i] = Console.ReadLine();

            }

            Console.WriteLine();

            for (var i = 0; i < age.Length; i++)
            {
              Console.WriteLine($"Enter the employee's {names[i]} age " );
              age[i] = int.Parse(Console.ReadLine());
            }

            
            for (var i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Name: {names[i]}, age in 4 years :{age[i]+4}");
            }


            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
