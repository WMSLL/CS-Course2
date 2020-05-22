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
            var dic = new Dictionary<Guid, ReminderItem>();
            var storage = new ReminderItemStorege(dic);
            var reminderItem = new ReminderItem(Guid.NewGuid(), "Good", "Message", DateTimeOffset.UtcNow, "UserName");
            storage.Add(reminderItem);
            var result = storage.Find(reminderItem.id);
            Assert.NotNull(result);
            Assert.AreEqual(reminderItem.id,result.id);
            Assert.AreEqual(reminderItem.Message, result.Message);          
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
            var dic = new Dictionary<Guid, ReminderItem>();
            var storage = new ReminderItemStorege(dic);
            var reminderItem = new ReminderItem(Guid.NewGuid(), "Good", "Message", DateTimeOffset.UtcNow, "UserName");
            storage.Add(reminderItem);
            Assert.Catch<ArgumentException>(() => storage.Add(reminderItem));
        }               
        
        [Test]
        public void WhenUpdate_then()
        {
            var storage = new ReminderItemStorege(null);
            Assert.Catch<ArgumentNullException>(() => storage.Update(null));          
        }





    }
}