using Facade;

Console.WriteLine("Hello, World!");

var scanFacade = new ScanFacade();

scanFacade.Scan("https://hithub.com/somerepo");

Console.WriteLine();