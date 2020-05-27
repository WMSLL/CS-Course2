using System;
using TimerThreading = System.Threading.Timer;
using Reminder.Storage;
using Reminder.Sender;
using Reminder.Receiver;

namespace Reminder.Domain
{
    public class ReminderScheduler : IDisposable
    {       
        private readonly ReminderSchedulerSettings _settings;
        private readonly IReminderItemStorage _storage;
        private readonly IReminderItemRecieiver _receiver;
        private readonly IReminderItemSender _sender;
        private TimerThreading _readyTime;
        private TimerThreading _sendTime;
        public ReminderScheduler(IReminderItemStorage storage
                                , IReminderItemRecieiver receiver
                                , IReminderItemSender sender
                                , ReminderSchedulerSettings settings)
        {
            _storage = storage;
            _receiver = receiver;
            _settings = settings;
            _sender = sender;
        }
        public void Run()
        {
            _receiver.MessageReceivet += OnMessageReceived;
            _receiver.Start();
            _readyTime = new TimerThreading(OnReadyTimerTick, null, TimeSpan.Zero, _settings.ReadyTimeInterval);
            _sendTime = new TimerThreading(OnSenderTimerTick, null, TimeSpan.Zero, _settings.SendTimeInterval);

        }
        public void Dispose()
        {
            _receiver.MessageReceivet -= OnMessageReceived;
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
                _sender.send(new ReminderNotification(item.Title, item.Message,item.UserId));
            }
        }

        private void OnMessageReceived(object sender, MessageReceiventEventArgs args)
        {


            var item = new ReminderItem(Guid.NewGuid(),
                                    args.Message.Header,
                                    args.Message.Text,
                                    args.Message.DateTimeUtc,
                                    args.UserId
                                    );
            var items = new ReminderItem[] { item };

            _storage.Add(items);
        }
    }
   


}
