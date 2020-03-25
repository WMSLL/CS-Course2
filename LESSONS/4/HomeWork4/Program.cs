using System;
using System.Linq;

namespace HomeWork4
{

    enum containerType : byte
    {
        L20 = 20,
        L5 = 5,
        L1 = 1


    };
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой объем сока(в литрах) требуется упаковать:");
           
            var totalJuice = double.Parse(Console.ReadLine().Replace(".", ","));
           
            var countCont20 = totalJuice / (int)containerType.L20;
            
            var contCont5 = (totalJuice - (int)countCont20 * (int)containerType.L20) / (int)containerType.L5;
            
            var contCont1 = totalJuice - (((int)countCont20 * (int)containerType.L20) + ((int)contCont5 * (int)containerType.L5));
           
            if ((int)countCont20 > 0)
            {
                Console.WriteLine($"20-ти литровых {(int)countCont20}");
            }

            if ((int)contCont5 > 0)
            {
                Console.WriteLine($"5-ти литровых { (int)contCont5}");
            }

            if ((int)Math.Ceiling(contCont1) > 0)
            {
                Console.WriteLine($"1-ти литровых { (int)Math.Ceiling(contCont1)}");
            }

            Console.WriteLine("Нажмити любую клавишу");
           
            Console.ReadKey();






        }
    }
}
