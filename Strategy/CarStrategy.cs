namespace Strategy
{
    public class CarStrategy : IRouteStrategy
    {
        public void CreateRoute(Coordinate start, Coordinate end)
        {
            Console.WriteLine("Car strategy");
        }
    }
}