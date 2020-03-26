using System;

namespace ClassWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte a =0b00000011;
            // byte b = 0b00000101;
            Console.WriteLine("Введите возраст");

            var years = int.Parse(Console.ReadLine());
            string messeng;

            var remains = years % 10;

            var Dece = years % 10;

            var division = years / 10;

            if (remains == 1 && division!=1)

            {
                messeng = "Год";
            }
            else if (remains >= 2 && remains <= 4 )
            {
                messeng = "Года";
            }
            else
            {
                messeng = "Лет";
            }

            Console.WriteLine($"Вам :{years}  "+messeng);

            Console.WriteLine("Нажмити любую клавишу");

            Console.ReadKey();
        }


    }

}
