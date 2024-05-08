// Example 1
ProcessString processString1 = TrimTo5Letters;
ProcessString processString2 = ToUpper;

Console.WriteLine(processString1(""));

string TrimTo5Letters(string input) => input.Substring(0, 5);
string ToUpper(string input) => input.ToUpper();

// Example 2-> multi cast delegate
Print print1 = text => Console.WriteLine(text.ToUpper());
Print print2 = text => Console.WriteLine(text.ToLower());
Print multicast = print1 + print2;
Print print3 = text => Console.WriteLine(text.Substring(0, 3));
multicast += print3;

multicast("Asa ceva nu se face");

// Example 1 -> declare the delegate last, otherwise will not work
delegate string ProcessString(string input);

// Example 2 -> multi cast delegate
delegate void Print(string input);