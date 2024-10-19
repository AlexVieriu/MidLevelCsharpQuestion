#if(DEBUG && NET9_0_OR_GREATER)
Console.WriteLine("We are in debug mode and target .NET9 or greater");

#elif(DEBUG && !NET9_0)
Console.WriteLine("We are in debug mode and target older version then .NET9");

#else
Console.WriteLine("Some different setup");

#endif


#region SomeRegion
Console.WriteLine("oh No");
Console.WriteLine("oh No");
Console.WriteLine("oh No");
#endregion


#warning this method is depricated, use new method
OldMethod();

static void OldMethod()
    => Console.WriteLine("Old method");


Console.ReadKey();
