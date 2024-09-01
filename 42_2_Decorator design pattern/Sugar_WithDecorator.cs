namespace _42_2_Decorator_design_pattern;

public class Sugar_WithDecorator : Coffee_WithDecorator
{
    public Sugar_WithDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override double GetCost() => base.GetCost() + 0.2;

    public override string GetDescription() => base.GetDescription() + ", Sugar";
}
