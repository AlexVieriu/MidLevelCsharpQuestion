using static System.Console;

// Example 1 - BoardGame
var catan = new SettlersOfCatan();
var terra = new TerraFormingMars();

//catan.Play();
WriteLine();
//terra.Play();

// Example 2 - Unit Tests
var calculatorTests = new TestCalculator();
WriteLine("- - - Example2 - - -");
WriteLine(calculatorTests.Run() ? "Success!" : "Failed");

ReadKey();
