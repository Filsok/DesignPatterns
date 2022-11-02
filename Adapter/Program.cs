using Adapter;

//INotificationSender sender = new EmailSender();
INotificationSender sender = new SmsSenderAdapter();

sender.SendNotification(15, new Notification() { Title = "Wazne", Body = "Zanim wstawisz ziemniaki posol je!" });