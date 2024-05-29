public interface ISmsProvider // Abstraction for SMS notification
{
    void SendSms(string phoneNumber, string message);
}
