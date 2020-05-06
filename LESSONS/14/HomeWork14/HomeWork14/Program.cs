namespace HomeWork14
{
    class Program
    {
        static void Main(string[] args)
        {
            var conLog = ConsoleLogWriter.ConsoleLogInstance;           
            var conLog2 = FileLogWriter.FileLogInstance;
            conLog2.RenameFileLog("LoggerNew.txt");
            var argMult = new ILogWriter[] { conLog2, conLog };
            var MultLog = new MultipleLogWriter(argMult);          
            MultLog.LogError("LogError new new");
            MultLog.LogInfo("LogInfo new new");
            MultLog.LogWarning("LogWarning new new");
        }
    }
}
