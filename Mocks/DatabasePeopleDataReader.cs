public class DatabasePeopleDataReader : IPeopleDataReader
{
    public IEnumerable<Person> ReadPeople()
    {
        Console.WriteLine("Reading from real database");
        return new List<Person>
            {
                new Person("John", 1982, "USA"),
                new Person("Aja", 1992, "India"),
                new Person("Tom", 1954, "Australia"),
            };
    }
}
