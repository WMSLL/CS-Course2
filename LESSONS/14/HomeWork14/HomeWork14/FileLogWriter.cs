using System;
using System.IO;

namespace HomeWork14
{
    class FileLogWriter : ILogWriter
    {

        private FileLogWriter()
        {

        }

        private static FileLogWriter _fileLogInstance;

        public static FileLogWriter FileLogInstance
        {
            get
            {
                if (_fileLogInstance == null)
                {
                    _fileLogInstance = new FileLogWriter();
                }
                return _fileLogInstance;
            }
        }

        public void LogInfo(string message)
        {
            var error = $"{DateTimeOffset.Now}/tInfo{message}";
            File.AppendAllText("LogError.txt", error);
        }
        public void LogWarning(string message)
        {
            var error = $"{DateTimeOffset.Now}/tWarning{message}";
            File.AppendAllText("LogError.txt", error);
        }
        public void LogError(string message)
        {
            var error = $"{DateTimeOffset.Now}/tError{message}";
            File.AppendAllText("LogError.txt", error);
        }
    }
}
