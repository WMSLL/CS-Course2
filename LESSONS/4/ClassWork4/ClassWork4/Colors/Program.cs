using System;

namespace Colors
{

   // Написать программу для добавления цветов заданной палитры в “избранное”. Программа выводит список цветов с их порядковыми номерами
   //и просит пользователя в цикле выбрать 4 цвета для добавления их в палитру “Избранное”.
    //Выбор производится путём введения порядковых номеров этих цветов.
    //После завершения ввода программа выводит список любимых цветов, а также отдельно список нелюбимых цветов. 
   // Самостоятельная работа: enum [Flags] Список допустимых цветов в палитре: ● Black ● Blue ● Cyan ● Grey ● Green ● Magenta ● Red ● White ● Yellow
    enum Color
    {
        black,
        Blue,
        Cyan,
        Grey,
        Green,
        Magenta,
        Red,
        White,
        Yellow

    }

    class Program
    {
        static void Main()
        {
            var readColors = Console.ReadLine();


            Console.WriteLine(Enum.Parse(typeof(Color), readColors));

        }
    }
}
