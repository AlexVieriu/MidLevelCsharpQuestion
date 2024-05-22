interface IRepository<T> where T : class
{
    IEnumerable<Person> GetByName(string firstName, string lastName);
}
