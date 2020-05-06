using System;
using System.IO;
namespace HomeWork13
{
    class FileLogWriter : ILogWriter
    {
        private string _failNmae;
        public FileLogWriter(string filename)
        {
            _failNmae = filename;
        }
        public void LogInfo(string message)
        {
            var error = $"{DateTimeOffset.Now}/tInfo{message}";
            File.AppendAllText(_failNmae, error);
        }
        public void LogWarning(string message)
        {
            var error = $"{DateTimeOffset.Now}/tWarning{message}";
            File.AppendAllText(_failNmae, error);
        }
        public void LogError(string message)
        {
            var error = $"{DateTimeOffset.Now}/tError{message}";
            File.AppendAllText(_failNmae, error);
        }
    }
}
