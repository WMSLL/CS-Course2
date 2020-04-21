using System;

namespace ClassWork12
{

    class Program
    {
        static void Main(string[] args)
        {

            BaseDoc[] docs = new[]
                {
                new Passport("123123",DateTime.Parse("20.12.1980")),
                 new BaseDoc("DriverCertification","12312323"),
                  new Passport("123123",DateTime.Parse("20.12.1980")),
                  new BaseDoc("DriverCertification","2123ds231"),
                };

            foreach (var docType in docs)
            {
                if (docType is Passport)
                {
                    docType.ChangeIssueDate();
                }
                docType.WriteToConsole();
            }
        }

        public class BaseDoc
        {
            public string Title;
            public string Number;
            public DateTimeOffset IssueDate;
            public virtual string Discription => $"Title : {Title},Number : {Number},IssueDate : {IssueDate}";
            public BaseDoc(string title, string number)
            {
                Number = number;
                Title = title;
            }
            public void WriteToConsole()
            {
                Console.WriteLine(Discription);
            }
            public virtual void ChangeIssueDate()
            {
                IssueDate = DateTimeOffset.Now;
            }
        }

        class Passport : BaseDoc

        {
            public Passport(string number, DateTimeOffset issueDate) : base("passport", number)
            {

            }
            public string Country = "Russia";
            public string PersonName = "Valera";
            public override void ChangeIssueDate()
            {
                IssueDate = DateTimeOffset.Now;
            }
            public override string Discription => $"Title:{Title},Number:{Number},Country:{Country},PersonName:{PersonName},IssueDate:{IssueDate}";
        }
    }
}
