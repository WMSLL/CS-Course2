using System;
using CircleStandart;

namespace ClassWork16
{
    
    class Program
    { 
        static void Main(string[] args)
        {
            var n = new CircleClass(2.5);
            Console.WriteLine(n.Calculate(r => Math.PI * Math.Pow(r, 2)));

        }
    }
}
