using System;
using Reminder.Storage;

namespace Reminder.Domain
{
    public class ReminderSentEventArgs
    {
        public string Message { get; set; }
        public DateTimeOffset DateTime { get; set; }
        public ReminderSentEventArgs(ReminderItem item)
        {
            Message = item.Message;
            DateTime = item.DateTimeUTC;
        }


    }
}
