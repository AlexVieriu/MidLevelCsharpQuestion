using System.Diagnostics;
using static System.Console;

// Example 1
WriteLine("- - - Example 1 - - - ");
WriteLine("Double: " + (0.3d == 0.2d + 0.1d));
WriteLine("Decimal: " + (0.3m == 0.2m + 0.1m));

// compare double the right way
WriteLine($"AreEqual: {AreEqual(0.3d, 0.2d + 0.1d, 0.0001)}");
WriteLine("Divide 0/0: " + 0d / 0d);
//WriteLine(0m / 0m);

// Example 2 - performance
WriteLine();
WriteLine("- - - Example 2 - - - ");
int iterations = 30000000; // 3 millions
var resultFromDouble = DoubleTest(iterations);
var resultFromDecimal = DecimalTest(iterations);

WriteLine("Double: " + resultFromDouble + " milliseconds");
WriteLine("Decimal: " + resultFromDecimal + " milliseconds");

ReadKey();

// Example 1
bool AreEqual(double a, double b, double tolerance) => Math.Abs(a - b) <= tolerance;

// Example 2 - measure performance
long DoubleTest(int iterations)
{
    Stopwatch sw = Stopwatch.StartNew();
    double z = 0;
    for (int i = 0; i < iterations; i++)
    {
        double x = i;
        double y = x * i;
        z += y;
    }
    sw.Stop();
    return sw.ElapsedMilliseconds;
}

long DecimalTest(int iterations)
{
    Stopwatch sw = Stopwatch.StartNew();
    decimal z = 0;
    for (int i = 0; i < iterations; i++)
    {
        decimal x = i;
        decimal y = x * i;
        z += y;
    }
    sw.Stop();
    return sw.ElapsedMilliseconds;
}
