using System.Reflection;

var converter = new ObjectToTextConvert();
Console.WriteLine(converter.Convert(new House("123 Maple Road", 170.6, 2)));

Console.ReadKey();

class ObjectToTextConvert
{
    public string Convert(object obj)
    {
        Type type = obj.GetType();
        var properties = type.GetProperties().Where(p => p.Name != "EqualityContract");

        return string.Join(", ", properties.Select(property => $"{property.Name} is {property.GetValue(obj)}"));
    }
}

public record Pet(string Name, PetType PetType, float Weight);
public record House(string Address, double Area, int Floors);
public enum PetType { Cat, Dog, Fish }


//1.Loading DLLs at runtime
// Load a DLL by its name
Assembly myAssembly = Assembly.Load("MyLibrary");

// Access types and members from the loaded assembly
Type myType = myAssembly.GetType("MyLibrary.SomeClass");
MethodInfo myMethod = myType.GetMethod("DoSomething");

//2.Instantiating objects at runtime:
// Get the type information for the class
Type myType = typeof(MyClass);

// Create an instance using the default constructor
object myObject = Activator.CreateInstance(myType);

// Optionally, use a constructor with parameters
ConstructorInfo ctor = myType.GetConstructor(new[] { typeof(string) });
object parameterizedObject = ctor.Invoke(new object[] { "Hello" });

//3.Finding all classes with a given base type or implemented interface:
// Get all types from the loaded assemblies
Type[] allTypes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes()).ToArray();

// Find classes that inherit from a specific base type
Type baseType = typeof(MyBaseClass);
var derivedTypes = allTypes.Where(t => t.IsSubclassOf(baseType));

// Find classes that implement a specific interface
Type interfaceType = typeof(IMyInterface);
var implementingTypes = allTypes.Where(t => interfaceType.IsAssignableFrom(t));

//4.Reading attributes:
// Get the type information for the class
Type myType = typeof(MyClass);

// Get all custom attributes applied to the class
object[] attributes = myType.GetCustomAttributes(true);

// Check for specific attribute types
if (myType.IsDefined(typeof(MyCustomAttribute)))
{
    MyCustomAttribute attribute = (MyCustomAttribute)myType.GetCustomAttributes(typeof(MyCustomAttribute), true)[0];
    Console.WriteLine(attribute.Description);
}
