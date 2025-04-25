using VideoStreamRentalApp;

namespace TestsVideoStreamRentalApp;

[TestClass]
public class VideoStreamRentalTests
{
    private Customer c;
    
    [TestInitialize]
    public void TestInitialize()
    {
        c = new Customer();
    }
    private void AssertFeeAndFidelityPoints(decimal expectedFee, int expectedFidelityPoints)
    {
        Assert.AreEqual(expectedFee, c.GetRentalFee());
        Assert.AreEqual(expectedFidelityPoints, c.GetLoyaltyPoints());
    }
    
    [TestMethod]
    public void ShouldChargeAndGivePoints_GivenOneDayRental()
    {
        c.AddRental("Regular Movie" ,1);
        AssertFeeAndFidelityPoints(1.5m, 1);
    }



    [TestMethod]
    public void ShouldChargeButNotGivePoints_GivenThreeDayRental()
    {
        c.AddRental("Regular Movie" ,2);
        AssertFeeAndFidelityPoints(1.5m, 1);

        c.AddRental("Regular Movie" ,3);
        AssertFeeAndFidelityPoints(1.5m, 1);
    }
    [TestMethod]
    public void ShouldChargeAndGivePoints_GivenFourDaysRental()
    {
        c.AddRental("Regular Movie" ,4);
        AssertFeeAndFidelityPoints(3.0m, 2);
    }
    [TestMethod]
    public void ShouldChargeAndGivePoints_GivenFiveDaysRental()
    {
        c.AddRental("Regular Movie" ,5);
        AssertFeeAndFidelityPoints(4.5m, 3);
    }
    [TestMethod]
    public void ShouldChargeAndGivePoints_GivenADayRentalOfChildrenMovie()
    {
        c.AddRental("Children Movie" ,1);
        AssertFeeAndFidelityPoints(1, 1);
    }

    [TestMethod]
    public void ShouldChargeFourDaysAndGiveOnePoint_GivenFourRentalOfChildrenMovie()
    {
        c.AddRental("Children Movie" ,4);
        AssertFeeAndFidelityPoints(4, 1);       
    }
    [TestMethod]
    public void ShouldChargeAndGivePoints_GivenRentingMoreThanOneMovie()
    {
        c.AddRental("Regular Movie" ,4); //$3 y 2p
        c.AddRental("Children Movie" ,4); // $4 y 1p
        AssertFeeAndFidelityPoints(7m, 3);
    }
}