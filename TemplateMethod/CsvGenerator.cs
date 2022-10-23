namespace TemplateMethod
{
    public class CsvGenerator : Generator
    {
        protected override void GenerateFile()
        {
            Console.WriteLine("Generate csv file.");
        }

        protected override void PrepareData()
        {
            Console.WriteLine("Prepare data for csv.");
        }
    }
}