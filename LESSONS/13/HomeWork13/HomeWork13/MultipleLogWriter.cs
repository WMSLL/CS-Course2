using System;
using System.Collections.Generic;

namespace HomeWork13
{
    class MultipleLogWriter : ILogWriter
    {
        public void LogInfo(string message)
        {
            var error = $"{DateTimeOffset.Now}/tInfo{message}";
            Console.WriteLine(error);
        }
        public void LogWarning(string message)
        {

        }
        public void LogError(string message)
        {
           
        }
        public MultipleLogWriter(ILogWriter[] arg)
        {           
            
        }

    }
}
