using System;
namespace Reminder.Storage
{
    public class ReminderItem
    {     
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTimeOffset DateTimeUTC { get; set; } 
        public string UserId { get; set; }
        public ReminderItemStatus Status { get; set; }
        public ReminderItem(Guid id, 
                            string title, 
                            string message, 
                            DateTimeOffset dateTimeUTC, 
                            string userId, 
                            ReminderItemStatus status = ReminderItemStatus.Created)
        {
            this.Id = id;
            Title = title;
            Message = message;
            DateTimeUTC = dateTimeUTC;
            UserId = userId;
            Status = status;
            Status = status;
        }
    }
}
