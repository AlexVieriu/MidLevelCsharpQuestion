using static System.Console;
WriteLine("- - - - - - - - Example 1 - - - - - - - - ");
MethodA();


WriteLine("- - - - - - - - Example 2 - - - - - - - - ");
try
{
    MethodThrow();
}
catch (Exception ex)
{
    WriteLine("Throw");
    WriteLine(ex.StackTrace);
    WriteLine();
}

try
{
    MethodThrowEx();
}
catch (Exception ex)
{
    WriteLine("Throw ex");
    WriteLine(ex.StackTrace);
    WriteLine();
}

ReadKey();



// Example 1
try
{
    // some code
}
catch (Exception ex)
{
    WriteLine(ex.Message);
    throw;
	throw ex;
}

// Example 2
static void MethodA()
{
    WriteLine("Method A");
    MethodB();
}

static void MethodB()
{
    WriteLine("Method B");
    MethodC();
}

static void MethodC()
{
    WriteLine("Method C");
    WriteLine(Environment.StackTrace);
    WriteLine();
}

// Example 3 
void MethodThrow()
{
    try
    {
        var collection = Enumerable.Empty<int>();
        var fist = collection.First();
    }
    catch (Exception ex)
    {
        throw;
    }
}

void MethodThrowEx()
{
    try
    {
        var collection = Enumerable.Empty<int>();
        var fist = collection.First();
    }
    catch (Exception ex)
    {
        throw ex;
    }
}