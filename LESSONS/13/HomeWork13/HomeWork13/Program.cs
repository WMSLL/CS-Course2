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

            foreach (var item in multiLog.Logger)
            {
                item.LogError("Message Error");
                item.LogInfo("Message Info");
                item.LogWarning("Message LogWarning");            
            }
        }
    }
}
