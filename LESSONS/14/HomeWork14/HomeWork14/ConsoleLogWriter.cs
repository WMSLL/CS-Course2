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
                if (_consoleLogInstance == null)
                {
                    _consoleLogInstance = new ConsoleLogWriter();
                }
                return _consoleLogInstance;
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
