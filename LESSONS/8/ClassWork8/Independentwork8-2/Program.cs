using System;
using System.Collections.Generic;

namespace Independentwork8_2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var dictCountry = new Dictionary<int, string>() { 
            { 1,"Российская Федерация"},
            { 2,"США"},
            { 3,"Германия"},
            { 4,"Япония"},
            { 5,"Китай"} };

            var dictСapital = new Dictionary<int, string>() {
            { 1,"Москва"},
            { 2,"Вышингтон"},
            { 3,"Берлин"},
            { 4,"Токио"},
            { 5,"Пекин"} };

            var rnm = new Random().Next(1, 5);

            var country = dictCountry[rnm] ;

            Console.WriteLine($"Какая столица у {country}");

            var Сapital=Console.ReadLine();

            Console.WriteLine();

            




        }
    }
}
