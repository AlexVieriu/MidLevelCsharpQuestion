class PeopleRepositoryMock : IRepository<Person>
{
    public IEnumerable<Person> GetByName(string firstName, string lastName)
    {
        if (firstName == "John" && lastName == "Smith")
            return [new Person("John", "Smith")];

        throw new NotImplementedException();
    }
}
