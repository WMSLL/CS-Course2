using System;

namespace HomeWork13
{
    class Program
    {
        static void Main(string[] args)
        {

            var arryaObject = new ILogWriter[]
            {
                         new FileLogWriter(),
                         new ConsoleLogWriter()
            };

            var mult = new MultipleLogWriter(arryaObject);


            


        }
    }
}
