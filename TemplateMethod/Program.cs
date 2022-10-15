using TemplateMethod;

var pdfGenerator = new PdfGenerator();
Console.WriteLine("** PDF **");
pdfGenerator.GenerateReport();

Console.WriteLine("** CSV **");
var csv = new CsvGenerator();
csv.GenerateReport();