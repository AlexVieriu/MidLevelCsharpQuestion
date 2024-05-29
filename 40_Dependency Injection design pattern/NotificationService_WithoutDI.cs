public class NotificationService_WithoutDI
{
    // Tight coupling
    private readonly TwilioSmsProvider_WithoutDI _smsProvider; 

    public NotificationService_WithoutDI(TwilioSmsProvider_WithoutDI smsProvider)
    {
        _smsProvider = smsProvider;
    }

    public void SendOrderConfirmation(string phoneNumber, string message)
    {
        _smsProvider.SendSms(phoneNumber, message);
    }
}
