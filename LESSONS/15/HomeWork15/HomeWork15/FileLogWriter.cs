using System;
using System.IO;
namespace HomeWork13
{
    class FileLogWriter : ILogWriter
    {
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
