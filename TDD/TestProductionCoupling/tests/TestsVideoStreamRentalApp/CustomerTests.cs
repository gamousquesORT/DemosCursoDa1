using VideoStreamRentalApp;

namespace TestsVideoStreamRentalApp;

[TestClass]
public class VideoStreamRentalTests
{
    [TestMethod]
    public void ShouldChargeAndGivePoints_GivenOneDayRental()
    {
        Customer c = new Customer();
        c.AddRental("Regular Movie" ,1);
        Assert.AreEqual(1.5m, c.GetRentalFee());
        Assert.AreEqual(1, c.GetLoyaltyPoints());
    }
    
    [TestMethod]
    public void ShouldChargeButNotGivePoints_GivenThreeDayRental()
    {
        Customer c = new Customer();
        c.AddRental("Regular Movie" ,2);
        Assert.AreEqual(1.5m, c.GetRentalFee());
        c.AddRental("Regular Movie" ,3);
        Assert.AreEqual(1.5m, c.GetRentalFee());
        Assert.AreEqual(1, c.GetLoyaltyPoints());
    }
}