using System;

namespace Decorator
{
  class Program
  {
    static void Main(string[] args)
    {
      IProduct pizza = new Pizza();
      pizza = new PepperoniDecorator(pizza);
      pizza = new PineappleDecorator(pizza);

      Console.WriteLine(pizza.GetDescription());
      Console.WriteLine(pizza.GetPrice());

      Console.ReadKey();
    }
  }
}
