using System;
namespace HomeWork10
{
    public class Employee
    {
        public string Name { set; get; }
        int _age;
        public int Age
        {
            set { _age = value; }
            get { return _age; }
        }
        int _ageAfter
        {
            get { return _age + 4; }
        }
        public string EndLine
        {
            get { return $"Сотруднику {Name} Через 4-ре года будет {_ageAfter} "; }
        }

        public Employee(string aName, int age)
        {
            Name = aName;
            Age = age;
        }

        public string OutPut()
        {
            return EndLine;
        }




    }
}