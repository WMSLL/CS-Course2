using System;

namespace HomeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Введите строку из 2-х и более слов");
                var text = Console.ReadLine();
                var spliText = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (spliText.Length <= 1)
                {
                    continue;
                }
                foreach (var word in spliText)
                {
                    if (word.ToUpper().Substring(0, 1) == "А")
                    {
                        sum++;
                    }
                }
                Console.WriteLine($"Количество слов начинающихся с буквы ''A'' {sum}");
                break;
            }
        }
    }
}
