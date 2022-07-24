using OOP.Notification;

var phoneNumbers = new List<string>() { "1", "2", "3", "4", "5", "6" };
var message = "Hello World";

var faraPayamak = new Provider { Name = ProviderName.Farapayamak, Disable = false };
var rahyab = new Provider { Name = ProviderName.Rahyab, Disable = false };

var providers = new List<Provider>() { faraPayamak, rahyab };



var providerService = new ProvidersService(phoneNumbers);

providerService.SetProviderCapacity(faraPayamak, 60);
providerService.SetProviderCapacity(rahyab, 40);

providerService.SendMessage(providers, message);
