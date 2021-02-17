using System;
using System.Collections.Generic;

namespace DailyMessages
{
    public static class MessageGenerator
    {
        private static readonly List<string> messages = new List<string>
        {
            "message1",
            "message2",
            "message3",
            "message4",
            "message5",
        };

        public static string GetRandomMessage()
        {
            var messageIndex = GetMessageIndex();
            return messages[messageIndex - 1];
        }

        private static int GetMessageIndex()
        {
            var random = new Random();
            return random.Next(1, messages.Count + 1);
        }
    }
}
