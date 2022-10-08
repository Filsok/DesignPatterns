namespace Strategy
{
    public class BikeStrategy : IRouteStrategy
    {
        public void CreateRoute(Coordinate start, Coordinate end)
        {
            Console.WriteLine("Bike strategy");
        }
    }
}