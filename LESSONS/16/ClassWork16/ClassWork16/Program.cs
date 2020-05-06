using System;


namespace ClassWork16
{
    
    class Program
    { 
        static void Main(string[] args)
        {
            
           var c = new Circle(1.5);
           Func<double, double> oper1 =  r => 2.0 * r;
            //   Func<double, double> oper2 = r => Math.PI*Math.Pow(r,2);          
           Console.WriteLine(c.Calculate(oper1));          
           Console.WriteLine(c.Calculate(r => Math.PI * Math.Pow(r, 2)));
        }
    }
}
