public class CreamDecorator : CoffeeDecorator
{
    public CreamDecorator(ICoffee coffee) : base(coffee) {}

    public override double Cost()
    {
        return _coffee.Cost() + 2.00;
    }

    
    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Cream";
    }
}