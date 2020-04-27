using System;
using System.Collections.Generic;
namespace ClassWork14
{
    class Program
    {
        static void Main(string[] args)
        {


            using (var errors = new ErrorList( "Warning",  new List<string> { "xth", "zfs", "qwe"} ))
            {
                foreach (var item in errors.Error)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
