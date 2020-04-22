using System;
namespace ClassWork13
{
    class Plane : AirTransport

    {
        public byte EnginesCount { get; private set; }

        public Plane(int MaxHeight, byte EnginesCount)
        {

        }

        public override void WriteAllProperties()
        {
            Console.WriteLine($"MaxHeight{MaxHeight},CurrentHeight{CurrentHeight}");
        }
    }

}
