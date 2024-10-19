public class EnthusiasticGreeter
{
    readonly Action<string> _printToConsole;

    public EnthusiasticGreeter(Action<string> printToConsole)
    {
        _printToConsole = printToConsole;
    }

    public void PrintHelloNTimes(int n)
    {
        for (int i = 0; i < n; i++)
        {
            _printToConsole("Hello!");
        }
    }
}
