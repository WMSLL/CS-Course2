using System;

namespace ClassWork12
{
    public class BaseDoc
    {
        public string Title;
        public string Number;
        public DateTimeOffset IssueDate;
        public string Discription => $"Title:{Title},Number:{Number}";
        
        public void WriteToConsole()
        {
            Console.WriteLine(Discription);
        }
    }

    public class Passport : BaseDoc
    {
        public string Country;
        public string PersonName;
        public new string Discription => $"Title:{Title},Number:{Number},Country{Country},{PersonName}";
        public  new void  WriteToConsole()
        {
             Console.WriteLine(Discription);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Passport.WriteToConsole();
        }
    }
}
