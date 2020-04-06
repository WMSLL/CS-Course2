using System;
using System.Collections.Generic;
namespace ClassWork8
{
    class Program
    {
        static void Main(string[] args)
        {

            var dictionariDD = new Dictionary<int, string>();
            dictionariDD.Add(1, "Russia");
            dictionariDD.Add(2, "Greate Britain");
            dictionariDD.Add(3, "USA");
            Console.WriteLine(string.Join(",", dictionariDD));
            Console.WriteLine(dictionariDD);


            // var integer = new List<int>();
            // integer.Add(10);
            // integer.Add(20);
            // integer.Add(3);
            // integer.Add(22);
            // integer.Add(54);
            // integer.Add(21);
            //
            // Console.WriteLine(string.Join(",",integer));
            //
            //
            // var stri = new List<string>();
            // stri.Add("stri");
            // stri.Add("ss");
            // stri.Add("sdjdn");
            // stri.Add("sdjdn");
            // stri.Add("sdjdn");
            // stri.Add("sdjdn");
            //
            // Console.WriteLine(string.Join(",", stri));
        }
    }
}
