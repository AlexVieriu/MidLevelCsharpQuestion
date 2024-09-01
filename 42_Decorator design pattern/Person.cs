public class Person
{
    public Person(string name, int yearOfBirth, string country)
    {
        Name = name;
        YearOfBirth = yearOfBirth;
        Country = country;
    }

    public string Name { get; }
    public int YearOfBirth { get; }
    public string Country { get; }
}