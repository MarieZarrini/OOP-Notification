using System;

namespace OOP.Notification
{
    public class MessageService : IMessageService
    {
        private readonly INotificationProvider[] _notificationProviders;
        public MessageService()
        {
            _notificationProviders = new INotificationProvider[] { new RahyabProvider(), new FaraPayamakProvider() };
        }
        public void Send(string to, string message, List<NotificationType> notificationTypes)
        {
            var providers = _notificationProviders.Where(np => notificationTypes.Contains(np.GetNotificationType()));
            foreach (var provider in providers)
            {
                provider.Send(to, message);
            }
        }
    }
}

