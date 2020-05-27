using System;



namespace Reminder.Receiver
{
    public class MessageReceiventEventArgs : EventArgs
    {
        public Message Message { get; }
        public string UserId { get; }
        public MessageReceiventEventArgs(Message message, string userId)
        {
            Message = message;
            UserId = userId;
        }
    }


}
