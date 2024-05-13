public class LogAttribute : Attribute
{
    public string Category { get; set; }
    public bool IncludeArguments { get; set; }

    public LogAttribute(string category, bool includeArguments = false)
    {
        Category = category;
        IncludeArguments = includeArguments;
    }
}
