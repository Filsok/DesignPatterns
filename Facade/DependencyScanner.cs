namespace Facade
{
    public class DependencyScanner
    {
        public IEnumerable<string> DependencyScan(string githubUrl)
        {
            Console.WriteLine("Dependency scan");
            return new List<string>() { "Dependency scan error1" };
        }
    }
}