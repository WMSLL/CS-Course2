namespace HomeWork14
{
    class Program
    {
        static void Main(string[] args)
        {
            var conLog = ConsoleLogWriter.ConsoleLogInstance;
            conLog.LogError("asdasd");
            var conLog2 = FileLogWriter.FileLogInstance;
            conLog2.LogError("asdasd");
        }
    }
}
