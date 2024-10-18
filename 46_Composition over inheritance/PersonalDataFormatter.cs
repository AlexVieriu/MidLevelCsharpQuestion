class PersonalDataFormatter
{
    public string Format()
    {
        var people = ReadPeople();

        return string.Join("\n",
            people.Select(p => $"{p.Name} born in {p.Country} on {p.YearOfBirth}"));
    }

    public virtual IEnumerable<Person> ReadPeople()
    {
        return new List<Person>
        {
            new Person() {Name ="Alex", Country="Romania", YearOfBirth=1989},
            new Person() {Name ="Hannelyn", Country="Philippines", YearOfBirth=1992},
            new Person() {Name ="Che", Country="Philippines", YearOfBirth=1998}
        };
    }
}
