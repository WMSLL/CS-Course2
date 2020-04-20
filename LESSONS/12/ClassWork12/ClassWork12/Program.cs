using System;

namespace ClassWork12
{
    public class BaseDoc
    {
        public string Title;
        public string Number;
        public DateTimeOffset IssueDate;
        public virtual string Discription => $"Title:{Title},Number:{Number}";
        
        public BaseDoc(string Title, string Number, DateTimeOffset IssueDate)
        {

        }
        public void WriteToConsole()
        {
            Console.WriteLine(Discription);
        }
    }

    public class Passport(string title,string number, DateTimeOffset issueDate) : BaseDoc Base(string title, string number, DateTimeOffset issueDate))

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
           pasport.WriteToConsole();

            var person = new BaseDoc();
            person.WriteToConsole();
        }
    }
}
