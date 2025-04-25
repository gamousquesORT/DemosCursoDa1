using VideoStreamRentalApp;

namespace TestsVideoStreamRentalApp;

[TestClass]
public class VideoStreamRentalTests
{
    
    private static void AssertFeeAndFidelityPoints(Customer c, decimal expectedFee, int expectedFidelityPoints)
    {
        Assert.AreEqual(expectedFee, c.GetRentalFee());
        Assert.AreEqual(expectedFidelityPoints, c.GetLoyaltyPoints());
    }
    
    [TestMethod]
    public void ShouldChargeAndGivePoints_GivenOneDayRental()
    {
        Customer c = new Customer();
        c.AddRental("Regular Movie" ,1);
        AssertFeeAndFidelityPoints(c, 1.5m, 1);
    }



    [TestMethod]
    public void ShouldChargeButNotGivePoints_GivenThreeDayRental()
    {
        Customer c = new Customer();
        c.AddRental("Regular Movie" ,2);
        AssertFeeAndFidelityPoints(c, 1.5m, 1);

        c.AddRental("Regular Movie" ,3);
        AssertFeeAndFidelityPoints(c, 1.5m, 1);
    }
    [TestMethod]
    public void ShouldChargeAndGivePoints_GivenFourDaysRental()
    {
        Customer c = new Customer();
        c.AddRental("Regular Movie" ,4);
        AssertFeeAndFidelityPoints(c, 3.0m, 2);
    }
}