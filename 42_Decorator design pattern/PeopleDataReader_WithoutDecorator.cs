// PeopleDataReader class with all the logic in it
class PeopleDataReader_WithoutDecorator : IPeopleDataReader
{
    private readonly bool _shallLog;
    private readonly ILogger _logger;
    private readonly bool _shallLimitCount;
    private readonly int _countLimit;

    public PeopleDataReader_WithoutDecorator(
        bool shallLog, ILogger logger, bool shallLimitCount, int countLimit = 0)
    {
        _shallLog = shallLog;
        _logger = logger;
        _shallLimitCount = shallLimitCount;
        _countLimit = countLimit;
    }

    public IEnumerable<Person> Read()
    {
        var data = new List<Person>
        {
            new Person("Martin", 1972, "France"),
            new Person("Aiko", 1995, "Japan"),
            new Person("Selene", 1944, "Great Britain"),
            new Person("Michael", 1980, "Canada"),
            new Person("Anne", 1974, "New Zealand")
        };

        if (_shallLog)
            _logger.Log($"Read {data.Count} elements");

        return _shallLimitCount ? data.Take(_countLimit) : data;
    }
}
