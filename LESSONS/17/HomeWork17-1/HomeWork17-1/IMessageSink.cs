using System;
using System.IO;

namespace HomeWork17_1
{
    public interface IMessageSink
    {
         string _messega { get; }

      
        public void MessageParsing()
        {
            
            var date = DateTime.ParseExact(_messega, "dd.MM.yyyy", null);
            
        }
            

    }

}
