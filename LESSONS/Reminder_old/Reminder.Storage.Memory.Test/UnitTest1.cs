using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Reminder.Storage.Memory.Test
{

    public class ReminderStoregeMemoryTests
    {
        [Test]
        public void WhenItemNotExists_ThenCanFindById()
        {
            var reminderItem1 = new ReminderItem(Guid.NewGuid(), "Good-reminderItem1", "Message-reminderItem1", DateTimeOffset.UtcNow, "UserName");
            var reminderItemArray = new ReminderItem[] { reminderItem1 };
            var storage = new ReminderItemStorege(reminderItemArray);
            foreach (var item in reminderItemArray)
            {
                storage.Add(item);
                var result = storage.Find(item.id);
                Assert.NotNull(result);
                Assert.AreEqual(item.id, result.id);
                Assert.AreEqual(item.Message, result.Message);
            }
        }
        [Test]
        public void WhenItemIsNull_ThenThrowsArgumentNullException()
        {
            var storage = new ReminderItemStorege(null);
            Assert.Catch<ArgumentNullException>(() => storage.Add(null));
        }
        [Test]
        public void WhenItemExists_ThenArgumentException()
        {
            var reminderItem1 = new ReminderItem(Guid.NewGuid(), "Good-reminderItem1", "Message-reminderItem1", DateTimeOffset.UtcNow, "UserName");
            var reminderItem2 = new ReminderItem(Guid.NewGuid(), "Good-reminderItem2", "Message-reminderItem2", DateTimeOffset.UtcNow, "UserName");
            var reminderItemArray = new ReminderItem[] { reminderItem1, reminderItem2 };
            var storage = new ReminderItemStorege(reminderItemArray);
            foreach (var item in reminderItemArray)
            {
                storage.Add(item);
                Assert.Catch<ArgumentException>(() => storage.Add(item));
            }
        }               

        [Test]

        public void WhenDeleteAndNotExistsItem_ThenArgumentException()
        {           
            var reminderItemArray = new ReminderItem[] { new ReminderItem(Guid.NewGuid(), "Good-reminderItem1", "Message-reminderItem1", DateTimeOffset.UtcNow, "UserName")
                                                       , new ReminderItem(Guid.NewGuid(), "Good-reminderItem2", "Message-reminderItem2", DateTimeOffset.UtcNow, "UserName") };
            var storage = new ReminderItemStorege(reminderItemArray);
            foreach (var item in reminderItemArray)
            {
               
                storage.Add(item);
                storage.Delete(item.id);
                Assert.Catch<ArgumentException>(() => storage.Add(item));
            }
        }
        
        [Test]
        public void WhenUpdate_then()
        {
            var storage = new ReminderItemStorege();
            Assert.Catch<ArgumentNullException>(() => storage.Update(null));          
        }





    }
}