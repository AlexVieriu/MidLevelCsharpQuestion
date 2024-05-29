public class NotificationService_WithDI
{
    private readonly ISmsProvider _smsProvider; // Dependency on an interface

    public NotificationService_WithDI(ISmsProvider smsProvider) // Constructor injection
    {
        _smsProvider = smsProvider;
    }

    public void SendOrderConfirmation(string phoneNumber, string message)
    {
        _smsProvider.SendSms(phoneNumber, message);
    }
}
