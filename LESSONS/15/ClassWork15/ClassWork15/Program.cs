using System;

namespace ClassWork15
{
    class Program
    {
        static void Main(string[] args)
        {
            var q1 = new Accaunt<int>(id: 1,name: "nfm");

            q1.WriteProperties();

            var q2 = new Accaunt<string>(id: "ssss", name: "nwerwerfm");

            q2.WriteProperties();

            var q3 = new Accaunt<Guid>(id: Guid.NewGuid(), name: "werewr");

            q3.WriteProperties();

        }
    }
}
