using System;
using System.Linq;

namespace HomeWork4
{

    enum containerType 
    {
        L20 = 20,
        L5 = 5,
        L1 = 1


    };

    enum ContTypeByte : byte
     {
        L20 =0b00000100,
        L5 = 0b00000010,
        L1 = 0b00000001
    }
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Какой объем сока(в литрах) требуется упаковать:");

           var contByte = 0;

           

            var totalJuice = double.Parse(Console.ReadLine().Replace(".", ","));
           
            var countCont20 = totalJuice / (int)containerType.L20;
            
            var contCont5 = (totalJuice - (int)countCont20 * (int)containerType.L20) / (int)containerType.L5;
            
            var contCont1 = totalJuice - (((int)countCont20 * (int)containerType.L20) + ((int)contCont5 * (int)containerType.L5));

            



            if ((int)countCont20 > 0)
            {
                Console.WriteLine($"20-ти литровых {(int)countCont20}");

                contByte = contByte | (int)ContTypeByte.L20;
            }

            if ((int)contCont5 > 0)
            {
                Console.WriteLine($"5-ти литровых { (int)contCont5}");
                contByte = contByte | (int)ContTypeByte.L5;
            }

            if ((int)Math.Ceiling(contCont1) > 0)
            {
                Console.WriteLine($"1-ти литровых { (int)Math.Ceiling(contCont1)}");
                contByte = contByte | (int)ContTypeByte.L1;
              
            }

            var   result= (contByte & (int)ContTypeByte.L20);

           

            if ((contByte & (int)ContTypeByte.L20) == (int)ContTypeByte.L20)
            {
                Console.WriteLine("Были использованы 20-ти литровые контейнера"); 
            }

            if ((contByte & (int)ContTypeByte.L5) == (int)ContTypeByte.L5)
            {
                Console.WriteLine("Были использованы 5-ти литровые контейнера");
            }
            if ((contByte & (int)ContTypeByte.L1) == (int)ContTypeByte.L1)
            {
                Console.WriteLine("Были использованы 1-а литровые контейнера");
            }




            Console.WriteLine("Нажмити любую клавишу");
           
            Console.ReadKey();






        }
    }
}
