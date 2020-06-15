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
            foreach (var items in reminder)
            {
                var exeption = Assert.Catch<KeyNotFoundException>(() => storage.Find(items.Id));
            }
        }
        [Test]
        public void WhenDeleteItemDoesnExist_ThenThrowsKeyNotFoundException()
        {
            var storage = new ReminderItemStorage();
            var newGuid = Guid.NewGuid();
            var exeption = Assert.Catch<KeyNotFoundException>(() => storage.Delete(newGuid));
        }

        [Test]
        public void WhenUpdateItemDoesnExist_ThenThrowsArgumentException()
        {
            var storage = new ReminderItemStorage();
            var reminder = new ReminderItem(Guid.NewGuid()
                                            , "Test1"
                                            , "Reminder1"
                                            , DateTimeOffset.UtcNow
                                            , "UserName");
            var exeption = Assert.Catch<ArgumentException>(() => storage.Update(reminder));
        }

        [Test]
        public void WhenUpdateItem_ThenCallFind()
        {
            var reminder = new ReminderItem(Guid.NewGuid()
                                              , "Test1"
                                              , "Reminder1"
                                              , DateTimeOffset.UtcNow
                                              , "UserName1");
            var reminder2 = new ReminderItem(Guid.NewGuid()
                                              , "Test2"
                                              , "Reminder2"
                                              , DateTimeOffset.UtcNow.AddMinutes(-1)
                                              , "UserName2");
            
              var storage = new ReminderItemStorage(new[] { reminder, reminder2 });
            reminder.Message = "Message2205";
            var exeption = Assert.Catch<ArgumentException>(() => storage.Update(reminder));
            Console.WriteLine(reminder.Message);
            Assert.AreEqual("Message2205",reminder.Message);

           // Assert.AreEqual();
        }
    }
}