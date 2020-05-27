using System;

namespace Reminder.Sender
{
    public interface IReminderItemSender
    {
        public void send(ReminderNotification notification);
    }
}
