using System;
namespace HomeWork11
{
    class Alarm
    {
        DateTimeOffset AlarmDate { get; set; }
        string AlarmMessage { get; set; }
        TimeSpan TimeToAlarm { get { return AlarmDate - DateTimeOffset.Now; } }
        bool IsOutdated { get { return TimeToAlarm.TotalSeconds >= 0; } }
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
