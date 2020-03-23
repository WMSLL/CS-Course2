using System;

namespace Colors
{

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
