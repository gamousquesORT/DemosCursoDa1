using ShallowModuleProd.Domain;

var reportGenerator = new ReportGenerator(new DateTimeProd());
var text = new List<string>();
AddReportLines(text);

PrintReportLines(reportGenerator, text);

void AddReportLines(List<string> text)
{
    text.Add("line1");
    text.Add("line2");
    text.Add("line3");
}

void PrintReportLines(ReportGenerator reportGenerator, List<string> text)
{
    foreach (var line in reportGenerator.GetReportLines(text))
        Console.WriteLine(line);
}
    