using System;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Reminder.Sender.Telegram
{
    public class ReminderItemSender : IReminderItemSender
    {
        private readonly TelegramBotClient _client;

        public ReminderItemSender(string token)
        {

            _client = new TelegramBotClient(token);
        }

        public void send(ReminderNotification notification)
        {
            var text = $"{notification.Title}{notification.Text}";
            var chatID =new ChatId(long.Parse(notification.UserId));
            _client.SendTextMessageAsync(null, text,ParseMode.Html);
        }
    }
}
