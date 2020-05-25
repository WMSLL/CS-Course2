using System;
using TimerThreading = System.Threading.Timer;
using Reminder.Storage;
using System.Threading;

namespace Reminder.Domain
{
    public class ReminderScheduler : IDisposable
    {
        public event EventHandler<ReminderSentEventArgs> RimenderSend;
        private readonly ReminderSchedulerSettings _settings;
        private readonly IReminderItemStorage _storage;
        private TimerThreading _readyTime;
        private TimerThreading _sendTime;
        public ReminderScheduler(IReminderItemStorage storage, ReminderSchedulerSettings settings)
        {
            _storage = storage;
            _settings = settings;
        }
        public void Run()
        {
            _readyTime = new TimerThreading(OnReadyTimerTick, null, TimeSpan.Zero, _settings.ReadyTimeInterval);
            _sendTime = new TimerThreading(OnSenderTimerTick, null, TimeSpan.Zero, _settings.SendTimeInterval);
        }
        public void Dispose()
        {
            _sendTime.Dispose();
            _readyTime.Dispose();
        }
        private void OnReadyTimerTick(object state)
        {
            var items = _storage.FindBy(ReminderItemFilter.FromNow());

            foreach (var item in items)
            {
                item.Status = ReminderItemStatus.Ready;
                _storage.Update(item);
            }
        }
        private void OnSenderTimerTick(object state)
        {
            var items = _storage.FindBy(ReminderItemFilter.ByStatus(ReminderItemStatus.Ready));
            foreach (var item in items)
            {
                item.Status = ReminderItemStatus.Sent;
                _storage.Update(item);
                RimenderSend?.Invoke(this, new ReminderSentEventArgs(item));
            }
        }
    }
}
