using System;
using System.Collections.Generic;

namespace HomeWork12

{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Alarm>
            {
                new PhonePhoneReminderItem(DateTime.Parse("23.04.2020 16:50"),"Звонок PhonePhoneReminderItem","954-433-22-11"),
                new ChatReminderItem(DateTime.Parse("23.04.2020 16:50"),"Звонок ChatReminderItem","Чат одуванчик","Егорка"),
                new Alarm(DateTime.Parse("23.04.2020 16:50"),"Звонок Alarm")
            };
            foreach (var item in list)
            {
                Console.WriteLine("Type: " + item.ToString() + "  :" + item.WriteProperties());
            }
        }
    }
}