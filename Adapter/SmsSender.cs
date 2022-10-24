namespace Adapter
{                           //as external (ex. from dll) class
    public class SmsSender
    {
        public void SendSms(string to, string text)
        {
            Console.WriteLine($"Sending Sms to: {to} with message: {text}");
        }
    }
}