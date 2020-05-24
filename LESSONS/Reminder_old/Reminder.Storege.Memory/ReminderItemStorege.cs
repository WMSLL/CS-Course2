using System;
using System.Collections.Generic;
namespace Reminder.Storage.Memory
{
    public class ReminderItemStorege : IReminderItem
    {
        private Dictionary<Guid, ReminderItem> _item;
        public ReminderItemStorege(ReminderItem[] item )
        {
            foreach (var items in item)
            {
                _item = items;
            }      
        }
        public ReminderItemStorege()
        {
            
        }
        public void Add(ReminderItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (_item.ContainsKey(item.id))
            {
                throw new ArgumentException("Reminder item with key already exists", nameof(item));
            }
            var key = item.id;
            _item.Add(key, item);
        }

        public void Delete(Guid id)
        {
            if (_item.ContainsKey(id))
            {
                _item.Remove(id);
            }
            else
            {
                throw new ArgumentException($"Reminder item with id {id},not exists", nameof(id));
            }
            
        }
        public ReminderItem Find(Guid id)
        {
            _item.TryGetValue(id, out ReminderItem value);
            return value;
        }

        public ReminderItem[] FindByDateTime(DateTimeOffset dateTime)
        {
            var reminderValue = _item.Values;
            var remainderList = new List<ReminderItem>();
            foreach (var item in reminderValue)
            {
                if (item.DateTimeUtc <= dateTime)
                {
                    remainderList.Add(item);
                }
            }
            var countList = remainderList.Count;
            var remainderArray = new ReminderItem[countList];
            for (int i = 0; i < countList; i++)
            {
                remainderArray[i] = remainderList[i];
            }
            return remainderArray;
        }

        public ReminderItem[] FindByStatus(ReminderItem.ReminderItemStatus status)
        {
            var remainderList = new List<ReminderItem>();
            foreach (var item in _item.Values)
            {
                if (item.Status == status)
                {
                    remainderList.Add(item);
                }
            }
            var countList = remainderList.Count;
            var remainderArray = new ReminderItem[countList];
            for (int i = 0; i < countList; i++)
            {
                remainderArray[i] = remainderList[i];
            }
            return remainderArray;
        }

        public void Update(ReminderItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            _item[item.id] = item;
        }
    }
}
