class Database : PersonalDataFormatter
{
    public override IEnumerable<Person> ReadPeople()
    {
        return new List<Person>
        {
            new Person() {Name ="Alex2", Country="Romania", YearOfBirth=1989},
            new Person() {Name ="Hannelyn2", Country="Romania", YearOfBirth=1992},
            new Person() {Name ="Che2", Country="Romania", YearOfBirth=1998}
        };
    }
}
