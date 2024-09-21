public class BasicCoffee : ICoffee
{
    public double Cost()
    {
        return 2.00;
    }

    public string GetDescription()
    {
        return "Basic Coffee.";
    }
}