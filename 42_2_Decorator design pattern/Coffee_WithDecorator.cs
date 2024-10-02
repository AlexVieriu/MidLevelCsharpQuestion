namespace _42_2_Decorator_design_pattern;

public class Coffee_WithDecorator : ICoffee
{
    // We declare it protected so we can't access it from outside. See the last code in the Program.cs for example
    protected ICoffee _coffee; 
    public Coffee_WithDecorator(ICoffee coffee) => _coffee = coffee;
    public virtual string GetDescription() => _coffee.GetDescription();
    public virtual double GetCost() => _coffee.GetCost();
}
