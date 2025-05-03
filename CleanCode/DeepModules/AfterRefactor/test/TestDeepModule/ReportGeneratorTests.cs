using DeepModuleProd.Domain;
using DeepModuleProd.Interfaces;

namespace TestDeepModule;

[TestClass]
public class ReportGeneratorTests
{
    private ReportGenerator rep;
    private IDate date;
    
    [TestInitialize]
    public void Setup()
    {
        date = new StubDateTime(2025, 05, 03);
        rep = new ReportGenerator(date);
    }
    
    [TestMethod]
    public void ShouldAddTextLine_GivenAValidTextLiene()
    {
        rep.AddReportLine("this is a valid line");
        int expected = 1;
        Assert.AreEqual(expected, rep.Count);
    }
    [TestMethod]
    public void ShouldReturnArgumentException_GivenAnEmptyTextLine()
    {
        Assert.ThrowsException<ArgumentException>(() => rep.AddReportLine(""));
    }
    [TestMethod]
    public void ShouldRetrunTwoTextLines_GivenTwoValidTextLiene()
    {
        rep.AddReportLine("this is a valid line");
        rep.AddReportLine("this is another valid line");
        var expected = 2;
        Assert.AreEqual(expected, rep.Count);
    }
    

    [TestMethod]
    public void ShouldReturnWellFormatedReport_GivenOneLine()
    {
        rep.AddReportLine("line1");
        List<string> expected = new List<string>()
        {
            "Report generated at: " + new StubDateTime(2025, 05, 03).Now(),
            "LINE1",
            "--- End of report ---:\n" + "Report Lines count = 1"
        };
        
        CollectionAssert.AreEqual(expected, rep.GetFormatedReport().ToList());
    }

}