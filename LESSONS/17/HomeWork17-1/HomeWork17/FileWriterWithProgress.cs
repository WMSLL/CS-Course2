using System;
using System.IO;

namespace HomeWork17
{
    class FileWriterWithProgress
    {
        public event EventHandler<WritePerformedEventArgs> WritePerformed;
        public event EventHandler WriteCompleted;
        public void WriteBytes(string fileName, byte[] dataSet, float percentageToFireEvent)
        {
            var lenght =dataSet.Length ;
            for (int i = 0; i < lenght; i++)
            {
                File.AppendAllText(fileName, dataSet[i].ToString() + Environment.NewLine);
                if (i % (percentageToFireEvent * 100.0f) == 0)
                {
                    WritePerformed?.Invoke(this,new WritePerformedEventArgs(dataSet) );
                }
            }
            WriteCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
