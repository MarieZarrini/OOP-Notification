namespace OOP.Notification
{
    public class FaraPayamakProvider : INotificationProvider
    {
        private readonly Provider _provider;
		public FaraPayamakProvider()
		{
            _provider = new Provider() { Name = ProviderName.Farapayamak, Disable = false };
		}


        public void Send(string to, string message)
        {
            Console.WriteLine($"{GetProviderName()} send \"{message}\" to {to}");
        }

        public ProviderName GetProviderName()
        {
            return _provider.Name;
        }
    }
}
