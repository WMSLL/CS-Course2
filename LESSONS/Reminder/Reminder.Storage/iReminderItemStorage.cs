using System;

namespace Reminder.Storage
{
    public interface IReminderItemStorage
    {
        public void Add(ReminderItem[] item);
        public void Delete(Guid id);
        public void Update(ReminderItem item);
        public ReminderItem Find(Guid id);
        public ReminderItem[] FindByDateTime(DateTimeOffset datetime) => FindBy(ReminderItemFilter.ByDateTime(datetime));
        public ReminderItem[] FindBy(ReminderItemFilter filter);
       
    }
}
