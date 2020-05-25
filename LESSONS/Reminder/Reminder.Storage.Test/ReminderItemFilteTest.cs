using NUnit.Framework;
using System;
using Reminder.Storage.Memory;


namespace Reminder.Storage.Test
{
    public class ReminderItemFilteTest
    {
        [Test]
        public void Test1()
        {
            var f1 = ReminderItemFilter.ByStatus(ReminderItemStatus.Ready);
            var f2 = ReminderItemFilter.FromNow();
        }
        [Test]
       public void GivenCreatedItem_WhenFrindByReadyStatus_ShouldReturnEmpty()
        {
            var storage = new ReminderItemStorage();
            var Reminder = new[]
            { new ReminderItem(Guid.NewGuid(), "Title1", "Message1", DateTimeOffset.UtcNow, "User_id1") ,
              new ReminderItem(Guid.NewGuid(), "Title2", "Message2", DateTimeOffset.UtcNow.AddSeconds(-20), "User_id2"),
             new ReminderItem(Guid.NewGuid(), "Title3", "Message3", DateTimeOffset.UtcNow.AddSeconds(+20), "User_id3")};
            storage.Add(Reminder);
            var result =storage.FindBy(ReminderItemFilter.ByStatus(ReminderItemStatus.Ready));
            Assert.IsEmpty(result);

        }
        [Test]
        public void GivenCreatedItem_WhenFrindFromNow_ShouldReturnMatchengElements()
        {
            var storage = new ReminderItemStorage();
            var Reminder = new[]
            { new ReminderItem(Guid.NewGuid(), "Title1", "Message1", DateTimeOffset.UtcNow.AddSeconds(20), "User_id1") ,
              new ReminderItem(Guid.NewGuid(), "Title2", "Message2", DateTimeOffset.UtcNow.AddSeconds(-60), "User_id2"),
             new ReminderItem(Guid.NewGuid(), "Title3", "Message3", DateTimeOffset.UtcNow.AddSeconds(+60), "User_id3")};
            storage.Add(Reminder);
            var result = storage.FindBy(ReminderItemFilter.FromNow());
            Assert.IsNotEmpty(result);
            Assert.AreEqual(1,result.Length);
            Assert.AreEqual("Message2", result[0].Message);

        }
    }
}