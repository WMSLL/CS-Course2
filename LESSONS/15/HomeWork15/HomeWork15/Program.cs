namespace HomeWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            var ar1 = new FileLogWriter("LogError.txt");
            var ar2 = new ConsoleLogWriter();
            var log1 = new ILogWriter[]{ ar1, ar2};
            var multiLog = new MultipleLogWriter(log1);
            multiLog.LogInfo("LogInfo new123 1");
            multiLog.LogError("LogError new1 23213 ");
            multiLog.LogWarning("LogWarning new1 231 3 31");
        }
    }
}
