using Domain;
using Moq;

namespace DomainTests;

[TestClass]
public class DiscountServiceTests
{
    [TestMethod]
    public void ApplyDiscount_ShouldApplyDiscount()
    {
        // SUT
        var service = new DiscountService();
        // Collaborator
        var mockDiscount = new Mock<IDiscount>();
        mockDiscount.Setup(d => d.GetDiscountPercentage()).Returns(1);

        //Act
        var result = service.ApplyDiscount(100, mockDiscount.Object);

        Assert.AreEqual(90, result);
        mockDiscount.Verify(d => d.GetDiscountPercentage(), Times.Once);
    }

    [TestMethod]
    public void ApplyDiscount_ShouldNotApplyDiscount()
    {
        //SUT
        var service = new DiscountService();
        // Collaborator
        var mockDiscount = new Mock<IDiscount>();
        mockDiscount.Setup(d => d.GetDiscountPercentage()).Returns(3);

        var result = service.ApplyDiscount(100, mockDiscount.Object);

        Assert.AreEqual(100, result);
        mockDiscount.Verify(d => d.GetDiscountPercentage(), Times.Once);
    }
}