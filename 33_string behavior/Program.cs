using static System.Console;

// Example 1
// value type behavior - they are passed by value
WriteLine("- - - value type behavior - - -");
var valueType = 5;
WriteLine(valueType);
AddOneValueType(valueType);
WriteLine(valueType);

// reference type behavior - they are passed by reference
WriteLine("\n - - - reference type behavior - - -");
var referenceType = new List<int> { 5 };
WriteLine(referenceType.Count);
AddOneToReferenceType(referenceType);
WriteLine(referenceType.Count);

// string behavior
WriteLine("\n - - - string behavior - - -");
var text = "Hello!";
WriteLine(text);
AddOneToString(text);
WriteLine(text);


// Example 2
var text2 = "text";
text2 += "1";        // this is not modify the original string, it create a new char[] with +1 added to it 

ReadKey();


void AddOneValueType(int valueType) => ++valueType;
void AddOneToReferenceType(List<int> referenceType) => referenceType.Add(6);
void AddOneToString(string text) => text += "1";