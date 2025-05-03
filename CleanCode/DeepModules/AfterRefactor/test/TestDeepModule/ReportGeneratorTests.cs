using DeepModuleProd.Domain;

namespace TestDeepModule;

[TestClass]
public class ReportGeneratorTests
{
    [TestMethod]
    public void ShouldAddTextLine_GivenAValidTextLiene()
    {
        var rep = new ReportGenerator();
        rep.AddReportLine("this is a valid line");
        int expected = 1;
        Assert.AreEqual(expected, rep.Count);
    }
    [TestMethod]
    public void ShouldReturnArgumentException_GivenAnEmptyTextLine()
    {
        var rep = new ReportGenerator();
        Assert.ThrowsException<ArgumentException>(() => rep.AddReportLine(""));
    }
    [TestMethod]
    public void ShouldRetrunTwoTextLines_GivenTwoValidTextLiene()
    {
        var rep = new ReportGenerator();
        rep.AddReportLine("this is a valid line");
        rep.AddReportLine("this is another valid line");
        var expected = 2;
        Assert.AreEqual(expected, rep.Count);
    }
    

    [TestMethod]
    public void ShouldReturnWellFormatedReport_GivenOneLine()
    {
        ReportGenerator rep = new ReportGenerator();
        rep.AddReportLine("line1");
        List<string> expected = new List<string>()
        {
            "Report generated at: " + new DateTime(2025, 05, 03),
            "LINE1",
            "--- End of report ---:\n" + "Report Lines count = 1"
        };
        
        CollectionAssert.AreEqual(expected, rep.GetFormatedReport().ToList());
    }

}