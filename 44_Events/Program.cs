// used in general for windows desktop applications(button events etc.)
var bitcoinPriceReader = new BitcoinPriceReader();

var emailNotifier = new EmailPriceChangeNotifier(25000);
bitcoinPriceReader.PriceRead += emailNotifier.Update;
bitcoinPriceReader.ReadCurrentPrice();

public delegate void PriceRead(decimal price);

public class BitcoinPriceReader
{
    private decimal _currentBitcoinPrice;
    public event EventHandler<PriceReadEventArgs>? PriceRead;

    public void ReadCurrentPrice()
    {
        _currentBitcoinPrice = new Random().Next(0, 10000);
        PriceRead?.Invoke(this, new PriceReadEventArgs(_currentBitcoinPrice)); // exec delegate if not null
    }
}

public class PriceReadEventArgs : EventArgs
{
    public decimal Price { get; }
    public PriceReadEventArgs(decimal price)
    {
        Price = price;
    }
}

public class EmailPriceChangeNotifier : EventArgs
{
    private readonly decimal _priceLimit;

    public EmailPriceChangeNotifier(decimal priceLimit)
    {
        _priceLimit = priceLimit;
    }

    public void Update(object sender, PriceReadEventArgs eventArgs)
    {
        if (eventArgs.Price > _priceLimit)
            Console.WriteLine($"Sending email: currentBitcoin price is {eventArgs.Price} - limit price is{_priceLimit}");
        else
            Console.WriteLine("No email to send");
    }
}