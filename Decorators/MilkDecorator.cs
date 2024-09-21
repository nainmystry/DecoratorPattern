public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee)
    {    }

    public override double Cost()
    {
        return _coffee.Cost() + 5.00;
    }

    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Milk";
    }
}