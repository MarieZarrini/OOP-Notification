namespace OOP.Notification
{
	public class ProvidersService
	{
		private readonly IMessageService _messageService;
		private readonly List<string> _phoneNumbers;
		public ProvidersService(List<string> phoneNumbers)
		{
			_messageService = new MessageService();
			_phoneNumbers = phoneNumbers;
		}



		public void SendMessage(List<Provider> providers, string message)
		{
			var skipCount = 0;
			var enableProviders = GetEnableProviders(providers);

			foreach (var provider in enableProviders)
			{
				var currentPhoneNumbers = _phoneNumbers.Skip(skipCount).Take(provider.Capacity).ToList();

				SendMessage(currentPhoneNumbers, provider, message);

				skipCount += provider.Capacity;
			}
		}


		private void SendMessage(List<string> phoneNumbers, Provider provider, string message)
		{
			foreach (var number in phoneNumbers)
				_messageService.Send(number, message, provider);
		}


		private static List<Provider> GetEnableProviders(List<Provider> providers)
		{
			int disableProvidersCapacity = 0;
			List<Provider> enableProviders = new();

			foreach (var provider in providers)
			{
				if (provider.Disable)
					disableProvidersCapacity += provider.Capacity;
				else
					enableProviders.Add(provider);
			}

			var dividedCapacity = disableProvidersCapacity / enableProviders.Count;
			foreach (var enableProvider in enableProviders)
				enableProvider.Capacity += dividedCapacity;

			return enableProviders;
		}


		public void SetProviderCapacity(Provider provider, int percent)
		{
			var capacity = (_phoneNumbers.Count * percent) / 100;
			provider.Capacity = capacity;
		}
	}
}
