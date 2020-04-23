using System;

namespace HomeWork12

{
    class PhonePhoneReminderItem : Alarm
    {
        public string PhoneNumber;
        public PhonePhoneReminderItem(DateTimeOffset date, string message, string phoneNumber) : base(date, message)
        {
            PhoneNumber = phoneNumber;
        }
        public override string WriteProperties()
        {
            return $@"AlarmDate: {AlarmDate.ToString("g")} ,AlarmMessage:{AlarmMessage} , TimeToAlarm:{Math.Floor(TimeToAlarm.TotalMinutes / 60)}h.{Math.Floor(TimeToAlarm.TotalMinutes % 60)}m., isOutdated: {IsOutdated},PhoneNumber: {PhoneNumber}";
        }
    }
}