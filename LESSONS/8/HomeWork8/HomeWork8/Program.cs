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
                var line =Console.ReadLine();
                if (line.ToUpper() == "EXIT")
                {
                    break;
                }
                Console.WriteLine(CheckPltBrts(line));
            }            
        }

        static bool CheckPltBrts(string value)
        {           
            var checkStack = new Stack<char>();
            foreach (var brackets in value)
            {
                switch (brackets)
                {
                    case '[':
                    case '(':
                        checkStack.Push(brackets);
                        break;
                    case ']':
                        if (checkStack.Count == 0) return false;
                        if (checkStack.Pop() != '[') return false;
                        break;
                    case ')':
                        if (checkStack.Count == 0) return false;
                        if (checkStack.Pop() != '(') return false;
                        break;
                    default:
                        if (checkStack.Count == 0) return false;
                        break;
                }
            }
            return checkStack.Count == 0;
        }
    }
}
