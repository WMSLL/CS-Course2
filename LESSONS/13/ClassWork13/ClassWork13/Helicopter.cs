using System;
namespace ClassWork13
{
    class Helicopter: AirTransport
    {
        public byte BladesCount { get; private set; }
       
        
       
        public Helicopter (int MaxHeight,byte BladesCount)
        {

        }

        public override void WriteAllProperties()
        {
            Console.WriteLine($"MaxHeight{MaxHeight},CurrentHeight{CurrentHeight}");
        }

    }
}
