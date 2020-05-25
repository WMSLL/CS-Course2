using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Reminder.Storage.Memory.Tests
{
    public class ReminderItemStorageTests
    {
        [Test]
        public void WhenItemIsNull_ThenThrowsArgumentNullException()
        {
            var storage = new ReminderItemStorage();
            Assert.Catch<ArgumentNullException>(() => storage.Add(null));
        }
        [Test]
        public void WhenItemExists_ThenThrowsArgumentException()
        {
            var storage = new ReminderItemStorage();
            var reminder = new ReminderItem[]{ new ReminderItem(Guid.NewGuid()
                                            , "Test1"
                                            , "Reminder1"
                                            , DateTimeOffset.UtcNow
                                            , "UserName") };
            storage.Add(reminder);
            foreach (var items in reminder)
            {
                var exeption = Assert.Catch<ArgumentException>(() => storage.Add(reminder));
                Assert.IsTrue(exeption.Message.Contains(items.Title));
                Assert.IsTrue(exeption.Message.Contains(items.Id.ToString()));
            }

        }
        [Test]
        public void WhenItemNotExists_ThenCanFindById()
        {
            var storage = new ReminderItemStorage();
            var reminder = new ReminderItem[]{ new ReminderItem(Guid.NewGuid()
                                            , "Test1"
                                            , "Reminder1"
                                            , DateTimeOffset.UtcNow
                                            , "UserName") };
            storage.Add(reminder);
            foreach (var items in reminder)
            {
                var exeption = Assert.Catch<KeyNotFoundException>(() => storage.Find(items.Id));
            }

        }

        [Test]
        public void WhenFindByDateTime()
        {

            var storage = new ReminderItemStorage();
            var reminder = new ReminderItem[]{ new ReminderItem(Guid.NewGuid()
                                            , "Test1"
                                            , "Reminder1"
                                            , DateTimeOffset.UtcNow
                                            , "UserName") };
            storage.Add(reminder);
            Assert.Catch <ArgumentNullException>(()=>storage.FindByDateTime(DateTimeOffset.UtcNow));
        }
        
    }
}