namespace Decorator
{
    public class LargePizza : IPizza
    {
        public double CalculatePrice()
        {
            return 30;
        }
    }
}