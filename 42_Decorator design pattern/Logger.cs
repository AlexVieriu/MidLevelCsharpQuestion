namespace _42_Decorator_design_pattern;

public class Logger : ILogger
{
    public void Log(string message)
    {
        WriteLine($"[LOG] {message}");
    }
}
