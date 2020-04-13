using System;
using System.Collections.Generic;


namespace HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите набор скобок [],() для выхода наберите EXIT");
                var line = Console.ReadLine();
                if (line.ToUpper() == "EXIT")
                {
                    break;
                }
                Console.WriteLine(CheckPltBrts(line));
            }
        }

        static bool CheckPltBrts(string value)
        {
            var validDict = new Dictionary<char,char>();
            validDict.Add('[', ']');
            validDict.Add('(', ')');

            var checkStack = new Stack<char>();
            foreach (var brackets in value)
            {
                Console.WriteLine(validDict.TryGetValue(brackets,out var t));

                
               //switch (brackets)
               //{
               //    case '[':
               //    case '(':
               //        checkStack.Push(brackets);
               //        break;
               //    case ']':
               //        if (checkStack.Count == 0) return false;
               //        if (checkStack.Pop() != '[') return false;
               //        break;
               //    case ')':
               //        if (checkStack.Count == 0) return false;
               //        if (checkStack.Pop() != '(') return false;
               //        break;
               //}
            }
            return checkStack.Count == 0;
        }
    }
}
