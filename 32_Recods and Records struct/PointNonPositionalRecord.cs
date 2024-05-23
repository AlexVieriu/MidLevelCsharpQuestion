public record PointNonPositionalRecord
{
    public int X { get; set; } // can be red-write
    public int Y { get; set; }

    public PointNonPositionalRecord(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int Sum() => X + Y; // can add method to Record
}

