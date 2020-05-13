using System;
using System.IO;

namespace ClassWork17_1
{
    class Program
    {
        static void Main(string[] args)
        {         
            
            var gen = new Generate();
            gen.GenAct += Printing;
            gen.RandomGenNum(6);
        }

        public static void Printing(byte[] arg)
        {
            foreach (var item in arg)
            {
                File.AppendAllText("log.txt",item.ToString());
            }
        }
    }

    class GeneratedateEvent
    {


    }
    class Generate
    {

        public event Action<byte[]> GenAct;
        public void RandomGenNum(int counts)
        {
            var random = new Random();
            var array = new byte[counts];
            random.NextBytes(array);
            GenAct.Invoke(array);
        }

    }
}

