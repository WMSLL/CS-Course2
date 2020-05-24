using System;
using System.Threading;
using Reminder.Storage;

namespace Reminder.Domain
{
    public class ReminderScheduler
    {
        private IReminderItem _storage;

        public ReminderScheduler(IReminderItem storage)
        {
            _storage = storage;
            var timer = new Timer(OnReadyTimerItem,
                                   null,
                                    TimeSpan.Zero,
                                      TimeSpan.FromSeconds(2));

            var timer2 = new Timer(OnSenderTimerItem,
                                  null,
                                   TimeSpan.Zero,
                                     TimeSpan.FromSeconds(2));
        }
              

        private void OnReadyTimerItem(object state)
        {
            var datetime = DateTimeOffset.UtcNow;

            var items = _storage.FindByDateTime(datetime);

            foreach (var item in items)
            {
                item.Status = ReminderItem.ReminderItemStatus.Ready;
            }
        }
        private void OnSenderTimerItem(object state)
        {
            throw new NotImplementedException();
        }


    }
   
}
