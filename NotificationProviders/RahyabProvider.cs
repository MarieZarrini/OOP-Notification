namespace OOP.Notification
{
    public class RahyabProvider : INotificationProvider
    {
        private readonly Provider _notificationType;
        public RahyabProvider()
        {
            _notificationType = new Provider() { Name = ProviderName.Rahyab, Disable = false };
        }

        public void Send(string to, string message)
        {
            Console.WriteLine($"{GetProviderName()} send \"{message}\" to {to}");
        }

        public ProviderName GetProviderName()
        {
            return _notificationType.Name;
        }
            }
}
