using System;



namespace Reminder.Receiver
{
    public class Message
    {
        public Message(string header, DateTimeOffset dateTimeUtc, string text)
        {
            Text = text;
            Header = header;           
            DateTimeUtc = dateTimeUtc;
        }

        public string Header { get; set; }

        public DateTimeOffset DateTimeUtc { get; set; }
        public string Text { get; set; }
          
        
        public static Message Parse(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException(nameof(text));
            }
            var parts= text.Split(new[] { '\n' },StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length<3)
            {
                throw new ArgumentException("The string was in invalid format", nameof(text));
            }
            var title= parts[0];
            var result = DateTimeOffset.TryParse(parts[1],out DateTimeOffset dateTimeUtc);
            if (!result)
            {
                throw new ArgumentException("The datetime of string was in invalid format",nameof(text));
            }
            var message = parts[2];
            return new Message(title, dateTimeUtc, message);
            
        }
    }

   

}
