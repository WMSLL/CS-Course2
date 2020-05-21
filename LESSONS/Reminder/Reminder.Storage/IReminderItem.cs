using System;

namespace Reminder.Storage
{
    public interface IReminderItem
    {

        public void Add(ReminderItem item);
        public void Delete(Guid id);
        public void Update(ReminderItem item);
        ReminderItem Find(Guid id);
        ReminderItem[] FindByDateTime(DateTimeOffset dateTime);
        ReminderItem[] FindByStatus(ReminderItem.ReminderItemStatus status);

    }
}
