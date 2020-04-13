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
            Console.WriteLine(Pet.InfoPet());

        }


    }
}
