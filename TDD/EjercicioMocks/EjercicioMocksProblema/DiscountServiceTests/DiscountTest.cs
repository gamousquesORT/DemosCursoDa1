using Domain;

namespace DomainTests;

[TestClass]
public class DiscountServiceTests
{
    [TestMethod]
    public void ApplyDiscount_ShouldApplyDiscount()
    {
        var service = new DiscountService();

        var result = service.ApplyDiscount(100);

        // Espera que SIEMPRE aplique descuento (pero no siempre pasa)
        Assert.AreEqual(90, result);
    }

    [TestMethod]
    public void ApplyDiscount_ShouldNotApplyDiscount()
    {
        var service = new DiscountService();

        var result = service.ApplyDiscount(100);

        // Espera que NUNCA aplique descuento (pero a veces sí lo hace)
        Assert.AreEqual(100, result);
    }
    
}