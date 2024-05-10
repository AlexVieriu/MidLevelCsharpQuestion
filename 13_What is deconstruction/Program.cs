using static System.Console;

// Example 1 - - - - - - - - - - - - - - - - - - - - - - - -
var numbers = new[] { 1, 4, 2, 6, 11, 5, 83, 1, 2 };
var analysisResult = AnalyzerNumber(numbers);

// Case 1: store the ValueTuple in variables
var count = analysisResult.count;
var sum = analysisResult.sum;
var average = analysisResult.average;

// Case 2:
var (sum1, count1, average1) = AnalyzerNumber(numbers);

// Case 3: if we don't want to declare a variable we use _
var (sum2, _, average2) = AnalyzerNumber(numbers);

// Case 4: deconstruct ValueTuple into variables that we already have
int sum3;
double average3;
(sum3, var count3, average3) = AnalyzerNumber(numbers);

// Case 5: deconstruct ordinary tuples
var tuple = Tuple.Create("abc", 10, true);
var (text, number, boolean) = tuple;


if (analysisResult.count == 0)
    WriteLine("The collection is empty");
else
    WriteLine($"The collection has {count}/{count1} elements, " +
        $"with total sum of {sum}/{sum2}/{sum3} and " +
        $"average of {average}/{average1}/{average2}/{average3}");


// Example 2  - - - - - - - - - - - - - - - - - - - - - - - -
var pet = new Pet("Hannibal", PetType.Fish, 1.1f);

// working only with Deconstruct method implemented in the class
var (name, type, weight) = pet;


// Example 3 - deconstruct a DateTime object
var date = new DateTime(2022, 1, 1);
var (year, month, day) = date;


// Example 1 - - - - - - - - - - - - - - - - - - 
(int sum, int count, double average) AnalyzerNumber(IEnumerable<int> numbers)
{
    var sum = 0;
    var count = 0;
    foreach (var number in numbers)
    {
        sum += number;
        count++;
    }

    var average = (double)sum / count;
    return (sum, count, average);
}

// Example 2 - - - - - - - - - - - - - - - - - - 
class Pet
{
    public string Name { get; set; }
    public PetType PetType { get; set; }
    public float Weight { get; set; }

    public Pet(string name, PetType petType, float weight)
    {
        Name = name;
        PetType = petType;
        Weight = weight;
    }

    // Adding Deconstruct method- it is C# method for tuple 
    // https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/deconstruct
    public void Deconstruct(out string name, out PetType type, out float weight)
    {
        name = Name;
        type = PetType;
        weight = Weight;
    }
}

enum PetType
{
    Fish
}