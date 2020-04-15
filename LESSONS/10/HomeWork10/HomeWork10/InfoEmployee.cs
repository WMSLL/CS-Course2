using System;

namespace HomeWork10
{
    class InfoEmployee
    {
        public int Age;
        public string Name;
       
        public void Employee()
        {
            Age= int.Parse(Console.ReadLine());
            var arreyCount = 3;
            var age = new int[arreyCount];
            var name = new string[arreyCount];

            for (int i = 0; i < age.Length; i++)
            {
                age[i] = Age;
                System.Console.WriteLine($"{age[i]}");
            }

            for (int i = 0; i < name.Length; i++)
            {
                name[i] = Name;
                System.Console.WriteLine($"{name[i]}");
            }

           

        }
    }
}
