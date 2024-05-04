namespace _05_Dynamic_keyword;

public class DynamicConstructor
{
    public string Text { get; }
    public DynamicConstructor(dynamic fullText)
    {
        Text = fullText;
    }
}
