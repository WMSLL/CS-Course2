using Reminder.Storage;
namespace Reminder.Storage.WebApi

{
    public class ReminderItemDto
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string DateTimeUTC { get; set; }
        public string UserId { get; set; }
        public ReminderItemStatus Status { get; set; }

        public ReminderItemDto()
        {

        }
        public ReminderItemDto( ReminderItem item)
        {
            Id = item.Id.ToString();
            Title = item.Title;
            Message = item.Message;
            DateTimeUTC = item.DateTimeUTC.ToString("O");
            UserId = item.UserId;
            Status =  item.Status;
        }
    }
}
