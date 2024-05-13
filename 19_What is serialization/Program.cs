using static System.Console;

// Example 1

const string filePath = "personalData.xml";

if (File.Exists(filePath))
{
    XmlHelpers.Deserialize(filePath);
}
else
{
    var name = Read("name");
    var lastName = Read("last name");
    var residence = Read("place of residence");
    var hobby = Read("hobby");

    var person = new Person(name, lastName, residence, hobby);
    var xml = XmlHelpers.Serialize(person);
    XmlHelpers.SaveToXmlFile(xml, filePath); // the folder is in: "..\bin\Debug\net9.0\personalData.xml"
}

ReadKey();


// Example 1
static string Read(string what)
{
    WriteLine($"Enter the {what}");
    return ReadLine();
}
