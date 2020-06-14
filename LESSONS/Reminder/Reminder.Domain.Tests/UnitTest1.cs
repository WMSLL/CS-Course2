using NUnit.Framework;
using Reminder.Storage.Memory;
using System;
using Reminder.Storage;
using Reminder.Receiver;
using Reminder.Sender;
using System.Threading;

namespace Reminder.Domain.Tests
{
    internal class ReminderItemReceiver : IReminderItemRecieiver
    {
        public event EventHandler<MessageReceiventEventArgs> MessageReceivet;
    }
    internal class ReminderItemSender : IReminderItemSender
    {
        public void send(ReminderNotification notification)
        {
            
        }
    }
    public class Tests
    {
        [Test]
        public void GivenItemWhithCreatedStatus_whenRunInvokedAnd_ThenStatusChangedToSent()
        {            
            var reminder = new ReminderItem[]{ new ReminderItem(Guid.NewGuid()
                                            , "Test1"
                                            , "Reminder1"
                                            , DateTimeOffset.UtcNow.AddMinutes(-1)
                                            , "UserName") };
            var storage = new ReminderItemStorage(reminder);

            using var cheduler = new ReminderScheduler(
                storage,
                new ReminderItemReceiver(),
                new ReminderItemSender(),
                new ReminderSchedulerSettings(TimeSpan.FromMilliseconds(300), 
                                               TimeSpan.FromMilliseconds(3000))
                );

            cheduler.Run();
            Thread.Sleep(TimeSpan.FromMilliseconds(800));
            var item = storage.FindBy( ReminderItemFilter.ByStatus(ReminderItemStatus.Sent));
            // goto нет sleep
            Assert.IsNotNull(item);
        }
        [Test]
        public void test2()
        {
            var reminder = new ReminderItem[]{ new ReminderItem(Guid.NewGuid()
                                            , "Test1"
                                            , "Reminder1"
                                            , DateTimeOffset.UtcNow.AddMinutes(-1)
                                            , "UserName") };
            var storage = new ReminderItemStorage(reminder);

            using var cheduler = new ReminderScheduler(
                storage,
                new ReminderItemReceiver(),
                new ReminderItemSender(),
                new ReminderSchedulerSettings(TimeSpan.FromMilliseconds(300),
                                               TimeSpan.FromMilliseconds(500))
                );

            cheduler.Run();
            Thread.Sleep(TimeSpan.FromMilliseconds(800));
            var item = storage.FindBy(ReminderItemFilter.ByStatus(ReminderItemStatus.Filed));
            // goto нет sleep
            Assert.IsNotNull(item);
        }

    }

    
}