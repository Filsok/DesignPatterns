namespace Decorator
{
    public class MediumPizza : IPizza
    {
        public double CalculatePrice()
        {
            return 20;
        }
    }
}