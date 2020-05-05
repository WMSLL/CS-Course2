using System;

namespace HomeWork14
{
    class ConsoleLogWriter : ILogWriter
    {
        private ConsoleLogWriter()
        {

        }

        private static ConsoleLogWriter _consoleLogInstance;

        public static ConsoleLogWriter ConsoleLogInstance
        {
            get
            {
                return _consoleLogInstance ?? (_consoleLogInstance = new ConsoleLogWriter());
            }
        }

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
