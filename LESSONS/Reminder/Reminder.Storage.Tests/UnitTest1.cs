using NUnit.Framework;
using System;

namespace Reminder.Storage.Tests
{
    public class Tests
    {
        

        [Test]
        public void Test1()
        {
           var f1 = new ReminderItemFilter(DateTimeOffset.UtcNow);

        }
    }
}