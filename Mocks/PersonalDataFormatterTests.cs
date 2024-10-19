[TestFixture]
public class PersonalDataFormatterTests
{
    private Mock<IPeopleDataReader> _peopleDataReaderMock;
    private PersonalDataFormatter _cut;

    [SetUp]
    public void SetUp()
    {
        _peopleDataReaderMock = new Mock<IPeopleDataReader>();
        _cut = new PersonalDataFormatter(
            _peopleDataReaderMock.Object);
    }

    [Test]
    public void ShallFormatPersonalDataCorrectly()
    {
        _peopleDataReaderMock.Setup(mock => mock.ReadPeople())
            .Returns(new List<Person>
                {
                        new Person("Person1", 1982, "Country1"),
                        new Person("Person2", 1992, "Country2"),
                        new Person("Person3", 1954, "Country3"),
                });

        var result = _cut.Format();
        var expectedResult = @"Person1 born in Country1 on 1982
                                   Person2 born in Country2 on 1992
                                   Person3 born in Country3 on 1954";
        Assert.Equals(expectedResult, result);
    }
}
