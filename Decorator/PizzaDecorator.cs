namespace Decorator
{
    public abstract class PizzaDecorator : IPizza
    {
        private IPizza _pizza;

        protected PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual double CalculatePrice()
        {
            return _pizza.CalculatePrice();
        }
    }
}