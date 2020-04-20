using System;
namespace HomeWork11
{
    class Alarm
    {
        DateTimeOffset AlarmDate { get; set; }
        string AlarmMessage { get; set; }
        TimeSpan TimeToAlarm { get { return DateTimeOffset.Now-AlarmDate; } }
        bool IsOutdated { get { return TimeToAlarm >= TimeSpan.Zero; } }
        public Alarm(DateTimeOffset date, string message)
        {
            AlarmDate = date;
            AlarmMessage = message;
        }
        public string WriteProperties()
        {
            return $@"AlarmDate: {AlarmDate.ToString("g")} ,AlarmMessage:{AlarmMessage} , TimeToAlarm:{Math.Floor(TimeToAlarm.TotalMinutes / 60)}h.{Math.Floor(TimeToAlarm.TotalMinutes % 60)}m., isOutdated: {IsOutdated}";
        }
    }
}
