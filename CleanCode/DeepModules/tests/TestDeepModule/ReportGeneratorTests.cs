using DeepModuleProd.Domain;
namespace TestDeepModule;

[TestClass]
public class ReportGeneratorTests
{
    [TestMethod]
    public void ShouldAddTextLine_GivenAValidTextLiene()
    {
        var rep = new ReportGenerator();
        rep.AddTextLine("this is a valid line");
        int expected = 3;
        Assert.AreEqual(expected, rep.GetReportLines().Count);
    }
    [TestMethod]
    public void ShouldReturnArgumentException_GivenAnEmptyTextLine()
    {
        var rep = new ReportGenerator();
        Assert.ThrowsException<ArgumentException>(() => rep.AddTextLine(""));
    }
    [TestMethod]
    public void ShouldRetrunTwoTextLines_GivenTwoValidTextLiene()
    {
        var rep = new ReportGenerator();
        rep.AddTextLine("this is a valid line");
        rep.AddTextLine("this is another valid line");
        var expected = 4;
        
        var result = rep.GetReportLines();
        Assert.AreEqual(expected, result.Count);
    }
    
    [TestMethod]
    public void ShouldReturnAnUpperCaseSummary_GivenOneLine()
    {
        ReportGenerator rep = new ReportGenerator();
        rep.AddTextLine("this is a valid line");
        
        var result = rep.FromatReport();

        Assert.AreEqual("THIS IS A VALID LINE", result);
    }

    [TestMethod]
    public void ShouldReturnAnUpperCaseCommaSeparetadSummary_GivenTwoLines()
    {
        ReportGenerator rep = new ReportGenerator();
        rep.AddTextLine("this is a valid line");
        rep.AddTextLine("this is another valid line");
       
        var result = rep.FromatReport();

        Assert.AreEqual("THIS IS A VALID LINE" + "," + "THIS IS ANOTHER VALID LINE", result);
    }
    
    [TestMethod]
    public void ShouldReturnACorrectFooter_GivenTwoLines()
    {

        ReportGenerator rep = new ReportGenerator();
        rep.AddTextLine("line1");
        rep.AddTextLine("line2");
        var footer = rep.GenerateFooter();
        var expected = "--- End of report ---:\n" + "Report Lines count = 2";
        Assert.AreEqual(expected, footer);
    }

    [TestMethod]
    public void ShouldReturnTimedStampedSummary_GivenNoLines()
    {
        ReportGenerator rep = new ReportGenerator();
        rep.AddTextLine("line1");
        var result = rep.GenerateSummary();
        var expected = "Report generated at: " + new DateTime(2025,05,03);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ShouldReturnWellFormatedReport_GivenOneLine()
    {
        ReportGenerator rep = new ReportGenerator();
        rep.AddTextLine("line1");
        List<string> expected = new List<string>()
        {
            "Report generated at: " + new DateTime(2025, 05, 03),
            "LINE1",
            "--- End of report ---:\n" + "Report Lines count = 1"
        };
        
        CollectionAssert.AreEqual(expected, rep.GetReportLines());
    }

}