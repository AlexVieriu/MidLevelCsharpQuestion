using static System.Console;

// Tuples
var tuple1 = new Tuple<int, string>(1, "aaa");
var tuple2 = Tuple.Create(1, "bbb");
var number = tuple1.Item1;
var number2 = tuple2.Item2;
var largeTuple = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);
var largerTuple2 = Tuple.Create(1, 2, 3, 4, 6, 7, Tuple.Create(8, 9, 10));

// ValueTuples
var valueTuple = new ValueTuple<int, string>(1, "ccc");
var valueTupleShort = (1, "ccc");

// Comparation
// Tuple-> Reference types
var tuple3 = Tuple.Create("aaa");
var tuple4 = Tuple.Create("aaa");
WriteLine("tuple3==tuple4: " + (tuple3 == tuple4));             // compares the reference because Tuple is reference type
WriteLine("tuple3.Equals(tuple4): " + (tuple3.Equals(tuple4))); // compares the content
WriteLine();

// ValueTuple -> value types
var valueTuple1 = (2, "bbb");
var valueTuple2 = (2, "bbb");
WriteLine("valueTuple1==valueTuple2: " + (valueTuple1== valueTuple2));              // compares the reference, they have the same reference because are value type
WriteLine("valueTuple1.Equals(valueTuple2): " + (valueTuple1.Equals(valueTuple2))); // compares the content

// Immutable
// tuple3.Item1 = 1;       // go to definition of Tuple -> Item1 is declared as readonly
valueTuple1.Item1 = 2;

// You can name the Items of a tuple instead of Item1, Item2, Item3 
var valueTuple3 = (number: 1, Text: "hello!");
var number3 = valueTuple3.number;
var text3 = valueTuple3.Text;

// ValueTuples can have more then 8 elements(Tuple has max 8)
var hugeValueTaple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
var tenth = hugeValueTaple.Item10;

ReadKey();