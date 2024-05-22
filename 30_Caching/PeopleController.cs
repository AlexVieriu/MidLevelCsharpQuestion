using Microsoft.Extensions.Caching.Memory;

class PeopleController
{
    private readonly IRepository<Person> _repository;

    // Our own cache implementation
    private Cache<(string, string), Person> _personCache = new Cache<(string, string), Person>();

    // Microsoft cache
    private readonly MemoryCache _memoryCache = new MemoryCache(new MemoryCacheOptions());

    public PeopleController(IRepository<Person> repository)
    {
        _repository = repository;
    }

    public Person? GetByName_OwnCache(string firstName, string lastName)
    {
        return _personCache.Get(
            (firstName, lastName),
            () => _repository.GetByName(firstName, lastName).FirstOrDefault());
    }

    // Adding Microsoft caching
    public Person? GetByName_MicrosoftCache(string firstName, string lastName)
    {
        return _memoryCache.GetOrCreate(
            (firstName, lastName), 
            cacheEntry => _repository.GetByName(firstName, lastName).FirstOrDefault());
    }
}
