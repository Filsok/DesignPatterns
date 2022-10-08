using Strategy;

Console.WriteLine("Hello, World!");

var strategy = new BikeStrategy();

var map = new Map(strategy);

var start = new Coordinate();
var end = new Coordinate();

map.CreateRoute(start, end);

Console.WriteLine();