namespace HomeWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            var clw = LogWriteFactory.Instance.GetLogWriter<ConsoleLogWriter>(null);
            clw.LogError("Message LogError Console1");
            clw.LogWarning("Message LogWarning Console");
            clw.LogInfo("Message LogInfo Console");

            var flw = LogWriteFactory.Instance.GetLogWriter<FileLogWriter>("LogFile.Txt");
            flw.LogError("Message LogError File");
            flw.LogWarning("Message LogWarning File");
            flw.LogInfo("Message LogInfo File");

            var Mlw = LogWriteFactory.Instance.GetLogWriter<MultipleLogWriter>(new[] { clw , flw });
            Mlw.LogError("Message MultipleLogWriter File");
            Mlw.LogWarning("Message MultipleLogWriter File");
            Mlw.LogInfo("Message MultipleLogWriter File");
        }
    }


}
