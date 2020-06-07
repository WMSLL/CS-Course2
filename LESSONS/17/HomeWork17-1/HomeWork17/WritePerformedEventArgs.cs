using System;

namespace HomeWork17
{
    public class WritePerformedEventArgs : EventArgs
    {
        public   byte[] DataSet { get; set; }
        public WritePerformedEventArgs(byte[] dataSet)
        {
            DataSet = dataSet;
        }  
    }
}
    
