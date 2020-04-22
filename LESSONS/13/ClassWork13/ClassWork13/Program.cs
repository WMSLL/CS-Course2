using System;

namespace ClassWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            var helicompter = new Helicopter(100, 0b00000010);
            var plane = new Plane(100, 0b00010000);           
            helicompter.SetCurrentHeight(10);         
            helicompter.TakeUpper(15);
            Console.WriteLine(helicompter.CurrentHeight);
            helicompter.WriteAllProperties();
        }
    }

}
