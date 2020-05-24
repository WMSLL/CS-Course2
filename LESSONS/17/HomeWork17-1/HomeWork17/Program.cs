using System;

namespace HomeWork17
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileWriter = new FileWriterWithProgress();
            fileWriter.WritePerformed += ActionsEvent;
            fileWriter.WriteCompleted += EndEvent;
            var random = new Random();
            var array = new byte[100];
            random.NextBytes(array);
            fileWriter.WriteBytes("FileByteLog.txt", array, 0.1f);
        }
        private static void EndEvent(object sender, EventArgs e)
        {
            Console.WriteLine($"Сгенерировано Конечное событие {sender}");
        }
        private static void ActionsEvent(object sender, byte e)
        {
            Console.WriteLine($"Сгенерировано событие {e}");
        }
    }
}
