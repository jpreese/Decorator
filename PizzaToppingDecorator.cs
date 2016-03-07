namespace Decorator
{
  public abstract class PizzaToppingDecorator : IProduct
  {
    protected readonly IProduct Product;

    protected PizzaToppingDecorator(IProduct product)
    {
      Product = product;
    }

    public virtual string GetDescription()
    {
      return Product.GetDescription();
    }

    public virtual double GetPrice()
    {
      return Product.GetPrice();
    }
  }
}
