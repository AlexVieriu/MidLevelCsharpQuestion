[AttributeUsage(AttributeTargets.Property)]
class StringLengthValidateAttribute : Attribute
{
    public int Min { get; }
    public int Max { get; }
    public StringLengthValidateAttribute(int min, int max)
    {
        Min = min;
        Max = max;
    }
}
