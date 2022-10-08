namespace Facade
{
    public class QualityScanner
    {
        public IEnumerable<string> QualityScan(string githubUrl)
        {
            Console.WriteLine("Quality scan");
            return new List<string>() { "Error1", "Error2" };
        }
    }
}