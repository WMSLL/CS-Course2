namespace HomeWork14
{
    class MultipleLogWriter : ILogWriter
    {
        public ILogWriter[] LogWriter;
        public void LogError(string message)
        {        
        }

        public void LogInfo(string message)
        {         
        }

        public void LogWarning(string message)
        {           
        }

        public MultipleLogWriter(ILogWriter[] arg)
        {
            LogWriter = arg;
        }
    }
}
