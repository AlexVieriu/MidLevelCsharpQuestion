public class BitCoinPriceReader : IObservable<decimal>
{
    private decimal _priceReader;
    private List<IObserver<decimal>> _observers = new();

    public void AttachObserver(IObserver<decimal> observer)
    {
        _observers.Add(observer);
    }

    public void DetachObserver(IObserver<decimal> observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_priceReader);
        }
    }

    public void ReadCurrentPrice()
    {
        _priceReader = new Random().Next(0, 5000);

        NotifyObservers();
    }
}
