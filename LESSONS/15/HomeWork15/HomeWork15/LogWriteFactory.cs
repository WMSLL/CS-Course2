

using System;
using System.Runtime.InteropServices.ComTypes;

namespace HomeWork13
{
    class LogWriteFactory
    {
        private LogWriteFactory()
        {

        }
        private static LogWriteFactory _instance;

        public static LogWriteFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LogWriteFactory();
                }
                return _instance;
            }
        }   
        public ILogWriter GetLogWriter<T>(object arg1) where T : ILogWriter
        {
            if (typeof(T)==typeof(FileLogWriter))
            {
                return new FileLogWriter(arg1 as string);
            }
            else if (typeof(T) == typeof(ConsoleLogWriter))
            {
                return new ConsoleLogWriter();
            }else
            {
                return new MultipleLogWriter(arg1 as ILogWriter[]);
            }            
        }
    }    
}
