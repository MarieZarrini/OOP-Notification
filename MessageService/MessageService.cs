namespace OOP.Notification
{
	public class MessageService : IMessageService
	{
		private readonly INotificationProvider[] _notificationProviders;
		public MessageService()
		{
			_notificationProviders = new INotificationProvider[] { new RahyabProvider(), new FaraPayamakProvider() };
		}

		public void Send(string to, string message, Provider provider)
		{
			var notificationProvider = _notificationProviders.First(n => n.GetProviderName() == provider.Name);
			notificationProvider.Send(to, message);
		}
	}
}
