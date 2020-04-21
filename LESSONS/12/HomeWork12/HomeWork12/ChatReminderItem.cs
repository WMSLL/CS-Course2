using System;
namespace HomeWork12

{
    class ChatReminderItem  : Alarm
    {
        public string ChatName;
        public string AccauntNmae;
        public ChatReminderItem(DateTimeOffset date, string message,string phoneNumber): base ( date,  message)
        {


        }

        public override string WriteProperties()

        {
            return $@"AlarmDate: {AlarmDate.ToString("g")} ,AlarmMessage:{AlarmMessage} , TimeToAlarm:{Math.Floor(TimeToAlarm.TotalMinutes / 60)}h.{Math.Floor(TimeToAlarm.TotalMinutes % 60)}m., isOutdated: {IsOutdated}";
        }

    }
}