using System;
using System.Collections.Generic;
namespace Independentwork8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var colletion = new Queue<int>();
            while (true)
            {
                Console.WriteLine("Введите числодля очереди");
               var  str= Console.ReadLine();
                if (str.ToUpper()=="RUN")
                {
                    while (colletion.Count>0)
                    {
                        Console.WriteLine($"Выполнилась задая № :{colletion.Dequeue()}");
                    }
                    break;
                }
                else if (str.ToUpper() == "EXIT")
                {
                    Console.WriteLine($"В очереди осталось : {colletion.Count} ");
                    break;
                }
                else
                {
                    colletion.Enqueue(int.Parse(str));
                }

            }
        }

        
    }
}
