public class TwilioSmsProvider_WithDI : ISmsProvider // Concrete implementation (replace with your provider)
{
    public void SendSms(string phoneNumber, string message)
    {
        // Simulate sending SMS using Twilio API (replace with actual implementation)
        Console.WriteLine($"Sending SMS to {phoneNumber}: {message}");
    }
}
