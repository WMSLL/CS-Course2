using Reminder.Storage;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reminder.WebApi.ViewModels
{
    public class ReminderItemViewModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string DateTimeUTC { get; set; }
        public string UserId { get; set; }
        public string Status { get; set; }
        public ReminderItemViewModel(ReminderItem item)
        {
            Id = item.Id.ToString("N");
            Title = item.Title;
            Message = item.Message;
            DateTimeUTC = item.DateTimeUTC.ToString("O");
            UserId = item.UserId;
            Status = item.Status.ToString();


        }
        public ReminderItemViewModel(ReminderItem[] items)
        {
            foreach (var item in items)
            {
                Id = item.Id.ToString("N");
                Title = item.Title;
                Message = item.Message;
                DateTimeUTC = item.DateTimeUTC.ToString("O");
                UserId = item.UserId;
                Status = item.Status.ToString();
            }         
       }
    }
}
