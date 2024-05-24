using static System.Console;
// Example 1 
var person = new { Name = "Martin", City = "Savannah", Age = 35 };

//person.Name = "Jack"; // readonly fields

WriteLine($"The person name is {person.Name}, he lives in city {person.Name} and is {person.Age} years old");
WriteLine();

// Example 2 
var pets = new[]
{
    new Pet("Hannibal", PetType.Fish, 1.1f),
    new Pet("Anthony", PetType.Cat, 2f),
    new Pet("Ed", PetType.Cat, 0.7f),
    new Pet("Taiga", PetType.Dog, 35f),
    new Pet("Rex", PetType.Dog, 40f),
    new Pet("Lucky", PetType.Dog, 5f),
    new Pet("Storm", PetType.Cat, 0.9f),
    new Pet("Nyan", PetType.Cat, 2.2f)
};

// Version 1
var averageWeightData = pets
    .GroupBy(pet => pet.PetType)
    .Select(grouping => new
    {
        PetType = grouping.Key,     // ??
        AverageWeightData = grouping.Average(pet => pet.Weight)
    })
    .OrderBy(data => data.AverageWeightData)
    .Select(data => $"Average weight for {data.PetType} is {data.AverageWeightData}");

// Version 2
var averageWeightData2 = pets
    .GroupBy(pet => pet.PetType)
    .Select(grouping => new
    {
        grouping.Key,     // ??
        grouping.Average(pet => pet.Weight) // we need to give it a name, otherwise will not compile
    })
    .OrderBy(data => data.AverageWeightData)
    .Select(data => $"Average weight for {data.Key} is {data.AverageWeightData}");

foreach (var data in averageWeightData)
{
    WriteLine(data);
}


// Example 3 - support non-destructive mutation with the "with" keyword
var someObj = new { number = 5, text = "hello" };
var modified = someObj with { text = "hi" };


ReadKey();


class Pet
{
    public string Name { get; }
    public PetType PetType { get; set; }
    public float Weight { get; set; }
    public Pet(string name, PetType petType, float weight)
    {
        Name = name;
        PetType = petType;
        Weight = weight;
    }
}

enum PetType
{
    Fish,
    Cat,
    Dog
}