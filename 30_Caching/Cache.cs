class Cache<TKey, TValue> where TKey : notnull
{
    private readonly Dictionary<TKey, TValue> _cachedData = new Dictionary<TKey, TValue>();
    private int _cacheSuccessRate = 0;

    public TValue Get(TKey key, Func<TValue> getValueForTheFirstTime)
    {
        if (!_cachedData.ContainsKey(key))
            _cachedData[key] = getValueForTheFirstTime();
        else
            // implement it so you can see if the cache is really needed(higher is better)
            _cacheSuccessRate++;    

        return _cachedData[key];
    }
}
