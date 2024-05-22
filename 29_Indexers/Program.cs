// Example 1
var numbers = new int[] { 10, 20, 30 };
var thirOfArray = numbers[2];

var list = new List<decimal> { 5.5m, 3m, 0m };
var thirdElement = list[2];

var text = "hello";

var currencies = new Dictionary<string, string>
{
    ["USA"] = "USD",
    ["Great Britain"] = "GBP",
    ["Poland"] = "PLN"
};
var currencyInGreatBritain = currencies["Great Britain"];


// Example 2 - implement our own class with index
var numbers2 = new ClassWithoutIndex<int>([1, 2, 3, 4]);
numbers2[2] = 0;

var numbers3 = new ClassWithIndex<int>([1, 2, 3, 4]);
numbers3[2] = 0;

var numbers3Str = numbers3["3"];

var number3MultipleIndexers = numbers3[1, 2];


Console.ReadKey();


// Example 2 - define our own indexers
class ClassWithoutIndex<T>
{
    private T[] _elements;

    public ClassWithoutIndex(T[] elements)
    {
        _elements = elements;
    }
}

class ClassWithIndex<T>
{
    private T[] _elements;

    public ClassWithIndex(T[] elements)
    {
        _elements = elements;
    }

    public T this[int index]
    {
        get => _elements[index];
        set => _elements[index] = value;
    }

    // string indexers
    public T this[string index]
    {
        get => _elements[int.Parse(index)];
        set => _elements[int.Parse(index)] = value;
    }

    // multiple indexes
    public T this[int index1, int index2]
    {
        get => _elements[index1 + index2];
        set => _elements[index1 + index2] = value;
    }
}