namespace HomeWork14
{
    class MultipleLogWriter : ILogWriter
    {
        private ILogWriter[] _logWriter;
        public void LogError(string message)
        {
            foreach (var errors in _logWriter)
            {
                if (errors is FileLogWriter LogError)
                {
                    errors.LogError(message);
                }
            }
            foreach (var errors in _logWriter)
            {
                if (errors is ConsoleLogWriter LogError)
                {
                    errors.LogError(message);
                }
            }
        }

        public void LogInfo(string message)
        {
            foreach (var errors in _logWriter)
            {
                if (errors is FileLogWriter LogInfo)
                {
                    errors.LogInfo(message);
                }
            }
            foreach (var errors in _logWriter)
            {
                if (errors is ConsoleLogWriter LogInfo)
                {
                    errors.LogInfo(message);
                }
            }
        }

        public void LogWarning(string message)
        {
            foreach (var errors in _logWriter)
            {
                if (errors is FileLogWriter LogWarning)
                {
                    errors.LogWarning(message);
                }
            }
            foreach (var errors in _logWriter)
            {
                if (errors is ConsoleLogWriter LogWarning)
                {
                    errors.LogWarning(message);
                }
            }
        }

        public MultipleLogWriter(ILogWriter[] arg)
        {
            _logWriter = arg;
        }
    }
}
