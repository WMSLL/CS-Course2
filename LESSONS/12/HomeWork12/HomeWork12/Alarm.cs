using System;

namespace HomeWork12

{
    class Alarm

    {
        public DateTimeOffset AlarmDate { get; set; }
        public string AlarmMessage { get; set; }
        public TimeSpan TimeToAlarm { get { return DateTimeOffset.Now - AlarmDate; } }
        public bool IsOutdated { get { return TimeToAlarm >= TimeSpan.Zero; } }
        public Alarm(DateTimeOffset date, string message)
        {
            AlarmDate = date;
            AlarmMessage = message;
        }
        public virtual string WriteProperties()
        {
            return $@"AlarmDate: {AlarmDate.ToString("g")} ,AlarmMessage:{AlarmMessage} , TimeToAlarm:{Math.Floor(TimeToAlarm.TotalMinutes / 60)}h.{Math.Floor(TimeToAlarm.TotalMinutes % 60)}m., isOutdated: {IsOutdated}";
        }
    }
}