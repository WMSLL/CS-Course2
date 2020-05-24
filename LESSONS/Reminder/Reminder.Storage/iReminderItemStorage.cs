using System;

namespace Reminder.Storage
{
    public interface iReminderItemStorage
    {
        public void Add(ReminderItem[] item);
        public void Delete(Guid id);
        public void Update(ReminderItem item);
        public ReminderItem Find(Guid id);
        public ReminderItem[] FindByDateTime(DateTimeOffset datetime);

    }
}
