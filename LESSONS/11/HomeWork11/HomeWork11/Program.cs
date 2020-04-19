using System;

namespace HomeWork11
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2020, 4, 20, 11, 00, 00);
            var alarm1 = new Alarm(date1, "Звонок1");
            Console.WriteLine(alarm1.WriteProperties());
            DateTime date2 = new DateTime(2020, 4, 19, 22, 00, 00);
            var alarm2 = new Alarm(date2, "Звонок2");
            Console.WriteLine(alarm2.WriteProperties());
            Console.ReadKey();
        }
    }

}
