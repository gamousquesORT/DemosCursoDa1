using ShallowModuleProd.Interfaces;
namespace ShallowModuleProd.Domain;

public class ReportGenerator
{
    private IDate _date;
    public ReportGenerator(IDate date)
    {
        _date = date;
    }
    public List<string> GetReportLines(List<string> text)
    {
        List<string> formattedReport = new List<string>();
        formattedReport.Add(GenerateSummaryAddingTimeStamp(text));
        formattedReport.Add(FromatReportTuUpperCase(text));
        formattedReport.Add(GenerateFooterWithNumberOfLines(text));
        return formattedReport;
    }
    
    public string FromatReportTuUpperCase(List<string> text)
    {
        return string.Join(",\n", text.Select(x => x.ToUpper()));
    }

    private string GenerateSummaryAddingTimeStamp(List<string> text)
    {
        return "Report generated at: " + _date.Now();
    }
    private string GenerateFooterWithNumberOfLines(List<string> text)
    {
        return "--- End of report ---:\n" + "Report Lines count = " + text.Count;
    }
}