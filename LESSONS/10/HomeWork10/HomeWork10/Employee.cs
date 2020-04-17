using System;
namespace HomeWork10
{
    public class Employee
    {
        static string _name;
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        static int _age;
        public int Age
        {
            set { _age = value; }
            get { return _age; }
        }
        static int _ageAfter
        {
            get { return _age + 4; }
        }
        public string EndLine{
            get { return $"Сотруднику {Name} Через 4-ре года будет {_ageAfter} "; }
        }      

       public Employee(string aName,int age)
        {
            Name = aName;
            Age = age;

        }

        public void OutPut()
        {
            Console.WriteLine(EndLine);
        }




    }
}