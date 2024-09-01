namespace _42_Decorator_design_pattern;

public class Limiting_WithDecorator : IPeopleDataReader
{
    private readonly int _countLimit;
    private readonly IPeopleDataReader _decoratorReader;

    public Limiting_WithDecorator(int countLimit, IPeopleDataReader decoratorReader)
    {
        _countLimit = countLimit;
        _decoratorReader = decoratorReader;
    }

    public IEnumerable<Person> Read()
    {
        WriteLine($"LIMITTING the count to {_countLimit} elements");
        return _decoratorReader.Read().Take(_countLimit);
    }
}
