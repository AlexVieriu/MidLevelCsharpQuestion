// Interface changes C# 8

// Step 4
var order = new CustomerOrder();
order.DelayDeliveryByDays(5);       // don't work

IOrder iOrder = new CustomerOrder();
iOrder.DelayDeliveryByDays(5);      // work

// Step 5 - add a class with the DelayDeliveryByDays() implementation
var order2 = new CustomerOrderWithDelay();
order2.DelayDeliveryByDays(5);

Console.ReadKey();


// (Step 1): we develop a library that we/other company will use and publish it as a Nugget Package
// (Step 2): if we decide 1 year later to put Version 2 with another Cancel() method, we will get compilation error
public interface IOrder
{
    IEnumerable<IItem> Items { get; }
    public ICustomer Customer { get; }
    void Place();

    // (Step 3) - solution, default implementation
    public void DelayDeliveryByDays(int Days)
    {
        Console.WriteLine($"{nameof(DelayDeliveryByDays)} from interface");
    }
}

// (Step 2): we can another interface 
// the problem is after a long period of time will add a lot of interfaces and will be hard to maintain
public interface ICancellationOrder : IOrder
{
    void Cancel();
}

public interface IItem
{
    public string Name { get; }
    public decimal Price { get; }

    private static string Ion;
}

public interface ICustomer
{

}

// (Step 4)
class CustomerOrder : IOrder, ICancellationOrder
{
    public IEnumerable<IItem> Items => new List<IItem>();

    public ICustomer Customer { get; }

    public void Cancel()
    {
        Console.WriteLine("The order was canceled");
    }

    public void Place()
    {
        Console.WriteLine("Place a order");
    }
}

// (Step 5)
class CustomerOrderWithDelay : IOrder, ICancellationOrder
{
    public IEnumerable<IItem> Items => new List<IItem>();

    public ICustomer Customer { get; }

    public void Place()
    {
        Console.WriteLine("Place a order");
    }

    public void DelayDeliveryByDays(int Days)
    {
        Console.WriteLine($"{nameof(DelayDeliveryByDays)} from {nameof(CustomerOrderWithDelay)}");
    }

    public void Cancel()
    {
        Console.WriteLine("The order was canceled");
    }
}