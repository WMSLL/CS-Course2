using Reminder.Storage;
using System;
using System.ComponentModel.DataAnnotations;

namespace Reminder.WebApi.ViewModels
{
    public class CreateReminderItemViewModel
    {
        public Guid? Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        [StringLength(4096)]
        public string Message { get; set; }
        [Required]
        public DateTimeOffset? DateTimeUTC { get; set; }
        [Required]
        [StringLength(64)]
        public string UserId { get; set; }

        public ReminderItemStatus Status { get; set; }

    }
}
