namespace Decorator
{
  public class PineappleDecorator : PizzaToppingDecorator
  {
    public PineappleDecorator(IProduct product) : base(product)
    {
    }

    public override string GetDescription()
    {
      return Product.GetDescription() + ", Pineapple";
    }

    public override double GetPrice()
    {
      return Product.GetPrice() + 3.00;
    }
  }
}
