using ShallowModuleProd.Domain;

var reportGenerator = new ReportGenerator();
AddReportLines(reportGenerator);

PrintReportLines(reportGenerator);

void AddReportLines(ReportGenerator reportGenerator1)
{
    reportGenerator1.AddTextLine("line1");
    reportGenerator1.AddTextLine("line2");
    reportGenerator1.AddTextLine("line3");
}

void PrintReportLines(ReportGenerator reportGenerator2)
{
    foreach (var line in reportGenerator2.GetReportLines())
        Console.WriteLine(line);
}
    