namespace Adapter
{
    public class SmsSenderAdapter : INotificationSender
    {
        private SmsSender _sender = new SmsSender();

        public void SendNotification(int userId, Notification notification)
        {
            string userPhoneNumber = null; //based on userId
            _sender.SendSms(userPhoneNumber, $"{notification.Title}: {notification.Body}");
        }
    }
}