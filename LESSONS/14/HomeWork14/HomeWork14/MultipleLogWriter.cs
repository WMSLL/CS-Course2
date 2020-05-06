namespace HomeWork14
{
    class MultipleLogWriter : ILogWriter
    {
        private ILogWriter[] _logWriter;
        public void LogError(string message)
        {
            foreach (var errors in _logWriter)
            {
                if (errors is ILogWriter LogError)
                {
                    errors.LogError(message);
                }
            }            
        }

        public void LogInfo(string message)
        {
            foreach (var errors in _logWriter)
            {
                if (errors is ILogWriter LogInfo)
                {
                    errors.LogInfo(message);
                }
            }           
        }

        public void LogWarning(string message)
        {
            foreach (var errors in _logWriter)
            {
                if (errors is ILogWriter LogWarning)
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
