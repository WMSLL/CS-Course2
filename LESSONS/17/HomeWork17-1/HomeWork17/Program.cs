using System;

namespace HomeWork17
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer1 = new FileWriterWithProgress();
            writer1.GenAct += OnStatrt;
            var data = new byte[100];
            var random = new Random();
            random.NextBytes(data);

            OnStatrt(data);
            for (int i = 0; i <= data.GetUpperBound(0); i++)
            {
                Console.WriteLine("{0}: {1}", i, data[i]);
            }            
        }

        private static void OnStatrt(byte[] obj)
        {
            for (int i = 0; i <= obj.GetUpperBound(0); i++)
            {
                Console.WriteLine("{0}: {1}", i, obj[i]);
            }
        }
    }
}
