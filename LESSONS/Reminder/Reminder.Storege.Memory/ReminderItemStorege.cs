using System;
using System.Collections.Generic;
namespace Reminder.Storage.Memory
{
    public class ReminderItemStorege : IReminderItem
    {
        private Dictionary<Guid, ReminderItem> _item;

        public ReminderItemStorege()
        {
        }

        public ReminderItemStorege(Dictionary<Guid, ReminderItem> item)
        {
            _item = item;
        }
        //
        //
        public void Add(ReminderItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
           
            var key = item.id;
            _item.Add(key, item);
        }   

        public void Delete(Guid id)
        {           
        }

        public ReminderItem Find(Guid id)
        {
            throw new NotImplementedException();
        }

        public ReminderItem[] FindByDateTime(DateTimeOffset dateTime)
        {
            throw new NotImplementedException();
        }

        public ReminderItem[] FindByStatus(ReminderItem.ReminderItemStatus status)
        {
            throw new NotImplementedException();
        }

        public void Update(ReminderItem item)
        {
           
        }
    }
}
