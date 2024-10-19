// code that is not optimal
// 1. Build the project in Debug mode
// 2. Build the project in Release mode

int someUnusedVariables = 5;
const string Hello = "Hello!";
Console.WriteLine(Hello + Hello);

#if DEBUG
Console.WriteLine("We are in debug mode!");
#endif

#if RELEASE
Console.WriteLine("We are in release mode!");
#endif

Console.ReadKey();


/* 
1. Debug mode
Build the Project
Check the debug dll: 
    [Project Folder]\bin\Debug\net9.0
Open the Developer PowerShell(Ctrl+~) -> type: ildasm.exe
Drag the dll into the ildasm window
Save the file
Open the .il folder with NotePad to see the IL(Intermediate Language Code)
Go to the https://sharplab.io/ -> change the Code to IL(top left)
Paste your IL code to https://sharplab.io/ 


2. Release Mode
-> same as debug but change the path:
    [Project Folder]\bin\Release\net9.0
*/
