using System;
using System.Collections.Generic;

namespace HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите набор скобок {},[],() ");
            Console.WriteLine(InputStack(Console.ReadLine()));
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }

        static bool InputStack(string s)
        {
            var stack = new Stack<char>();           
            foreach (var c in s)
            {
                switch (c)
                {
                    case '{':
                    case '(':
                    case '[':
                        stack.Push(c);                      
                        break;
                    case '}':
                        if (stack.Count == 0) return false;
                        if (stack.Pop() != '{') return false;
                        break;
                    case ']':
                        if (stack.Count == 0) return false;
                        if (stack.Pop() != '[') return false;
                        break;
                    case ')':
                        if (stack.Count == 0) return false;
                        if (stack.Pop() != '(') return false;
                        break;
                }
            }
            return stack.Count == 0;
        }       
    }
}
