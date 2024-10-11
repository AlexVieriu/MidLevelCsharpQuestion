public class PushPriceChangeNotifier : IObserver<decimal>
{
    private readonly decimal _notificationThreshold;

    public PushPriceChangeNotifier(decimal notificationThreshold)
    {
        _notificationThreshold = notificationThreshold;
    }

    public void Update(decimal currentBitCoinPrice)
    {
        if (currentBitCoinPrice > _notificationThreshold)        
            Console.WriteLine($"Push notification: bitcoin price is higher than " +
                $"the limit {_notificationThreshold} - now is {currentBitCoinPrice}");
        
        else
            Console.WriteLine("No push notification, the price is lower than the threshold");        
    }
}