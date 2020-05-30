using System;
using System.IO;

namespace HomeWork17
{
    class FileWriterWithProgress
    {
        public event EventHandler<WritePerformedEventArgs> WritePerformed;
        public event EventHandler WriteCompleted;
        public void WriteBytes(string fileName, WritePerformedEventArgs dataSet, float percentageToFireEvent)
        {
            var lenght =dataSet.DataSet.Length ;
            for (int i = 0; i < lenght; i++)
            {
                File.AppendAllText(fileName, dataSet.DataSet[i].ToString() + Environment.NewLine);
                if (i % (percentageToFireEvent * 100.0f) == 0)
                {
                    WritePerformed?.Invoke(this, dataSet);
                }
            }
            WriteCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
