using System;

namespace Reminder.Domain
{
    public class ReminderSchedulerSettings
    {   
        public TimeSpan ReadyTimeInterval { get;  }
        public TimeSpan SendTimeInterval { get;  }
        public ReminderSchedulerSettings(TimeSpan readyTimeInterval, TimeSpan sendTimeInterval)
        {
            ReadyTimeInterval = readyTimeInterval;
            SendTimeInterval = sendTimeInterval;
        }

    }
}
