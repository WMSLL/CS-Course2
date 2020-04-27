using System;
using System.Collections.Generic;

namespace ClassWork14
{
    class ErrorList : IDisposable
    {
        public string Category { get; }
        public List<string> Error;

        
        public ErrorList(string category,List<string> Error)
        {
            Category = category;
             Error = new List<string>();
        }
        public void Dispose()
        {
            Error.Clear();
            Error = null;

        }        
    }
}
