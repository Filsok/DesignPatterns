using Singleton;

var cfg = Configuration.GetInstance();
var cfg2= Configuration.GetInstance();

var equals = ReferenceEquals(cfg,cfg2);

Console.WriteLine($"configurations are equals: {equals}");