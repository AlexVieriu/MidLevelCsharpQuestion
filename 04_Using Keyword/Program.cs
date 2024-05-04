// 1. Using Directive

// Example 1 
// with global using u don't need to put using at the beginning of each .cs page, make a GlobalUsing.cs file and put all using statements there
global using System.IO;
global using System.Linq;

// Example 2
using System.Diagnostics; 

// Example 3
using DTO;
using BaseClass;

// Example 4
using PersonDto = DTO.Person;
using PersonBase = BaseClass.Person;

// Example 5
using static System.Console;



// Example 2
var sw = Stopwatch.StartNew();

// Example 3
var person = new Person(); // the compile can't which Person can is it

// Example 4
var person1 = new PersonDto();
var person2 = new PersonBase();

// Example 5
WriteLine();


// 2. Using statement (Example 1 = Example 2)

// Example 1
var fileStream1 = File.Open("path", FileMode.Create);
try
{
	// some operation
}
finally
{
	fileStream1.Dispose();
}

// Example 2
using var fileStream2 = File.Open("path", FileMode.Create);
// some operations