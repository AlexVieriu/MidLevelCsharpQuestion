using _42_2_Decorator_design_pattern;
using static System.Console;

ICoffee myCoffee = new SimpleCoffee_WithoutDecorator();
WriteLine($"{myCoffee.GetDescription()} Cost: {myCoffee.GetCost()}");

Coffee_WithDecorator milkDecorator = new Milk_WithDecorator(myCoffee);
WriteLine($"{milkDecorator.GetDescription()} Cost: {milkDecorator.GetCost()}");

Coffee_WithDecorator sugarDecorator = new Sugar_WithDecorator(milkDecorator);
WriteLine($"{sugarDecorator.GetDescription()} Cost: {sugarDecorator.GetCost()}");

// If we don't make the coffee protected we can reset the object and loose all we added
// Directly manipulate the _coffee field of SugarDecorator (abnormal behavior)
//sugarDecorator._coffee = new SimpleCoffee_WithoutDecorator(); // Replacing with a new SimpleCoffee
//WriteLine($"{sugarDecorator.GetDescription()} Cost: {sugarDecorator.GetCost()}");
