using System;


namespace HomeWork13
{
    class ConsoleLogWriter : ILogWriter
    {
      
       public void LogInfo(string message)
        {
            var error = $"{DateTimeOffset.Now}/tInfo{message}";
            Console.WriteLine(error); 
        }
        public void LogWarning(string message)
        {
            var error = $"{DateTimeOffset.Now}/tWarning{message}";
            Console.WriteLine(error);
        }
        public void LogError(string message)
        {
            var error = $"{DateTimeOffset.Now}/tError{message}";
            Console.WriteLine(error);
        }
    }
}
