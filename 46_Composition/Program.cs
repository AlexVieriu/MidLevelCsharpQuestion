var peopleFormatter = new PeopleFormatter(new Excel());

Console.WriteLine(peopleFormatter.Format());

// Entities (Domain Layer)
public class Person
{
    public string Name { get; set; }
    public string Country { get; set; }
    public int YearOfBirth { get; set; }
}

// Application Layer (Use Cases)
public interface IGetPeoplePersonalData
{
    public IEnumerable<Person> ReadPeople();
}

public class PeopleFormatter
{
    private readonly IGetPeoplePersonalData _getPeople;

    public PeopleFormatter(IGetPeoplePersonalData getPeople)
    {
        _getPeople = getPeople;
    }

    public string Format()
    {
        var people = _getPeople.ReadPeople();

        return string.Join("\n",
            people.Select(p => $"{p.Name} born in country {p.Country} on year {p.YearOfBirth}"));
    }
}

// Infrastructure Layer
public class Excel : IGetPeoplePersonalData
{
    public IEnumerable<Person> ReadPeople()
    {
        return new List<Person>
        {
            new Person() {Name ="Alex3", Country="Romania", YearOfBirth=1989},
            new Person() {Name ="Hannelyn3", Country="Philippines", YearOfBirth=1992},
            new Person() {Name ="Che3", Country="Philippines", YearOfBirth=1998}
        };
    }
}

public class Database : IGetPeoplePersonalData
{
    public IEnumerable<Person> ReadPeople()
    {
        return new List<Person>
        {
            new Person() {Name ="Alex2", Country="Romania", YearOfBirth=1989},
            new Person() {Name ="Hannelyn2", Country="Romania", YearOfBirth=1992},
            new Person() {Name ="Che2", Country="Romania", YearOfBirth=1998}
        };
    }
}