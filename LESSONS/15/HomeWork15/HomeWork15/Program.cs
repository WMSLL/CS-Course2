namespace HomeWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            var ar1 = new FileLogWriter("LogError.txt");
            var ar2 = new ConsoleLogWriter();
            var log1 = new ILogWriter[]{ ar1, ar2};
            var factory = LogWriteFactory.Factory;
            var consLogWri = factory.GetLogWriter(new MultipleLogWriter(log1));
            consLogWri.LogInfo("LogInfo  1");
            consLogWri.LogError("LogError new1  ");
            consLogWri.LogWarning("LogWarning new1  3 31"); 
        }
    }
    

}
