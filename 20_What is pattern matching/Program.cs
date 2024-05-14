Console.ReadKey();

// Example 1
string NullCheck(object obj)
{
    // without pattern matching 
    if (obj is string)
    {
        var asString1 = obj as string;
        Console.WriteLine("String is:" + asString1);
    }
    // with pattern matching
    if (obj is string asString2)
        Console.WriteLine("String is:" + asString2);
    
    return "Object is not null";
}

// Example 2
string Properties(object obj)
{
    // Weight: > 10000 -> pattern matching
    if (obj is Pet { Weight: > 10000, TypeOfPet: PetType.Fish })
        return "It must be a whale shark!";

    if (obj is Pet)
        return "It's some pet";
    return "Definitely not a pet";
}

// Example 3
object ComparingDiscreteValues(string number, string type)
{
    // depending on second param, we convert the first param using pattern matching
    return type switch
    {
        "int" => int.Parse(number),
        "decimal" => decimal.Parse(number),
        "float" => float.Parse(number),
        _ => throw new ArgumentException($"type '{type}' is not valid")
    };
}

// Example 4
string Relational(int age)
{
    return age switch
    {
        // the logical pattern
        (> 20) and (< 60) => "middle-aged",
        < 20 => "Teenager",
        > 60 => "senior",
        < 11 => "child",
        18 => "just and adult"
    };
}

// Example 5
string Deconstruction(Pet pet)
{
    return pet switch
    {
        (_, PetType.Dog, 10) => "Small of any name",
        ("Hannibal", PetType.Fish, _) => "Fish called Hannibal",
        Pet { Weight: > 100 } => "Heavy Pet",
        _ => "Unknown pet!"
    };
}

public record Pet(string Name, PetType TypeOfPet, float Weight);
public enum PetType { Cat, Dog, Fish }