/* 
1.Create a function that adds two numbers and returns the result.
2.Create a function that checks if a number is even.
3.Create a function that squares a number.
4.Create a function that prints a message to the console.
5.Create a function that calculates the sum of all numbers in a list.
6.Create a function that counts the number of characters in a string.
7.Create a function that converts Celsius to Fahrenheit.
8.Create a function that returns the maximum number from a list.
9.Create a function that checks if a string is a palindrome.
10.Create a function that calculates the factorial of a number.
*/
using static System.Console;

// Example 1:
Func<int, int, int> addFunc = (x, y) => x + y;

var result = addFunc(1, 2);
WriteLine($"x+y={result} \n");

// Example 2:
Func<int, bool> isEven = x =>
{
    return x % 2 == 0;
};

// Example 3 
Func<int, double> square = x => Math.Sqrt(x);
WriteLine($"Sqrt(x) = {square}");

// Example 4
Action<string> console = WriteLine;
WriteLine("Hello World!");

// Example 5
Func<List<int>, int> sumList = list => list.Sum();
var numbers = new List<int>() { 1, 2, 3, 4, 5 };
WriteLine($"SumList = {sumList(numbers)}");

// Example 6
Func<string, int> countString = str => str.Length;
WriteLine($"Number of char = {countString("Hello World!")}");

// Example 7
Func<double, double> celsiusToFahrenheitFunc = c => (c * 9 / 5) + 32;
var celsius = 30;
WriteLine($"{celsius}C = {celsiusToFahrenheitFunc(celsius)}F");

// Example 8 
Func<List<int>, int> maxNr = list => list.Max();
var newList = new List<int>() { 1, 2, 3, 4, 5 };
WriteLine($"Max number from the list= {maxNr(newList)}");

// Example 9
Func<string, bool> isPalindromeFunc = str => str.SequenceEqual(str.Reverse());
WriteLine(isPalindromeFunc("radar"));

// Example 10 
Func<int, long> factorialFunc = null;
factorialFunc = n => n == 0 ? 1 : n * factorialFunc(n - 1);

WriteLine(factorialFunc(5));
