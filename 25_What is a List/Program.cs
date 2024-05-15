using static System.Console;

// Example 1
var list = new List<int> { 1, 2, 3 };
list.Add(4);        // add 4 to the List
list[0] = 5;        // make the first element on the list = 5
var lastElement = list[list.Count - 1];

list.RemoveAt(0);   // remove the element at the specific index
list.Clear();       // remove all elements from the List
list.AddRange([2, 3, 4, 5]); // adds the elements of the specified collection at the end of the List
list.Average();     // computes the average of a sequence of int values
bool contain1 = list.Contains(1); // check if the List has the specified value

var result = list.Prepend(10);    // adds a value to the begging of the sequence
var string1 = string.Join(", ", list);
var string2 = string.Join(", ", result);

WriteLine("list.Prepend(10): " + string1);
WriteLine("var result = list.Prepend(10): " + string2);


list.Sort();        // sort the element in the List using the default comparer
WriteLine();


// Example 2 - go in deep: Capacity
WriteLine("- - - Example 2 - - -");

var list2 = new List<int>();
WriteLine("Capacity: " + list2.Capacity);                           // 0

list2.Add(1);
WriteLine("Capacity after adding one element: " + list2.Capacity);  // 4

list2.AddRange([6, 7, 8, 9]);
WriteLine("Capacity of 5 elements: " + list2.Capacity);             // 8

list2.Clear();
WriteLine("Capacity after cleaning: " + list2.Capacity);            // 8


// Example 3 - tell the size of a list upfront
var listOfCapacity1050 = new List<int>(1050);
WriteLine($"Capacity set to {listOfCapacity1050.Capacity}");        // 1050

// resizing is costly
listOfCapacity1050.AddRange(Enumerable.Range(0, 2000));
WriteLine($"Capacity is now {listOfCapacity1050.Capacity}");        // 2100

listOfCapacity1050.Clear();
listOfCapacity1050.AddRange([10, 11]);
listOfCapacity1050.TrimExcess();
WriteLine($"Trimmed Capacity is now {listOfCapacity1050.Capacity}"); // 2

//listOfCapacity1050.Capacity = 1; // throw an exception

// Example 4
WriteLine();
WriteLine("- - - Example 4 - - -");
var someList = new List<int>() { 1, 2, 3, 5, 6 };
var result2 = string.Join(" ,", someList);

someList.Insert(3, 4);
var result3 = string.Join(" ,", someList);

WriteLine("List without .Insert: " + result2);
WriteLine("List with .Insert: " + result3);





