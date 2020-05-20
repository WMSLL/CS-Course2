using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Reminder.Storage.Memory.Test
{
       
    public class ReminderStoregeMemoryTests
    {
        [Test]
        public void WhenItemIsNull_ThenThrowsArgumentNullException()
        {
            var storage = new ReminderItemStorege();           
            Assert.Catch<ArgumentNullException>(() => storage.Add(null));
        }

        [Test]
        public void WhenItemExists_ThenArgumentException()
        {            
            var storage = new ReminderItemStorege();
            Assert.Catch<ArgumentNullException>(() => storage.Add(null));
        }


    }
}