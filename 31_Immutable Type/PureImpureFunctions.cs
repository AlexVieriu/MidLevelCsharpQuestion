// Example 2 - Pure/Impure functions
class PureImpureFunctions
{
    // Pure
    int Sum(IEnumerable<int> numbers)
    {
        var sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    // Impure - there are 2 separate functions that to the sum(Add and SumSoFar)
    private int _sum = 0;
    public int SumSoFar(int number)
    {
        _sum += number;
        return _sum;
    }

    public void Add(List<int> list, int number)
    {
        list.Add(number);
    }
}

