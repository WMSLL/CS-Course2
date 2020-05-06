using System;
using System.IO;

namespace HomeWork14
{
    class FileLogWriter : ILogWriter
    {
       private string _faileName;
        private FileLogWriter(string fileName)
        {
            _faileName = fileName;
        }

        private static FileLogWriter _fileLogInstance;

        public static FileLogWriter FileLogInstance
        {
            get
            {
                return _fileLogInstance ?? (_fileLogInstance = new FileLogWriter("FileLog.txt"));
            }
        }

        public void LogInfo(string message)
        {
            var error = $"{DateTimeOffset.Now}/tInfo{message}";
            File.AppendAllText(_faileName, error);
        }
        public void LogWarning(string message)
        {
            var error = $"{DateTimeOffset.Now}/tWarning{message}";
            File.AppendAllText(_faileName, error);
        }
        public void LogError(string message)
        {
            var error = $"{DateTimeOffset.Now}/tError{message}";
            File.AppendAllText(_faileName, error);
        }
    }
}
