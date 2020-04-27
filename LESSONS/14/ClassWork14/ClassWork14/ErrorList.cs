using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassWork14
{
    class ErrorList : IEnumerable<string>,IDisposable
    {
        public string Category { get; }
        private List<string> _error;

        
        public ErrorList(string category,List<string> error)
        {
            Category = category;
            _error = error;
        }
        public void Dispose()
        {
            _error.Clear();
            _error = null;

        }
        public void Add(string errorMessage)
        {
            _error.Add(errorMessage);
        }

        public IEnumerator<string> GetEnumerator()
        {
            return _error.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return  _error.GetEnumerator();
        }
    }
}
