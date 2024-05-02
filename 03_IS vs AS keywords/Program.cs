using static System.Console;

// "Is" keyword
object text = "Hello!";
bool isString = text is string;
bool isInt = text is int;

// "As" keyword
string testAsString = text as string;           // object -> string 

int castToInt = text as int;                    // compile error, can't cast ref type to value type
int? castToInt2 = text as int?;

List<string> castToList = text as List<string>; // return null, can't cast string to List<string> 
var list2 = (List<string>)text;                 // regular casting -> throws and runtime error

object castToObject2 = text as object;          // string -> object 


ReadKey();