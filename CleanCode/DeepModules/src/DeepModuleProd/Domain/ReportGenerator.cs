namespace DeepModuleProd.Domain;

public class ReportGenerator
{
    private List<string> _textLines = new List<string>();
    
    public void AddTextLine(string textLine)
    {
        if (string.IsNullOrEmpty(textLine))
            throw new ArgumentException("Text line cannot be empty");
        _textLines.Add(textLine);
    }
    
    public List<string> GetReportLines()
    {
        List<string> formattedReport = new List<string>();
        formattedReport.Add(GenerateSummary());
        formattedReport.Add(FromatReport());
        formattedReport.Add(GenerateFooter());
        return formattedReport;
    }
    
    public string FromatReport()
    {
        return string.Join(",\n", _textLines.Select(x => x.ToUpper()));
    }

    public string GenerateSummary()
    {
        return "Report generated at: " + new DateTime(2025, 05, 03);
    }
    public string GenerateFooter()
    {
        return "--- End of report ---:\n" + "Report Lines count = " + _textLines.Count;
    }
}