public class Dog
{
    [StringLengthValidateAttribute(2, 10)]
    public string Name { get; } // length must be between 2 and 10
    public Dog(string name) => Name = name;
}
