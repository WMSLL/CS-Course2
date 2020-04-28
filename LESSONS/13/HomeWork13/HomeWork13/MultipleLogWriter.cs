using System;
using System.IO;
namespace HomeWork13
{
    class MultipleLogWriter : ILogWriter
    {
        public void LogInfo(string message)
        {
            var error = $"{DateTimeOffset.Now}/tInfo{message}";
            Console.WriteLine(error);            
            File.AppendAllText("LogError.txt", error);
        }
        public void LogWarning(string message)
        {
            var error = $"{DateTimeOffset.Now}/tWarning{message}";
            Console.WriteLine(error);
            File.AppendAllText("LogError.txt", error);
        }
        public void LogError(string message)
        {
            var error = $"{DateTimeOffset.Now}/tError{message}";
            Console.WriteLine(error);
            File.AppendAllText("LogError.txt", error);
        }
        public MultipleLogWriter(ILogWriter[] arg)
        {
           
        } 
    }
}
