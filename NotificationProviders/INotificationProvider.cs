namespace OOP.Notification
{
    public interface INotificationProvider
    {
        void Send(string to, string message);
        ProviderName GetProviderName();
    }
}