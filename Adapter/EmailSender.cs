namespace Adapter
{
    public class EmailSender : INotificationSender
    {
        public void SendNotification(int userId, Notification notification)
        {
            Console.WriteLine($"Sending email notification to: {userId}, title: {notification.Title}, body: {notification.Body}");
        }
    }
}