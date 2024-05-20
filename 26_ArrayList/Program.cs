using System.Collections;
using static System.Console;

// Example 1
var arrayList = new ArrayList()
{
    1, "hello", true, new DateTime(2022, 1, 1)
};

// if the item we want to store is an ArrayList of a value type, then it need to be boxed to be a object type
// boxing/unboxing impacts the performance 
// boxing: moving the value from the STACK to the HEAP and creating a reference to it
var first = arrayList[0]; // object type

// Example 2 - this is how ArrayList was used
var numbers = new ArrayList() { 1, 2, 3 };
var words = new ArrayList() { "a", "b", "c" };

// Example 3 
int Sum1(ArrayList arrayList)
{
    int sum = 0;
    foreach (var item in arrayList)
    {
        sum += item; // we don't know what type of obj is here
    }
    return sum;
}

int Sum2(ArrayList arrayList)
{
    int sum = 0;
    foreach (var item in arrayList)
    {
        try
        {
            sum += (int)item;
        }
        catch (InvalidCastException)
        {
            WriteLine($"{item} is not int");
        }
    }
    return sum;
}

ReadKey();