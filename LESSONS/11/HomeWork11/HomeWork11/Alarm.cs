using System;
namespace HomeWork11
{
    class Alarm
    {
        DateTimeOffset AlarmDate;
        string AlarmMessage;
        public TimeSpan TimeToAlarm { get { return AlarmDate - DateTimeOffset.Now; } }
        public bool IsOutdated { get { return TimeToAlarm.TotalMinutes > 0; } } 
        public Alarm(DateTimeOffset date, string message)
        {
            AlarmDate = date;
            AlarmMessage = message;
        }
        public string WriteProperties()
        {
            return $@"Время срабатывания будильника: {AlarmDate.ToString("g")} ,AlarmMessage:{AlarmMessage} , TimeToAlarm:{Math.Floor(TimeToAlarm.TotalMinutes / 60)}h.{Math.Floor(TimeToAlarm.TotalMinutes % 60)}m., isOutdated: {IsOutdated}";
        }

    }
}
