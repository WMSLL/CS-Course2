namespace HomeWork14
{
    class Program
    {
        static void Main(string[] args)
        {
            var conLog = ConsoleLogWriter.ConsoleLogInstance;           
            var conLog2 = FileLogWriter.FileLogInstance;
            var argMult = new ILogWriter[] { conLog2, conLog };
            var MultLog = new MultipleLogWriter(argMult);
            foreach (var item in MultLog.LogWriter)
            {
                item.LogError("LogError");
                item.LogInfo("LogError");
                item.LogWarning("LogWarning");
            }            
        }
    }
}
