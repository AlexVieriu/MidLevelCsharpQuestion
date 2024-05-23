// Example 1
var immutablePoint = new ImmutablePoint(4, 2);
immutablePoint.X = 1;

// Example 3 - keeping objects valid 
// if properties are mutable, we don't know when someone can change a property
var person = new Person("123451234", "John", 1982);
person.Id = null;

// this is bad practice: we need to put validations
if (string.IsNullOrEmpty(person.Name) || person.Name.Length < 2 || person.Name.Length > 25)
    Console.WriteLine("Do something");
else
    Console.WriteLine("Handle the errors");

// Example 4 - avoiding identity mutation
var dictionary = new Dictionary<Person, string>();
var person2 = new Person("123451234", "John", 1982);
dictionary[person2] = "aaa";
person2.Id = "new Id";
Console.WriteLine(dictionary[person2]);  // runtime error


Console.ReadKey();

