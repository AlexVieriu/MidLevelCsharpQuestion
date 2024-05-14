using static System.Console;

var array = new int[5];

var stringArray = new[] { "a", "b", "c" };

var matrix = new int[3, 5];
matrix[2, 3] = 10;

// JaggedArray: and array of arrays
var jaggedArray = new int[3][];
jaggedArray[0] = new int[2];
jaggedArray[1] = new int[1];
jaggedArray[2] = new int[3];

// Accessing methods matrix vs jaggedArray
matrix[1, 2] = 5;
jaggedArray[2][1] = 3;


ReadKey();