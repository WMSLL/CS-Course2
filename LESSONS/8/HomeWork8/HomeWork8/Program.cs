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
            var validDict = new Dictionary<char, char>();
            validDict.Add(']', '[');
            validDict.Add(')', '(');
            var checkStack = new Stack<char>();
            foreach (var item in value)
            {
                if (validDict.ContainsValue(item))
                {
                    checkStack.Push(item);
                }
                if (validDict.ContainsKey(item))
                {
                    if (checkStack.Count == 0) return false;
                    if (checkStack.Pop() != validDict.GetValueOrDefault(item)) return false;
                }
            }
            return checkStack.Count == 0;
        }
    }
}
