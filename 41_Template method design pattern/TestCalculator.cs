using static System.Console;

class TestCalculator : TestFixture
{
    private Calculator _cut;
    protected override IEnumerable<Func<bool>> GetTests()
    {
        return new List<Func<bool>>
        {
            ()=>
            {
                WriteLine("3 + 2 = 5");
                return _cut.Add(3,2) == 5;
            },
            ()=>
            {
                WriteLine("10 + (-10) = 0");
                return _cut.Add(10,-10) == 0;
            }
        };
    }

    protected override void SetUp()
    {
        _cut = new Calculator();
        WriteLine("Setup TestCalculator class");
    }

    protected override void TearDown()
    {
        WriteLine("TearDown TestCalculator class\n");
    }
}