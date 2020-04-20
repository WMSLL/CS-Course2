using System;

namespace ClassWork12
{
    public class BaseDoc
    {
        public string Title;
        public string Number;
        public DateTimeOffset IssueDate;
        public virtual string Discription => $"Title:{Title},Number:{Number}";
        
        public void WriteToConsole()
        {
            Console.WriteLine(Discription);
        }
    }

    public class Passport : BaseDoc
    {
        public string Country;
        public string PersonName;
        public override string Discription => $"Title:{Title},Number:{Number},Country{Country},{PersonName}";
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            var pasport = new Passport();
            Console.WriteLine(pasport.Discription);

            var person = new BaseDoc();
            Console.WriteLine(person.Discription);
        }
    }
}
