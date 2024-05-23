// Example 1
var pointClass = new PointRecord(10, 20);
Console.WriteLine($"Point class -> {pointClass}");

// Example 2
var pointRecord = new PointRecord(1, 2);
var pointWithYUpdated = pointRecord with { Y = 10 }; // "with" creating a clone of a obj with the new input values

Console.ReadKey();

// Example 3
public readonly record struct RecordStructPointImmutable(int X, int Y);
public record struct RecordStructPointMutable(int X, int Y);

