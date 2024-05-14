using System.Diagnostics;

// Example 1
Console.WriteLine("- - - Example 1 - - -");
int twoBillions = 2000000000;
int result = twoBillions + twoBillions;
Console.WriteLine("the result is: " + result); // output: -294967296


// Example 2
Console.WriteLine();
Console.WriteLine("- - - Example 2 - - -");
const int setSize = 10000000;

var checkResult = MeasureChecked(setSize);
GC.Collect();
var uncheckedResult = MeasureUnChecked(setSize);

Console.WriteLine($"Checked: {checkResult} milliseconds");
Console.WriteLine($"UnChecked: {uncheckedResult} milliseconds");
Console.WriteLine($"Checked took: {((double)(double)checkResult / (double)uncheckedResult)} % longer");

// Example 3
Console.WriteLine();
Console.WriteLine("- - - Example 3 - - -");
SomeMethodWithCheckedScopeInside();


// Example 2
static long MeasureChecked(int sizeSize)
{
    var stopwatch = Stopwatch.StartNew();

    int a = 1;
    int b = 2;

    checked
    {
        for (int i = 0; i < sizeSize; i++)
        {
            a = i + b + a;
            a = 1;
        }
    }

    stopwatch.Stop();
    return stopwatch.ElapsedMilliseconds;
}

static long MeasureUnChecked(int sizeSize)
{
    var stopwatch = Stopwatch.StartNew();

    int a = 1;
    int b = 2;

    unchecked
    {
        for (int i = 0; i < sizeSize; i++)
        {
            // additional checks
            if (((long)i + (long)b + (long)a) > int.MaxValue)
            {
                throw new InvalidOperationException(
                    "The multiplication will result in int overflow");
            }
            a = i + b + a;
            a = 1;
        }
    }

    stopwatch.Stop();
    return stopwatch.ElapsedMilliseconds;
}

// Example 3
int Add(int a, int b) => a + b;

// the checked scope doesn't affect any methods that are called within it
void SomeMethodWithCheckedScopeInside()
{
    int twoBillion = 2000000000;
    try
    {
        // add the checked keyword inside the Add() method so the catch block will be called
        checked
        {
            int i = Add(twoBillion, twoBillion);
        }
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Exception!");
    }    
    Console.WriteLine("Done!"); // only this one is called 
}
