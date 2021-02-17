using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace DailyMessages
{
    public static class Function
    {
        [FunctionName("Function")]
        public static void Run(
            [TimerTrigger("0 0 7 * * *")] TimerInfo myTimer,
            ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            var message = MessageGenerator.GetRandomMessage();

            TwilioClient.Init(
                "__AccountSid__",
                "__AccountToken__");

            var messageSended = MessageResource.Create(
                body: message,
                from: new Twilio.Types.PhoneNumber("__NumberFrom__"),
                to: new Twilio.Types.PhoneNumber("__NumberTo__"));
        }
    }
}
