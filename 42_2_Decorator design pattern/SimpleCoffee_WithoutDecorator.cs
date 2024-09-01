namespace _42_2_Decorator_design_pattern;

public class SimpleCoffee_WithoutDecorator : ICoffee
{
    public double GetCost() => 2.0;

    public string GetDescription() => "Simple Coffee";
}
