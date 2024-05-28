// Strong Coupling classes
public class Subscribers_StrongCoupling
{
    // Change Subscriber[] to HashSet<Subscriber> 

    //public Subscriber[] Items;
    public HashSet<Subscriber> Items;
}

public class NewsletterSender__StrongCoupling
{
    private readonly Subscribers_StrongCoupling _subscribers;

    public NewsletterSender__StrongCoupling(Subscribers_StrongCoupling subscribers)
    {
        _subscribers = subscribers;
    }

    public void SendTo(bool premiumSubscribersOnly)
    {
        for (int i = 0; i < _subscribers.Items.Length; i++)
        {
            if (!premiumSubscribersOnly || _subscribers.Items[i].IsPremium)
                Console.WriteLine($"Newsletter sent to {_subscribers.Items[i].Email}");
        }
    }
}

// Loosely Coupling classes
public class Subscribers_LooseCoupling
{
    // if we change the type of items, nothing will break in SendTo()

    /*
    public HashSet<Subscriber> _items;

    public Subscribers_LooseCoupling(HashSet<Subscriber> items)
    {
        _items = items;
    }    
    */

    public Subscriber[] _items;
    public Subscribers_LooseCoupling(Subscriber[] items)
    {
        _items = items;
    }

    public IEnumerable<Subscriber> Items => _items;
}

public class NewsletterSender__LooseCoupling
{
    private readonly Subscribers_StrongCoupling _subscribers;

    public NewsletterSender__LooseCoupling(Subscribers_StrongCoupling subscribers)
    {
        _subscribers = subscribers;
    }

    public void SendTo(bool premiumSubscribersOnly)
    {
        foreach (var subscriber in _subscribers.Items.Where(s => !premiumSubscribersOnly || s.IsPremium)
        {
            Console.WriteLine($"NewLetter sent to {subscriber.Email}");
        }
    }
}