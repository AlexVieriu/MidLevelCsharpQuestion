// Example 1: Unmanaged resources

// "using" keyword is using IDispose behind the scene
string currentDirectory = Directory.GetCurrentDirectory();
string outputPath = Path.Combine(currentDirectory, "output.txt");

if (Directory.Exists(Path.GetDirectoryName(outputPath)))
    using (StreamWriter writer = File.CreateText(outputPath))
    {
        writer.WriteLine("Hello World!");
    }

using (StreamReader reader = File.OpenText(outputPath))
{
    string line1 = reader.ReadLine();
    string line2 = reader.ReadLine();
}

File.Delete(outputPath);


// Example 2 (min 6:00)
SomeMethod();

GC.Collect();
Console.ReadKey();

void SomeMethod()
{
    var john = new Person("John");
}


// Example 1
class FileReader : IDisposable
{
    private StreamReader _streamReader;
    private readonly string _path;

    public FileReader(string path)
    {
        _path = path;
    }

    public string ReadLine()
    {
        _streamReader ??= new StreamReader(_path);
        return _streamReader.ReadLine();
    }

    public void Dispose()
    {
        _streamReader?.Dispose();
    }
}

// Example 2 -> destructor, finalizer, Finalize
class Person
{
    public string Name { get; set; }
    public Person(string name) => Name = name;

    //// you can't call the method in .NET core or later(more in the documentation)
    //protected override void Finalize()  
    //{
    //    Console.WriteLine($"Person {Name} is being destructed");
    //}

    ~Person()
    {
        Console.WriteLine($"Person {Name} is being destructed");
    }
}
