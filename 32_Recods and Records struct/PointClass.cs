// Example 1
public class PointClass : IEquatable<PointRecord>
{
    public int X { get; }
    public int Y { get; }
    public PointClass(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString() => $"X: {X}, Y: {Y}";
    public override int GetHashCode() => HashCode.Combine(X, Y);
    public override bool Equals(object? obj)
    {
        return obj is PointRecord pointClass && Equals((PointRecord)obj);
    }

    public bool Equals(PointRecord? other)
    {
        return other is not null && other.X == X && other.Y == Y;
    }
}