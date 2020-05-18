using System; 

namespace HomeWork17
{
    class FileWriterWithProgress
    {
        public event Action<byte[]> GenAct;

        public void WriteBytes(string fileName, byte[] data, float percentageToFireEvent)
        {
            
        }
    }
}
