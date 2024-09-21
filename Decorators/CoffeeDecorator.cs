public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee _coffee;
    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual double Cost()
    {
        return _coffee.Cost();
    }

    public virtual string GetDescription()
    {
        return _coffee.GetDescription();
    }
}