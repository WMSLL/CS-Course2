using System;
using System.Text;

namespace HomeWork7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите строку из 2-х и более слов");
                var text = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(text))
                {
                    continue;
                }
                var reverseText = text.ToLower().ToCharArray();
                Array.Reverse(reverseText);
                Console.WriteLine(reverseText);
                break;
            }
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
