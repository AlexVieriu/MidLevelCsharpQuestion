using static System.Console;

var numbers = new[] { 1, 4, 7, 19, 2 };

// Example 1:
Func<int, DateTime, string, decimal> somefunc;
Action<string, string, bool> someAction;
// Exercises

// Example 2
Func<int, bool> predicate1 = IsLargerThan10;
Func<int, bool> predicate2 = IsAnyEven;

WriteLine("IsAnyLargerThan10? " + IsAny(numbers, predicate1));
WriteLine("IsAnyEven? " + IsAny(numbers, predicate2));

WriteLine("IsAnyLargerThan10? " + IsAny(numbers, IsLargerThan10));
WriteLine("IsAnyEven? " + IsAny(numbers, IsAnyEven));


// With Func
bool IsLargerThan10(int number) => number > 10;
bool IsAnyEven(int number) => number % 2 == 0;

// We can add other methods and use the method IsAny with them
bool IsAny(IEnumerable<int> numbers, Func<int, bool> predicate)
{
    foreach (var number in numbers)
    {
        if (predicate(number)) 
            return true;
    }
    return false;
}

// Without Func

bool IsLargerThan10_V2(IEnumerable<int> numbers)
{
    foreach (var number in numbers)
    {
        if (number > 10)
            return true;
    }
    return false;
}

bool IsAnyEven_V2(IEnumerable<int> numbers)
{
    foreach (var number in numbers)
    {
        if (number % 2 == 0)
            return true;
    }
    return false;
}
