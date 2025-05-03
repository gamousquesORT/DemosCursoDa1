using DeepModuleProd.Interfaces;

namespace DeepModuleProd.Domain;

public class ReportGenerator
{
    private ICollection<string> _textLines = new List<string>();
    private IDate _date;

    public ReportGenerator(IDate date)
    {
        _date = date;
    }
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
    
    public int Count
    {
        get { return _textLines.Count; }
    }

    private string FromatReport()
    {
        return string.Join(",\n", _textLines.Select(x => x.ToUpper()));
    }

    private string GenerateSummary()
    {
        return "Report generated at: " + _date.Now();
    }
    private string GenerateFooter()
    {
        return "--- End of report ---:\n" + "Report Lines count = " + _textLines.Count;
    }
}