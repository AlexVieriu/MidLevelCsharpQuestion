using Microsoft.Extensions.Logging;

// Example 1
static T? GetFirstOrDefault<T>(IEnumerable<T> items)
{
    try
    {
        return items.First();
    }

    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"This is a {nameof(InvalidOperationException)} exception");
        return default(T);
    }

    catch (Exception)
    {
        Console.WriteLine($"This is a {nameof(Exception)} exception");
        return default(T);
    }
}

// Example 2
static double Average(IEnumerable<int> numbers)
{
    if (numbers == null)
        //throw new Exception("The numbers collection is null");  -- this general exception is bad here
        throw new ArgumentNullException("The numbers collection is null");

    double sum = 0;
    int count = 0;

    foreach (int number in numbers)
    {
        sum += number;
        count++;
    }
    if (count > 0)
        return sum / count;

    //throw new Exception("Collection is Empty");                   -- be more specific
    throw new InvalidOperationException("Collection is Empty");
}

// Example 3
try
{
    var numbers = Enumerable.Empty<int>();
    var first = GetFirstOrDefault(numbers);

    // make the app crash
    throw new Exception("Unknown exception");
}
catch (Exception)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("A general exception");
}

// Example 4 - throw exceptions by layers

// Lowest layer (data layer)
public class DataAccessLayer
{
    private readonly ILogger _logger;

    public DataAccessLayer(ILogger logger)
    {
        _logger = logger;
    }

    // Lowest level layer
    public string GetRowData()
    {
        try
        {
            return "some row data";
        }
        catch (Exception ex)
        {
            // if an exception is thrown at DataAccessLayer, it is logged and rethrown
            // later will be handled by the next layer
            _logger.LogError("Error in DataAccessLayer: " + ex);
            throw; // rethrowing the exception
        }
    }
}

// Business Layer
public class BusinessLayer
{
    private readonly DataAccessLayer _data;
    private readonly ILogger _logger;

    public BusinessLayer(DataAccessLayer data, ILogger logger)
    {
        _data = data;
        _logger = logger;
    }

    public string GetProcessedData()
    {
        try
        {
            var rawData = _data.GetRowData();
            return rawData.Trim();
        }
        catch (Exception ex)
        {
            // rethrown the exception to upper layer
            _logger.LogError("Error in BusinessLAyer" + ex);
            throw;
        }
    }
}

// Graphical User Interface Layer (GUI Layer)
public class GuidLayer
{
    private readonly BusinessLayer _businessLayer;
    private readonly ILogger _logger;

    public GuidLayer(BusinessLayer businessLayer, ILogger logger)
    {
        _businessLayer = businessLayer;
        _logger = logger;
    }

    public void ShowToUser()
    {
        try
        {
            var data = _businessLayer.GetProcessedData();
            Console.WriteLine($"Showing to user:{data}");
        }
        catch (Exception ex)
        {
            _logger.LogError("Error in GUI Layer:" + ex);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Exception error:" + ex.Message);
        }
    }
}