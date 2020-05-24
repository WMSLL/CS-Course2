using System;
using System.Collections.Generic;
namespace Reminder.Storage.Memory
{
    public class ReminderItemStorage : iReminderItemStorage
    {
        private Dictionary<Guid, ReminderItem> _item;

        public ReminderItemStorage()
        {
            _item = new Dictionary<Guid, ReminderItem>();
        }

        public void Add(ReminderItem[] item)
        {
            foreach (var items in item)
            {
                if (item == null)
                {
                    throw new ArgumentNullException(nameof(item));
                }
                if (_item.ContainsKey(items.Id))
                {
                    throw new ArgumentException($"ReminderItem with header {items.Title} and id {items.Id} already exists in memory storage", nameof(item));
                }
                var key = items.Id;
                _item.Add(key, items);
            }          
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public ReminderItem Find(Guid id)
        {
            if (_item.ContainsKey(id))
            {
                throw new KeyNotFoundException($"ReminderItem with id {id} allready exists is memory storage ");
            }            
           return _item[id];
        }

        public ReminderItem[] FindByDateTime(DateTimeOffset datetime)
        {
            List<ReminderItem> listReminderItem=null;            
            foreach (var items in _item.Values)
            {
                if (items==null)
                {
                    throw new ArgumentNullException($"No matching criteria ReminderItem", nameof(items)) ;
                }
                if (items.DateTimeUTC< datetime)
                {
                    listReminderItem.Add(items);
                }
            }
            var counts = listReminderItem.Count;
            var arrey = new ReminderItem[counts];
            for (int i = 0; i < counts; i++)
            {
                arrey[i] = listReminderItem[i];
            }
            return arrey;
        }

        public void Update(ReminderItem item)
        {
            throw new NotImplementedException();
        }
    }
}
