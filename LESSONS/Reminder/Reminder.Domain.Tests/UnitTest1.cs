using NUnit.Framework;
using Reminder.Storage.Memory;
using Reminder.Receiver.Telegram;
using Reminder.Sender.Telegram;
using System;

namespace Reminder.Domain.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            const string token = "1195265347:AAFqPN_gjbV95a369tnRuysJKSNt4DVn9ms";
            var SchedulerSettings =
                new ReminderSchedulerSettings(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(10));
            var she = new ReminderScheduler(
                                  new ReminderItemStorage()
                                , new ReminderItemReceiver(token)
                                , new ReminderItemSender(token)
                                , SchedulerSettings);
            she.Run();

            //Assert.Pass();
        }
    }
}