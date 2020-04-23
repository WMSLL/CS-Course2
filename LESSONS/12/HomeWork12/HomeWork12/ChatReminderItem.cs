using System;
namespace HomeWork12

{
    class ChatReminderItem : Alarm
    {
        public string ChatName;
        public string AccauntNmae;
        public ChatReminderItem(DateTimeOffset date, string message, string chatName, string accauntNmae) : base(date, message)
        {
            ChatName = chatName;
            AccauntNmae = accauntNmae;
        }
        public override string WriteProperties()
        {
            return $@"AlarmDate: {AlarmDate.ToString("g")} ,AlarmMessage:{AlarmMessage} ,   TimeToAlarm:{Math.Floor(TimeToAlarm.TotalMinutes / 60)}h.{Math.Floor(TimeToAlarm.TotalMinutes % 60)}m., isOutdated: {IsOutdated},ChatName: {ChatName},AccauntNmae: {AccauntNmae}";
        }
    }
}