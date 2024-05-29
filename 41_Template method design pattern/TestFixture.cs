abstract class TestFixture
{
    public bool Run()
    {
        var failedTestsCount = 0;
        foreach (var test in GetTests())
        { 
            SetUp();
            if (!test())
                ++failedTestsCount;
            TearDown();
        }
        return failedTestsCount == 0;
    }

    protected abstract IEnumerable<Func<bool>> GetTests();
    protected abstract void SetUp();
    protected abstract void TearDown();
}
