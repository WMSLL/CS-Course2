using System;
using System.IO;
namespace HomeWork13
{
    class FileLogWriter : ILogWriter
    {
        string FailNmae;
        public FileLogWriter(string filename)
        {
            FailNmae = filename;
        }

        public void LogInfo(string message)
        {
            var error = $"{DateTimeOffset.Now}/tInfo{message}";
            File.AppendAllText(FailNmae, error);
        }
        public void LogWarning(string message)
        {
            var error = $"{DateTimeOffset.Now}/tWarning{message}";
            File.AppendAllText(FailNmae, error);
        }
        public void LogError(string message)
        {
            var error = $"{DateTimeOffset.Now}/tError{message}";
            File.AppendAllText(FailNmae, error);
        }
    }
}
