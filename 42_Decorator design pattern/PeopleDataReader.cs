namespace _42_Decorator_design_pattern;

public class PeopleDataReader : IPeopleDataReader
{
    public IEnumerable<Person> Read()
    {
        return new List<Person>
        {
            new Person("Martin", 1972, "France"),
            new Person("Aiko", 1995, "Japan"),
            new Person("Selene", 1944, "Great Britain"),
            new Person("Michael", 1980, "Canada"),
            new Person("Anne", 1974, "New Zealand")
        };
    }
}
