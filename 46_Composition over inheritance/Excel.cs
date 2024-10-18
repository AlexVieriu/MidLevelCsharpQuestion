class Excel : PersonalDataFormatter
{
    public override IEnumerable<Person> ReadPeople()
    {
        return new List<Person>
        {
            new Person() {Name ="Alex3", Country="Romania", YearOfBirth=1989},
            new Person() {Name ="Hannelyn3", Country="Philippines", YearOfBirth=1992},
            new Person() {Name ="Che3", Country="Philippines", YearOfBirth=1998}
        };
    }
}
