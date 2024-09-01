namespace _42_2_Decorator_design_pattern;

public class Milk_WithDecorator : Coffee_WithDecorator
{
    public Milk_WithDecorator(ICoffee coffee) : base(coffee)
    {
            
    }

    public override double GetCost() => _coffee.GetCost() + 0.5;

    public override string GetDescription() => _coffee.GetDescription() + ", Milk";

}
