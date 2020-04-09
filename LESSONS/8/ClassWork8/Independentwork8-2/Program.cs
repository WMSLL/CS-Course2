using System;
using System.Collections.Generic;
using System.Linq;

namespace Independentwork8_2
{

    class Program
    {
        static void Main(string[] args)
        {
            var dictCountry = new Dictionary<string, string>() {
            { "Москва","Российская Федерация"},
            { "Вашингтон","США"},
            { "Берлин","Германия"},
            { "Токио","Япония"},
            { "Пекин","Китай"} };

            while (true)
            {
                var rnm = new Random().Next(1, 5);
                KeyValuePair<string, string> kpv = dictCountry.ElementAtOrDefault(rnm);
                var keyKpv = kpv.Key;
                var valueKpv = kpv.Value;
                Console.WriteLine($"Какая столица в {valueKpv}");
                var answer = Console.ReadLine().ToUpper();
                if (keyKpv.ToUpper() != answer)
                {
                    Console.WriteLine($"ответ {answer} не верный");
                    break;
                }
                Console.WriteLine($"ответ {answer}  верный");
            }
        }
    }
}
