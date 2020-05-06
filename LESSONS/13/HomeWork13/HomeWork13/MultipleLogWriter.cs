using System;
using System.IO;
namespace HomeWork13
{
    class MultipleLogWriter : ILogWriter
    {
        private ILogWriter[] _loggers;
        public void LogInfo(string message)
        {
            foreach (var item in _loggers)
            {
                if (item is FileLogWriter LogInfo)
                {
                    item.LogInfo(message);
                }
            }
            foreach (var item in _loggers)
            {
                if (item is ConsoleLogWriter LogInfo)
                {
                    item.LogInfo(message);
                }
            }
        }
        public void LogWarning(string message)
        {
            foreach (var item in _loggers)
            {
                if (item is FileLogWriter LogWarning)
                {
                    item.LogWarning(message);
                }
            }
            foreach (var item in _loggers)
            {
                if (item is ConsoleLogWriter LogWarning)
                {
                    item.LogWarning(message);
                }
            }
        }
        public void LogError(string message)
        {
            foreach (var item in _loggers)
            {
                if (item is FileLogWriter LogError)
                {
                    item.LogError(message);
                }
            }
            foreach (var item in _loggers)
            {
                if (item is ConsoleLogWriter LogError)
                {
                    item.LogError(message);
                }
            }
        }
        public MultipleLogWriter(ILogWriter[] arg)
        {
            _loggers = arg;
        }
    }
}
