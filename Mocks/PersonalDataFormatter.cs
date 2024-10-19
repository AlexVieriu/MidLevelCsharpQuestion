class PersonalDataFormatter
{
    private readonly IPeopleDataReader _peopleDataReader;

    public PersonalDataFormatter(
        IPeopleDataReader peopleDataReader)
    {
        _peopleDataReader = peopleDataReader;
    }

    public string Format()
    {
        var people = _peopleDataReader.ReadPeople();
        return string.Join(Environment.NewLine,
            people.Select(p => $"{p.Name} born in" +
            $" {p.Country} on {p.YearOfBirth}"));
    }
}
