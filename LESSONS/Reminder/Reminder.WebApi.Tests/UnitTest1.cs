using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using Reminder.Storage.WebApi;
using Reminder.Storage;
using System;

namespace Reminder.WebApi.Tests
{
    public class Tests
    {
        // Поднять сервер
        // Сщздать клиент
        // Съходить клиентом на сервер
        [Test]
        public void Test1()
        {
            
            var factory =  new WebApplicationFactory<Startup>();
            var storage = new ReminderItemStorage(factory.CreateClient());
            var items = new ReminderItem[]{ new ReminderItem(
                    Guid.NewGuid()
                    , "Title"
                    , "Message"
                    , DateTimeOffset.UtcNow
                    , "Users"
                                         ) };
            storage.Add(items);
            foreach (var item in items)
            {               
                var result = storage.Find(item.Id);
                Assert.AreEqual(item.Message, result.Message);
            }
        }
    }
}