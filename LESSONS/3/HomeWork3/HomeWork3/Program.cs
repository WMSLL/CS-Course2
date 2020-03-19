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

            string[] age = new string[3];

              for (var i =0;i<names.Length;i++)
            {
               Console.WriteLine($"Enter the name of the {i+1}st employee");
               names[i] = Console.ReadLine();

            }

            for (var i = 0; i < age.Length; i++)
            {
              Console.WriteLine($"Enter the employee's {names[i]} age " );
              age[i] = Console.ReadLine();
            }

            
            for (var i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Name: {names[i]}, age in 4 years :{int.Parse(age[i])+4}");
            }



            Console.ReadKey();
        }
    }
}
