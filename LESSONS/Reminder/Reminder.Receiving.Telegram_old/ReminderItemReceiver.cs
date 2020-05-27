using System;
using Reminder.Receiving;
using System.Net.Http;
using Telegram.Bot;
using Reminder.Receiver;

namespace Reminder.Receiving.Telegram
{
    public class ReminderItemReceiver : IReminderItemRecieiver
    {

        public void foo()
        {
            var client = new TelegramBotClient(
                "",
                new HttpClient()
                );
        }
    }
}
