using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Reminder.Storage;


namespace Reminder.WebApi.ViewModels
{
    public class UpdateReminderItemViewModel
    {
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        [StringLength(4096)]
        public string Message { get; set; }
        [Required]
        public DateTimeOffset? DateTimeUTC { get; set; }
        public ReminderItemStatus Status { get; set; }

    }
}
