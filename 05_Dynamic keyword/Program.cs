using _05_Dynamic_keyword;

dynamic text = "dynamic text";

text.DoesntExist();                   // we can run it, but will crash at runtime

var toUpper = text.ToUpper();           // will work

string convertToString = (string)text;  // will work

int integer = (int)text;              // crash at runtime

Console.WriteLine($"{convertToString}");


// Example 1:
// constructor has a dynamic type, but the result is not a dynamic type
dynamic text2 = "dynamic text";
var someClass = new DynamicConstructor(text2);
Console.WriteLine(someClass.Text);

// Example 2:
var result1 = "2" + 8;

dynamic x = "2";
dynamic y = 8;
var result2 = x + y;

var result3 = int.Parse("2") + 8;

Console.WriteLine($"Result: {result1}"); // output 28
Console.WriteLine($"Result: {result2}"); // output 28
Console.WriteLine($"Result: {result3}"); // output 10