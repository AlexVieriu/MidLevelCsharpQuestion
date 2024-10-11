public class EmailPriceChangeNotifier : IObserver<decimal>
{
    private readonly decimal _notificationThreshold;

    public EmailPriceChangeNotifier(decimal notificationThreshold)
    {
        _notificationThreshold = notificationThreshold;
    }

    public void Update(decimal currentBitCoinPrice)
    {
        if (currentBitCoinPrice > _notificationThreshold)
        {
            Console.WriteLine($"Email sent: bitcoin price is higher than " +
                $"the limit {_notificationThreshold} - now is {currentBitCoinPrice}");
        }
        else
            Console.WriteLine("No email notification, the price is lower than the threshold");
    }
}
