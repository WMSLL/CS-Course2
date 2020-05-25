using Reminder.Domain;
using Reminder.Storage;
using Reminder.Storage.Memory;
using System;

namespace Reminder
{
    class Program
    {
        static void Main(string[] args)
        {
            var storage = new ReminderItemStorage();
            var Reminder = new[]
            { new ReminderItem(Guid.NewGuid(), "Title1", "Message1", DateTimeOffset.UtcNow, "User_id1") ,
              new ReminderItem(Guid.NewGuid(), "Title2", "Message2", DateTimeOffset.UtcNow.AddSeconds(+5), "User_id2"),
             new ReminderItem(Guid.NewGuid(), "Title3", "Message3", DateTimeOffset.UtcNow.AddSeconds(+20), "User_id3")};
            storage.Add(Reminder);
            var rSchedulerSettings = 
                new ReminderSchedulerSettings( TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(10));
           using var scheduler = new ReminderScheduler(storage, rSchedulerSettings);

            scheduler.RimenderSend += (sender, args) => Console.WriteLine(args.Message);

            scheduler.Run();

            Console.WriteLine("Scheduler working");
            Console.ReadKey();
        }
    }
}
