using System;

namespace Reminder.Storage
{
    public partial class ReminderItem
    {
        public Guid id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTimeOffset DateTimeUtc { get; set; }
        public string UserId { get; set; }
        public ReminderItemStatus Status { get; set; }
        public ReminderItem(Guid id,
                              string title,
                              string message,
                              DateTimeOffset dateTimeUtc,
                              string userId,
                              ReminderItemStatus status= ReminderItemStatus.Created)// По дефолту будет брать Created 
        {
            this.id = id;
            Title = title;
            Message = message;
            DateTimeUtc = dateTimeUtc;
            UserId = userId;
            Status = status;
        }

    }
}
