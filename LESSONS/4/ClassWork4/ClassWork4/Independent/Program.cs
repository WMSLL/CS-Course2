using System;

namespace Independent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите height");
            var height = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 'a'");
            var a = double.Parse(Console.ReadLine());

            var H = Math.Sqrt((height * height) - ((a * a) / 12.0));

            // Math.Pow(height.2)  Степень Числа

            Console.WriteLine("S Бок");

            Console.WriteLine(3.0 * a * height);


            Console.WriteLine("S Полн");

            Console.WriteLine($"{(3.0 / 2.0) * a * (a * Math.Sqrt(3) + 2 * height)}");



            Console.WriteLine("V");

            Console.WriteLine($"{(a * a / 2.0) * H * (Math.Sqrt(3))}");








        }


    }
}
