using _42_Decorator_design_pattern;

public class Logging_WithDecorator : IPeopleDataReader
{
    private readonly IPeopleDataReader _decoratorReader;
    private readonly ILogger _logger;

    public Logging_WithDecorator(
        IPeopleDataReader decoratorReader, ILogger logger)
    {
        _decoratorReader = decoratorReader;
        _logger = logger;
    }
    public IEnumerable<Person> Read()
    {
        var data = _decoratorReader.Read();
        _logger.Log($"[LOG] Read {data.Count()} elements");
        return data;
    }
}