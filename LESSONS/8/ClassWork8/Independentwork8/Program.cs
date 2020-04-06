using System;
using System.Collections.Generic;

namespace Independentwork8
{
    class Program
    {
        static void Main(string[] args)
        {
            var integer = new List<int>();
            double sum=0;
            while (true)
            {
                Console.WriteLine("Введите число:");
                var str =Console.ReadLine();
                if (str.ToUpper()=="STOP")
                {
                    foreach (var item in integer)
                    {
                        sum += item;
                    }
                    Console.WriteLine(sum / integer.Count);
                    break;
                }
                else
                {
                    integer.Add(int.Parse(str));
                }
               


            }
            
        }

        
    }
}
