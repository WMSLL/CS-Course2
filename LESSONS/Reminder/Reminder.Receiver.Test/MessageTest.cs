using NUnit.Framework;
using System;

namespace Reminder.Receiver.Test
{
    public class MessageTest
    {
        [TestCase(null)]
        [TestCase("")]
        [TestCase("     ")]
        public void GivenNullOrEmptyString_WhenParseInvoked_thenThrowArgumentNullException(string text)
        {
            Assert.Catch<ArgumentNullException>(() => Message.Parse(null));
        }

        [TestCase("12d")]
        [TestCase("\n2020.05.25T10:42:08\n")]
        public void GivenStringWithoutSeparators_whenParseInvoked_ThenThrowArgumetException(string text)
        {
            Assert.Catch<ArgumentException>(() => Message.Parse(text));            
        }

        [TestCase("12d\nnaa\nsda")]
        public void GivengStringWithoutCorrectDatetime_WhenParseIvoked_ThenThrowArgumentException(string text)
        {
          var exception=  Assert.Catch<ArgumentException>(() => Message.Parse(text));
            StringAssert.Contains("The datetime of string was in invalid format", exception.Message);
        }

        [TestCase("Header", "2020.05.25T10:42:08", "Message")]
        [TestCase("Header", "2020.05.25T10:42:08+03", "Message")]
        
        public void GivengStringInvalidFormat_WhenParseInvoked_ThenReturnMessageWhisCompanents(string header,string datetime,string text)
        {
           var message= Message.Parse($"{header}\n{datetime}\n{text}");
            Assert.AreEqual(header, message.Header);
            Assert.AreEqual(text, message.Text);
            Assert.AreEqual(DateTimeOffset.Parse(datetime), message.DateTimeUtc);
        }   
    }
}