

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


        public ILogWriter GetLogWriter<T>(T arg1) where T : ILogWriter, new()
        {
           
            T obj = new T();
            return obj;
        }

        public ILogWriter GetLogWriter<T>(object arg1) where T : ILogWriter,new()
        {

            T obj = new T();
            return obj;
        }


    }


}
