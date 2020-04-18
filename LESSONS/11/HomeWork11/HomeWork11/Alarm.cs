using System;
namespace HomeWork11
{
    class Alarm
    {
        public DateTimeOffset AlarmDate;
        public string AlarmMessage;
        TimeSpan _timeToAlarm;
        public TimeSpan TimeToAlarm { get; }
        bool _isOutdated;

        public bool IsOutdated { get; }
    }
}
