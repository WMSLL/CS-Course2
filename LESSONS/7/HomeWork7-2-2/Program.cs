using System;
using System.Text;

namespace HomeWork7_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку из 2-х и более слов");
            var text = Console.ReadLine().ToLower();
            StringBuilder reverseText = new StringBuilder("", 50);
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverseText.Append(text[i]);
            }
            Console.WriteLine(reverseText);
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
