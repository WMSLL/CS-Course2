namespace HomeWork13
{
    class LogWriteFactory
    {
        private LogWriteFactory()
        {

        }
        private static LogWriteFactory _factory;

        public static LogWriteFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new LogWriteFactory();
                }
                return _factory;

            }
        }


        public ILogWriter GetLogWriter<T>(T arg1) where T : ILogWriter
        {
            var w = arg1;
            return w;
        }
    }


}
