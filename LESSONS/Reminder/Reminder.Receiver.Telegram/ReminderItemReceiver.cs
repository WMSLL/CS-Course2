using System;
using System.Net.Http;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace Reminder.Receiver.Telegram
{//1195265347:AAFqPN_gjbV95a369tnRuysJKSNt4DVn9ms
    public class ReminderItemReceiver : IReminderItemRecieiver
    {
        public event EventHandler<MessageReceiventEventArgs> MessageReceivet;
        private readonly TelegramBotClient _client;
        public ReminderItemReceiver(string token)
        {
            _client = new TelegramBotClient(token, new HttpClient());
        }
        public void Start()
        {
            _client.OnMessage += OnMessage;
            _client.StartReceiving();
        }

        private void OnMessage(object sender, MessageEventArgs ergs)
        {
            // todo Message.Parse may Through exception           
            try
            {
                var userid = ergs.Message.Chat.Id.ToString();
                var message = Message.Parse(ergs.Message.Text);
                OnMessageReceived(message, userid);
            }
            catch (ArgumentException exception)
            {

               
            }
           
           
        }

        private void OnMessageReceived(Message message,string userId)
        {
            MessageReceivet?.Invoke(this, new MessageReceiventEventArgs(message, userId));
        }
    }
}
