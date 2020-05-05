namespace HomeWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            var ar1 = new FileLogWriter();
            var ar2 = new ConsoleLogWriter();
            var log1 = new ILogWriter[]{ ar1, ar2};
            var multiLog = new MultipleLogWriter(log1);
            multiLog.LogInfo("Инфо");
            multiLog.LogWarning("Предуприждение");
            multiLog.LogError("Ошибка");
        }
    }
}
