using System;
using CircleStandart;
using CalculatorOperation;

namespace ClassWork16
{
    
    class Program
    { 
        static void Main(string[] args)
        {
            var figure = new CircleClass(2.5);
            Console.WriteLine(figure.Calculate(r => Math.PI * Math.Pow(r, 2)));

            var opera = new ClassOperation(2.5);
            Console.WriteLine(opera.Calculate(r => Math.PI * Math.Pow(r, 2)));
        }
    }
}
