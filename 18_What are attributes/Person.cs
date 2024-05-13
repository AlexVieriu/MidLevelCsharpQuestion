public class Person
{
    [StringLengthValidateAttribute(2, 25)]
    public string Name { get; set; } 
    public int YearOfBirth { get; set; }

    public Person(string name, int yearOfBirth)
    {
        Name = name;
        YearOfBirth = yearOfBirth;
    }

    public Person(string name) => Name = name;
}
