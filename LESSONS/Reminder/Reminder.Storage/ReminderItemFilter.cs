using System;
using static Reminder.Storage.ReminderItem;

namespace Reminder.Storage
{
    public class ReminderItemFilter
    {
        public DateTimeOffset DateTime { get; set; }
        public ReminderItem.ReminderItemStatus Status { get; set; }
        public ReminderItemFilter(DateTimeOffset dateTime)
        {
            DateTime = dateTime;
        }

        public ReminderItemFilter(ReminderItem.ReminderItemStatus status)
        {
            Status = status;
        }

        public static ReminderItemFilter ByStatus(ReminderItemStatus status)
        {

        }

      

    }
}
