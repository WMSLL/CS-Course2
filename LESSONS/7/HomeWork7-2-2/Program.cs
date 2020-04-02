using System;

namespace HomeWork7_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку из 2-х и более слов");
            var text = Console.ReadLine().ToLower();
            var reverseText = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverseText += text[i];
            }
            Console.WriteLine(reverseText);
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
