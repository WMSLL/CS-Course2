using System;
namespace HomeWork10
{
    public class Employee
    {
        public string[] name;
        public int[] age;
        static int Age4Years { get; set; }
        static string EndLine { get; set; }        
        public void OutPut()
        {
            for (int i = 0; i < age.Length; i++)
            {
                Age4Years = age[i] + 4;
                EndLine = $"Name: {name[i]}, age in 4 years :{Age4Years}";
                Console.WriteLine(EndLine);
            }
        }
    }
}