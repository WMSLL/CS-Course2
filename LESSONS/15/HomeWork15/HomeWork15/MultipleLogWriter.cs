﻿using System;
using System.IO;
namespace HomeWork13
{
    class MultipleLogWriter : ILogWriter
    {
        public void LogInfo(string message)
        {           
        }
        public void LogWarning(string message)
        {
        }
        public void LogError(string message)
        {
            
        }
        public MultipleLogWriter(ILogWriter[] arg)
        {
           
        } 
    }
}
