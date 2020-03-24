using System;

namespace Independent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter height");
            var height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Base side");
            var baseSide = double.Parse(Console.ReadLine());
            var H = Math.Sqrt((height * height) - ((baseSide * baseSide) / 12.0));
            // Math.Pow(height.2)  Степень Числа
            Console.WriteLine($"S side: {3.0 * baseSide * height}");
                       
            Console.WriteLine($"S base: {(3.0 / 2.0) * baseSide * (baseSide * Math.Sqrt(3) + 2 * height)}");
        
            Console.WriteLine($"Vol Pyramid : {(baseSide * baseSide / 2.0) * H * (Math.Sqrt(3))}");

            Console.WriteLine( "Press any key");
            Console.ReadKey();

        }


    }
}
