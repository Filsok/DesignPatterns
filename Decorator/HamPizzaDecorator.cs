namespace Decorator
{
    public class HamPizzaDecorator : PizzaDecorator
    {
        public HamPizzaDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override double CalculatePrice()
        {
            return base.CalculatePrice() + 5;
        }
    }
}