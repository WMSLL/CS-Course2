using System;

namespace ClassWork10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Pet = new Pet()
            {
                _age = 12,
                _kind = "Dog",
                _name = "bob",
                _sex = 'M'
            };
            Console.WriteLine($"Питомец {Pet._kind} Кличка {Pet._name} Возраст {Pet._age} Пол {Pet._sex}");

            var Pet2 = new Pet();
            Pet2._age = 14;
            Pet2._kind = "Cat";
            Pet2._name = "Tom";
            Pet2._sex = 'm';

            Console.WriteLine($"Питомец {Pet2._kind} Кличка {Pet2._name} Возраст {Pet2._age} Пол {Pet2._sex}");
        }


    }
}
