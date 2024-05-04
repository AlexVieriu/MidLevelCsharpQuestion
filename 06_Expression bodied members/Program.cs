var person = new Person("Alex", 1989);

// Example 1
Console.WriteLine(person.ToString());

// Example 2 
person.Print();

// Example 3
Console.WriteLine($"Age: {person.Age}");

// Example 4
var person2 = new Person("Alex");

public class Person
{
    public string Name { get; set; }
    public int YearOfBirth { get; set; }

    // Example 3
    public int Age => DateTime.Now.Year - YearOfBirth;

    // Example 4
    public Person(string name) => Name = name;

    public Person(string name, int yearOfBirth)
    {
        Name = name;
        YearOfBirth = yearOfBirth;
    }

    // Example 1
    public override string ToString() => $"{Name} who was born on {YearOfBirth}";

    // Example 2
    public void Print() => Console.WriteLine("This is an expression body method");
}