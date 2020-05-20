namespace Reminder.Storage
{
    public partial class ReminderItem
    {
        public enum ReminderItemStatus
        {
            Undefined = 0, Created, Readey, Send, Failed
        }
    }
}
