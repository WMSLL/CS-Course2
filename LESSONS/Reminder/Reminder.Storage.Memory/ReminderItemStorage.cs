using System;
using System.Collections.Generic;
using System.Linq;
namespace Reminder.Storage.Memory
{
    public class ReminderItemStorage : IReminderItemStorage
    {
        private Dictionary<Guid, ReminderItem> _item;

        public ReminderItemStorage()
        {
            _item = new Dictionary<Guid, ReminderItem>();
        }

        public ReminderItemStorage(ReminderItem[] items)
        {
            foreach (var item in items)
            {
                _item.Add(item.Id, item);
            }
        }

        public void Add(ReminderItem[] item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            foreach (var items in item)
            {
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
            if (_item.ContainsKey(id))
            {
                _item.Remove(id);
            }
            throw new KeyNotFoundException($"ReminderItem with id {id} allready exists is memory storage ");
        }

        public ReminderItem Find(Guid id)
        {
            if (_item.ContainsKey(id))
            {
                return _item[id];
            }
            else
            throw new KeyNotFoundException($"ReminderItem with id {id} allready exists is memory storage ");

        }
        public ReminderItem[] FindBy(ReminderItemFilter filter)
        {
            var query = _item.Values.AsEnumerable();

            if (filter.IsByStatus)
            {
                query = query.Where(item => item.Status == filter.Status);
            }
            if (filter.IsByDateTime)
            {
                query = query.Where(item => item.DateTimeUTC <= filter.DateTime);
            }
            return query.ToArray();
        }
        public ReminderItem[] FindByDateTime(DateTimeOffset datetime)
        {
            var itemList = new List<ReminderItem>();
            foreach (var (key, values) in _item)
            {
                if (values.DateTimeUTC <= datetime)
                {
                    itemList.Add(values);
                }
            }
            return itemList.ToArray();
        }
        public void Update(ReminderItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            if (!_item.ContainsKey(item.Id))
            {
                throw new ArgumentException(nameof(item));
            }
            _item[item.Id] = item;
        }
    }

}
