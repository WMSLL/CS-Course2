using System;

namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {   
            var emp = new Employee();
            string[] names = new string[3];
            int[] age = new int[3];
            for (var i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Enter the name of the {i + 1}st employee");
                names[i] = Console.ReadLine();
            }
            for (var i = 0; i < age.Length; i++)
            {
                Console.WriteLine($"Enter the employee's {names[i]} age ");
                age[i] = int.Parse(Console.ReadLine());
            }     
            emp.Name = names;
            emp.age = age;
            emp.OutPut();
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
    }
}