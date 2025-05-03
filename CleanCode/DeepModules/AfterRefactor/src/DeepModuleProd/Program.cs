using DeepModuleProd.Domain;

var reportGenerator = new ReportGenerator();
AddReportLines(reportGenerator);
PrintReport(reportGenerator);

void AddReportLines(ReportGenerator reportGenerator)
{
    reportGenerator.AddReportLine("line1");
    reportGenerator.AddReportLine("line2");
    reportGenerator.AddReportLine("line3");
}

void PrintReport(ReportGenerator reportGenerator)
{
    foreach (var line in reportGenerator.GetFormatedReport())
        Console.WriteLine(line);
}
