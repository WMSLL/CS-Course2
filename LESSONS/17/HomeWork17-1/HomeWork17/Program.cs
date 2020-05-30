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
            var wPEA = new WritePerformedEventArgs(array);
            fileWriter.WriteBytes("FileByteLog.txt", wPEA, 0.1f);
        }

        private static void ActionsEvent(object sender, WritePerformedEventArgs e)
        {          
                Console.WriteLine($"Сгенерировано событие {e}");            
        }

        private static void EndEvent(object sender, EventArgs e)
        {
            Console.WriteLine($"Сгенерировано Конечное событие {sender}");
        }
     
    }
}
