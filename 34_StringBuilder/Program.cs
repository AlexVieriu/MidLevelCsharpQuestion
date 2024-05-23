using System.Diagnostics;
using System.Text;
using static System.Console;

// Example 1
// what happen here is creating a new object that has the value "def", and the reference point to obj1
// is now pointing to obj2 that has the value "def"
// the Garbage collector will see the old objects with no reference and will remove them from memory
var someString = "abc"; // obj1
someString = "def";     // obj2
someString += "g";
WriteLine("something is " + someString);
WriteLine("\n");

// Example 3 - checking performance (only good for large strings)
int iterations = 100000;
var (resultFromStr, test) = StringTest(iterations);
var (resultFromSb, testSb) = StringBuilderTest(iterations);

WriteLine("String: " + resultFromStr);
WriteLine("StringBuilder: " + resultFromSb);

ReadKey();

// Example 2 - downloading data from the Web 
// string 
string finalResult = string.Empty;
using var webConnection = new WebConnection("weatherDatabaseUrl");
while (webConnection.CanRead("weatherData"))
{
    string weatherData = webConnection.Read("weatherData");
    string weatherForDay = weatherData.Substring(0, 100);
    foreach (var weatherForHour in weatherForDay.Split(";"))
    {
        finalResult += weatherForHour;
    }
}

// StringBuilder
StringBuilder sb = new StringBuilder();
using var webConnection2 = new WebConnection("weatherDatabaseUrl");
while (webConnection.CanRead("weatherData"))
{
    string weatherData = webConnection.Read("weatherData");
    string weatherForDay = weatherData.Substring(0, 100);
    foreach (var weatherForHour in weatherForDay.Split(";"))
    {
        finalResult += weatherForHour;
    }
}
var finalResult2 = sb.ToString();


// Example 3 - check performance
(long, string) StringTest(int iterations)
{
    Stopwatch stopwatch = Stopwatch.StartNew();
    string a = "";
    for (int i = 0; i < iterations; i++)
    {
        a += "a";
    }
    stopwatch.Stop();
    return (stopwatch.ElapsedTicks, a);
}

(long, string) StringBuilderTest(int iterations)
{
    Stopwatch stopwatch = Stopwatch.StartNew();
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < iterations; i++)
    {
        sb.Append("a");
    }
    stopwatch.Stop();
    return (stopwatch.ElapsedTicks, sb.ToString());
}