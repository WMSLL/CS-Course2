using System;

namespace HomeWork17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var messega = Console.ReadLine();
            var date = DateTime.ParseExact(messega, "dd.MM.yyyy", null);

            Console.WriteLine(date);
        }
    }  

}
