namespace HomeWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            var fac = LogWriteFactory.Factory;

            var fileLog = fac.GetLogWriter(new FileLogWriter("FileLog1100.txt"));
            fileLog.LogError("LogError 3");
            fileLog.LogWarning("LogWarning 2");
            fileLog.LogInfo("LogInfo 1");

            var consoleLog = fac.GetLogWriter(new ConsoleLogWriter());
            consoleLog.LogError("consoleLog LogError 4");
            consoleLog.LogWarning("consoleLog LogWarning 5");
            consoleLog.LogInfo("consoleLog LogInfo 6");
        }
    }


}
