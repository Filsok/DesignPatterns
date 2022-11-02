namespace Decorator
{
    public class CheesePizzaDecorator : PizzaDecorator
    {
        public CheesePizzaDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override double CalculatePrice()
        {
            return base.CalculatePrice() + 4.5;
        }
    }
}