using Domain;
using DomainTests.TestDoubles;

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
        IDiscount discount = new StubDiscount(1);
        
        //Act
        var result = service.ApplyDiscount(100, discount);

        Assert.AreEqual(90, result);
    }

    [TestMethod]
    public void ApplyDiscount_ShouldNotApplyDiscount()
    {
        //SUT
        var service = new DiscountService();
        // Collaborator
        IDiscount discount = new StubDiscount(3);
        
        var result = service.ApplyDiscount(100, discount);

        Assert.AreEqual(100, result);
    }
}