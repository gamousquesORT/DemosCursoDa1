namespace ShallowModuleProd.Domain;

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
        formattedReport.Add(GenerateSummaryAddingTimeStamp());
        formattedReport.Add(FromatReportTuUpperCase());
        formattedReport.Add(GenerateFooterWithNumberOfLines());
        return formattedReport;
    }
    
    private string FromatReportTuUpperCase()
    {
        return string.Join(",\n", _textLines.Select(x => x.ToUpper()));
    }

    private string GenerateSummaryAddingTimeStamp()
    {
        return "Report generated at: " + new DateTime(2025, 05, 03);
    }
    private string GenerateFooterWithNumberOfLines()
    {
        return "--- End of report ---:\n" + "Report Lines count = " + _textLines.Count;
    }
}