using static System.Console;

// Example 1
var anyObject1 = "abc";
WriteLine($"{anyObject1} has code is {anyObject1.GetHashCode()}");

var anyObject2 = 123;
WriteLine($"{anyObject2} has code is {anyObject2.GetHashCode()}");



// Example 3
WriteLine("\n - - - Example 3 - - - ");
var point1 = new Point1(10, 20);
var point2 = new Point1(10, 20);
var point3 = new Point1(20, 30);

// for reference types, Hash Code it's bases for the reference itself
// for value types, it's calculated based on the values stored in the obj
WriteLine($"{point1} hash code is {point1.GetHashCode()}");  
WriteLine($"{point2} hash code is {point2.GetHashCode()}");
WriteLine($"{point3} hash code is {point3.GetHashCode()}");

// Example 4 - change class to struct to have same Hash Code
WriteLine("\n - - - Example 4 - - - ");
var point4 = new Point2(10, 20);
var point5 = new Point2(10, 20);
var point6 = new Point2(20, 30);

WriteLine($"{point4} hash code is {point4.GetHashCode()}");
WriteLine($"{point5} hash code is {point5.GetHashCode()}");
WriteLine($"{point6} hash code is {point6.GetHashCode()}");

// Example 5 
WriteLine("\n - - - Example 5 - - - ");
var point7 = new Point3(10, 20);
var point8 = new Point3(10, 20);
var point9 = new Point3(20, 30);

WriteLine($"{point7} hash code is {point7.GetHashCode()}");
WriteLine($"{point8} hash code is {point8.GetHashCode()}");
WriteLine($"{point9} hash code is {point9.GetHashCode()}");

ReadKey();

// Example 2 - implementation of HashCode for int (no duplication for int values)
//public override int GetHashCode()
//{
//    return m_value;
//}


// Example 3 
class Point1
{
    public int X { get; }
    public int Y { get; }
    public Point1(int x, int y)
    {
        X = x;
        Y = y;
    }
}

// Example 4
struct Point2
{
    public int X { get; }
    public int Y { get; }
    public Point2(int x, int y)
    {
        X = x;
        Y = y;
    }
}

// Example 5 - Custom implementation
class Point3
{
    public int X { get; }
    public int Y { get; }
    public Point3(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
}