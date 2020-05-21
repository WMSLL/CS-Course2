using System;
using System.IO;

namespace HomeWork17
{
    class FileWriterWithProgress
    {
        public event Action<byte> WritePerformed;
        public event Action<byte> WriteCompleted;
        public void WriteBytes(string fileName, byte[] data, float percentageToFireEvent)
        {
            var lenght = data.Length;
            for (int i = 0; i < lenght; i++)
            {
                File.AppendAllText(fileName, data[i].ToString() + Environment.NewLine);
                if (i % (percentageToFireEvent * 100.0f) == 0)
                {
                    WritePerformed(data[i]);
                }
                if (i == lenght - 1)
                {
                    WriteCompleted(data[i]);
                }
            }
        }
    }
}
