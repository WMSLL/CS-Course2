using System;



namespace Reminder.Receiver
{ 
    public interface IReminderItemRecieiver
    {
        event EventHandler<MessageReceiventEventArgs> MessageReceivet;
        public void Start()
        {
            
        }
    }
    
}
