using VideoStreamRentalApp;

namespace TestsVideoStreamRentalApp;

[TestClass]
public class VideoStreamRentalTests
{
    private VideoRentalService videoRentalService;
    
    [TestInitialize]
    public void TestInitialize()
    {
        videoRentalService = new VideoRentalService();
    }
    private void AssertFeeAndFidelityPoints(decimal expectedFee, int expectedFidelityPoints)
    {
        Assert.AreEqual(expectedFee, videoRentalService.GetRentalFee());
        Assert.AreEqual(expectedFidelityPoints, videoRentalService.GetLoyaltyPoints());
    }
    
    [TestMethod]
    public void ShouldChargeAndGivePoints_GivenOneDayRental()
    {
        videoRentalService.AddRental("Regular Title" ,1);
        AssertFeeAndFidelityPoints(1.5m, 1);
    }



    [TestMethod]
    public void ShouldChargeButNotGivePoints_GivenThreeDayRental()
    {
        videoRentalService.AddRental("Regular Title" ,2);
        videoRentalService.AddRental("Regular Title" ,3);
        AssertFeeAndFidelityPoints(3m, 2);
    }
    [TestMethod]
    public void ShouldChargeAndGivePoints_GivenFourDaysRental()
    {
        videoRentalService.AddRental("Regular Title" ,4);
        AssertFeeAndFidelityPoints(3.0m, 2);
    }
    [TestMethod]
    public void ShouldChargeAndGivePoints_GivenFiveDaysRental()
    {
        videoRentalService.AddRental("Regular Title" ,5);
        AssertFeeAndFidelityPoints(4.5m, 3);
    }
    [TestMethod]
    public void ShouldChargeAndGivePoints_GivenADayRentalOfChildrenMovie()
    {
        videoRentalService.AddRental("Children Title" ,1);
        AssertFeeAndFidelityPoints(1, 1);
    }

    [TestMethod]
    public void ShouldChargeFourDaysAndGiveOnePoint_GivenFourRentalOfChildrenMovie()
    {
        videoRentalService.AddRental("Children Title" ,4);
        AssertFeeAndFidelityPoints(4, 1);       
    }
    [TestMethod]
    public void ShouldChargeAndGivePoints_GivenRentingMoreThanOneMovie()
    {
        videoRentalService.AddRental("Regular Title" ,4); //$3 y 2p
        videoRentalService.AddRental("Children Title" ,4); // $4 y 1p
        AssertFeeAndFidelityPoints(7m, 3);
    }
}