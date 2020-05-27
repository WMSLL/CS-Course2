using Reminder.Domain;
using Reminder.Receiver.Telegram;
using Reminder.Sender.Telegram;
using Reminder.Storage.Memory;
using System;

namespace Reminder
{
    class Program
    {
        static void Main(string[] args)
        {
            const string token = "1195265347:AAFqPN_gjbV95a369tnRuysJKSNt4DVn9ms";
            var SchedulerSettings =
                new ReminderSchedulerSettings(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(10));

            using var scheduler = new ReminderScheduler(
               new ReminderItemStorage(),
               new ReminderItemReceiver(token),
               new ReminderItemSender(token),
               SchedulerSettings);            
            scheduler.Run();
            Console.WriteLine("Scheduler working");
            Console.ReadKey();
        }
    }
}
