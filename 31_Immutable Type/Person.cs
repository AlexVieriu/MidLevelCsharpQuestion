// Example 3
public class Person
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int YearOfBirth { get; set; }
    public Person(string id, string name, int yearOfBirth)
    {
        if (string.IsNullOrEmpty(id) || id.Length != 9 || !id.All(character => char.IsDigit(character)))
            throw new ArgumentException("Id is invalid");


        if (string.IsNullOrEmpty(name) || name.Length < 2 || name.Length > 4)
            throw new ArgumentException("Name is invalid");

        if (yearOfBirth == 1900 | yearOfBirth > DateTime.Now.Year)
            throw new ArgumentException("YearOfBirth is invalid");

        Id = id;
        Name = name;
        YearOfBirth = yearOfBirth;
    }

    // Example 4 - avoiding identity mutation
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

