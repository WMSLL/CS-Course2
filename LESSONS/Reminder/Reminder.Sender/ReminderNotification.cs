namespace Reminder.Sender
{
    public class ReminderNotification
    {
        public string Title { get; }
        public string Text { get; }
        public string UserId { get; }

      public  ReminderNotification(string title, string text, string userId)
        {
            Title = title;
            Text = text;
            UserId = userId;
        }

        
    }
}
