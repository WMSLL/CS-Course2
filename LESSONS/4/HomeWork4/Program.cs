using System;
using System.Linq;

namespace HomeWork4
{

    enum ContainerType
    {
        L20 = 20,
        L5 = 5,
        L1 = 1


    };

    enum ContainerCapaсity : byte
    {
        L20 = 0b00000100,
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
            var countCont20 = totalJuice / (int)ContainerType.L20;
            var contCont5 = ((totalJuice % (int)ContainerType.L20) / (int)ContainerType.L5);
            var contCont1 = ((totalJuice % (int)ContainerType.L20) % (int)ContainerType.L5);

            if (Math.Floor(countCont20) > 0)
            {
                Console.WriteLine($"20-ти литровых {Math.Floor(countCont20)}");
                contByte = contByte | (int)ContainerCapaсity.L20;
            }

            if (Math.Floor(contCont5) > 0)
            {
                Console.WriteLine($"5-ти литровых { Math.Floor(contCont5)}");
                contByte = contByte | (int)ContainerCapaсity.L5;
            }

            if (Math.Ceiling(contCont1) > 0)
            {
                Console.WriteLine($"1-и литровых { Math.Ceiling(contCont1)}");
                contByte = contByte | (int)ContainerCapaсity.L1;
            }


            if ((contByte & (int)ContainerCapaсity.L20) == (int)ContainerCapaсity.L20)
            {
                Console.WriteLine("Были использованы 20-ти литровые контейнера");
            }
            if ((contByte & (int)ContainerCapaсity.L5) == (int)ContainerCapaсity.L5)
            {
                Console.WriteLine("Были использованы 5-ти литровые контейнера");
            }
            if ((contByte & (int)ContainerCapaсity.L1) == (int)ContainerCapaсity.L1)
            {
                Console.WriteLine("Были использованы 1-а литровые контейнера");
            }

            Console.WriteLine("Нажмити любую клавишу");
            Console.ReadKey();






        }
    }
}
