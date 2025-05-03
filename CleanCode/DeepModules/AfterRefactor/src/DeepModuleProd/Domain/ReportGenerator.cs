namespace DeepModuleProd.Domain;

public class ReportGenerator
{
    private ICollection<string> _textLines = new List<string>();
    
    public void AddReportLine(string textLine)
    {
        if (string.IsNullOrEmpty(textLine))
            throw new ArgumentException("Text line cannot be empty");
        _textLines.Add(textLine);
    }
    
    public IEnumerable<string> GetFormatedReport()
    {
        List<string> lines = new List<string>();
        lines.Add(GenerateSummary());
        lines.Add(FromatReport());
        lines.Add(GenerateFooter());
        return lines;
    }
    
    public int Count => _textLines.Count;
    
    private string FromatReport()
    {
        return string.Join(",\n", _textLines.Select(x => x.ToUpper()));
    }

    private string GenerateSummary()
    {
        return "Report generated at: " + new DateTime(2025, 05, 03);
    }
    private string GenerateFooter()
    {
        return "--- End of report ---:\n" + "Report Lines count = " + _textLines.Count;
    }
}