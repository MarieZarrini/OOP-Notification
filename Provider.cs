namespace OOP.Notification
{
    public class Provider
	{
		public ProviderName Name { get; set; }
		public bool Disable { get; set; }
		public int Capacity { get; set; }
	}


    public enum ProviderName
    {
        Farapayamak = 1,
        Rahyab = 2
    }
}
