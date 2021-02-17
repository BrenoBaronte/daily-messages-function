# Daily Messages Function
Azure Function using .Net Core 3.1 that has integration with Twilio and send SMS by time trigger. 
This repository is setted to send every day at 7am, but it can be configured in TimerTrigger constructor in <a href="https://github.com/BrenoBaronte/daily-messages-function/blob/main/Function.cs">Function.cs</a>.

To use the project you'll need a Twilio account. 
Buy a number with the trial credits and substitue de values: AccountSid, AccountToken, NumberFrom(Your Twilio number) and NumberTo(Number to send the SMS) in <a href="https://github.com/BrenoBaronte/daily-messages-function/blob/main/Function.cs">Function.cs</a>.

Change the messages to be sended in <a href="https://github.com/BrenoBaronte/daily-messages-function/blob/main/MessageGenerator.cs">MessageGenerator.cs</a>.

It can be deployed in Azure following the steps in the <a href="https://docs.microsoft.com/pt-br/azure/azure-functions/functions-develop-vs#publish-to-azure">oficial docs</a>.

Feel free to open any issue if necessary or send me a message. 
