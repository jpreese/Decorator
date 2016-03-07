namespace Decorator
{
  public class Pizza : IProduct
  {
    public string GetDescription()
    {
      return "Pizza";
    }

    public double GetPrice()
    {
      return 9.99;
    }
  }
}
