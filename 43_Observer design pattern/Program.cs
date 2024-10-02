public class BitCoinPriceReader
{
    private decimal _priceReader;

    public void ReadCurrentPrice()
    {
        _priceReader = new Random().Next(0, 5000);
    }
}

public class PushPriceChangeNotifier
{
    private readonly decimal _notificationThreshold;

    public PushPriceChangeNotifier(decimal notificationThreshold)
    {
        _notificationThreshold = notificationThreshold;
    }

    public void Update(decimal currentBitCoinPrice)
    {
        if (currentBitCoinPrice > _notificationThreshold)
        {
            Console.WriteLine($"Email sent: {_notificationThreshold} - {currentBitCoinPrice}");
        }
    }
}