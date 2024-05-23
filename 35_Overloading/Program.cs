var point1 = new Point(10, 5);
var point2 = new Point(-3, 4);

// bad way
var result = point1.Add(point2);

// good way
var result2 = point1 + point2;
int a = 5;
++a;

var text = a > 1000 ? "large number" : "small number";

// Example 2
// implicit conversion
int a1 = 5;
double b1 = a;

// explicit conversion  -  we acknowledge the risk that we lose the precision 
double c = 5.5d;
int d = (int)c;

// our own implicit conversion operator
Point fromTyple = (5f, 6f);

// our own explicit conversion operator (comment the method of implicit in the code)
Point fromTyple2 = (Point)(5f, 6f);

Console.ReadKey();

record struct Point
{
    public float X { get; }
    public float Y { get; }
    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }

    // Bad way
    public Point Add(Point other) => new Point(X + other.X, Y + other.Y);
    public static Point operator +(Point point1, Point point2) =>
        new Point(point1.X + point2.X, point1.Y + point2.Y);

    // Implicit
    public static implicit operator Point((float, float) pointAsTuple) =>
        new Point(pointAsTuple.Item1, pointAsTuple.Item2);

    // Explicit
    public static explicit operator Point((float, float) pointAsTuple) =>
    new Point(pointAsTuple.Item1, pointAsTuple.Item2);
}