using System;

namespace ClassWork12
{
    public class BaseDoc
    {
        public string Title;
        public string Number;
        public DateTimeOffset IssueDate;
        public virtual string Discription => $"Title:{Title},Number:{Number}";

        public BaseDoc(string title, string number)
        {
            Number = number;
            Title = title;

        }
        public void WriteToConsole()
        {
            Console.WriteLine(Discription);
        }
    }

     class Passport : BaseDoc

    {
        public Passport(string nubmer,string Title) : base("21313", "passport")
        {

        }

        public string Country;
        public string PersonName;
        public override string Discription => $"Title:{Title},Number:{Number},Country{Country},{PersonName}";

    }
    class Program
    {
        static void Main(string[] args)
        {
            var pasport = new Passport("Passport", "123123");
            pasport.WriteToConsole();

            var person = new BaseDoc("Passport", "123123");
            person.WriteToConsole();
        }
    }
}
