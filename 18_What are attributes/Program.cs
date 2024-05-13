using static System.Console;

// Example 1
WriteLine("- - - Example 1 - - -");
var validPerson = new Person("John", 1981);
var invalidDog = new Dog("R");
var validator = new Validator();

WriteLine(validator.Validate(validPerson) ? "Person is valid" : "Person isn't valid");
WriteLine(validator.Validate(invalidDog) ? "Dog is valid" : "Dog isn't valid");


// Example 2 - from ChatGPT 3.5
WriteLine();
WriteLine("- - - Example 2 - - -");
// Get the custom attributes applied to MyClass
Type type = typeof(MyClass);
object[] classAttributes = type.GetCustomAttributes(typeof(MyCustomAttribute), false);
foreach (MyCustomAttribute attribute in classAttributes)
{
    WriteLine("Class Attribute: " + attribute.Description);
}

// Get the custom attributes applied to MyMethod
var method = type.GetMethod("MyMethod");
object[] methodAttributes = method.GetCustomAttributes(typeof(MyCustomAttribute), false);
foreach (MyCustomAttribute attribute in methodAttributes)
{
    WriteLine("Method Attribute: " + attribute.Description);
}

ReadKey();

// Example 2
// Define a custom attribute
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class MyCustomAttribute : Attribute
{
    private string description;

    public MyCustomAttribute(string description) => this.description = description;

    public string Description
    {
        get { return description; }
    }
}

// Apply the custom attribute to a class and method
[MyCustom("This is a class attribute")]
class MyClass
{
    [MyCustom("This is a method attribute")]
    public void MyMethod() => WriteLine("Executing MyMethod");
}


