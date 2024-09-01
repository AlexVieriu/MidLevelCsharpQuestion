// Ex 0: without decorator
IPeopleDataReader peopleDataReader =
    new PeopleDataReader_WithoutDecorator(true, new Logger(), true, 3);

// Order of Decorators matters! Below code will give different result

// Ex 1: Limiting then logging
IPeopleDataReader logging_Limiting_PeopleDataReader =
    new Limiting_WithDecorator(3,
        new Logging_WithDecorator(
            new PeopleDataReader(),
            new Logger()));

// Ex 2: Logging then limiting
IPeopleDataReader logging_Limiting_PeopleDataReader2 =
    new Logging_WithDecorator(
        new Limiting_WithDecorator(3, new PeopleDataReader()),
        new Logger());

// Ex 3: only logging
IPeopleDataReader logging_PeopleDataReader =
    new Logging_WithDecorator(
        new PeopleDataReader(),
        new Logger());

// Ex: 0
WriteLine("- - - Ex 0: Without Decorator - - -");
var people0 = peopleDataReader.Read();
foreach (var person in people0)
    WriteLine(person.Name, person.YearOfBirth, person.Country);

// Ex: 1
WriteLine("- - - Ex 1: With Decorator -> Limiting then logging - - -");
var people1 = logging_Limiting_PeopleDataReader.Read();
foreach (var person in people1)
    WriteLine(person.Name, person.YearOfBirth, person.Country);

// Ex: 2
WriteLine("- - - Ex 2: With Decorator -> Logging then limiting - - -");
var people2 = logging_Limiting_PeopleDataReader2.Read();
foreach (var person in people2)
    WriteLine(person.Name, person.YearOfBirth, person.Country);

// Ex: 3
WriteLine("- - - Ex 3: With Decorator -> Only Logging - - -");
var people3 = logging_PeopleDataReader.Read();
foreach (var person in people3)
    WriteLine(person.Name, person.YearOfBirth, person.Country);

ReadKey();
