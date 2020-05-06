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
                if (item is ILogWriter LogInfo)
                {
                    item.LogInfo(message);
                }
            }          
        }
        public void LogWarning(string message)
        {
            foreach (var item in _loggers)
            {
                if (item is ILogWriter LogWarning)
                {
                    item.LogWarning(message);
                }
            }           
        }
        public void LogError(string message)
        {
            foreach (var item in _loggers)
            {
                if (item is ILogWriter LogError)
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
