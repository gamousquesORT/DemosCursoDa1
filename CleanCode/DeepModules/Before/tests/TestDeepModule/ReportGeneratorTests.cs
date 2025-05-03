using ShallowModuleProd.Domain;
using ShallowModuleProd.Interfaces;

namespace TestDeepModule;

[TestClass]
public class ReportGeneratorTests
{
    private IDate date;
    private ReportGenerator rep;
    
    [TestInitialize]
    public void ReportGeneratorInitialize()
    {
        date = new StubDateTime(2025, 05, 03);
        rep = new ReportGenerator(date);
    }
    
    [TestMethod]
    public void ShouldAddTextLine_GivenAValidTextLiene()
    {
        List<string> text = new List<string>();
        text.Add("this is a valid line");
        int expected = 3;
        Assert.AreEqual(expected, rep.GetReportLines(text).Count);
    }

    [TestMethod]
    public void ShouldRetrunTwoTextLines_GivenTwoValidTextLiene()
    {
        List<string> text = new List<string>();
        text.Add("this is a valid line");
        text.Add("this is another valid line");
        var expected = 3;
        
        var result = rep.GetReportLines(text);
        Assert.AreEqual(expected, result.Count);
    }

    [TestMethod]
    public void ShouldReturnWellFormatedReport_GivenOneLine()
    {
        List<string> text = new List<string>();
        text.Add("line1");
        List<string> expected = new List<string>()
        {
            "Report generated at: " + date.Now(),
            "LINE1",
            "--- End of report ---:\n" + "Report Lines count = 1"
        };
        
        CollectionAssert.AreEqual(expected, rep.GetReportLines(text));
    }


}