namespace Decorator
{
  public class PepperoniDecorator : PizzaToppingDecorator
  {
    public PepperoniDecorator(IProduct product) : base(product)
    {
    }

    public override string GetDescription()
    {
      return Product.GetDescription() + ", Pepperoni";
    }

    public override double GetPrice()
    {
      return Product.GetPrice() + .5;
    }
  }
}
