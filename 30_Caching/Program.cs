// Example 1
var peopleController = new PeopleController(new PeopleRepositoryMock());

var john = peopleController.GetByName_OwnCache("John", "Smith");
john = peopleController.GetByName_OwnCache("John", "Smith");

Console.WriteLine(john.FirstName + " " + john.LastName);
Console.WriteLine();


// Example 2 - Microsoft implementation: Microsoft.Extensions.Caching.Memory
var john2 = peopleController.GetByName_MicrosoftCache("John", "Smith");
john2 = peopleController.GetByName_MicrosoftCache("John", "Smith");

Console.WriteLine(john2.FirstName + " " + john2.LastName);
Console.WriteLine();

Console.ReadKey();
