using InvoiceApp;

namespace TestInvoiceApp;

[TestClass]
public class InvoiceAppTests
{
    [TestMethod]
    public void ShouldRetuenExpectedTotalGivenPositiveWholeNumbers()
    {
        // Arrange
        double price    = 100.0;
        double quantity = 2.0;
        double expected = price * quantity * 1.2; // 240
        Invoice invoice = new Invoice();
        // Act
        double actual = invoice.Calculate(price, quantity);

        // Assert
        Assert.AreEqual(expected, actual, 0.0001);
    }
    
    [TestMethod]
    public void ShouldReturnExpectedTotalGivenPositiveDecimals()
    {
        // Arrange
        double price    = 10.5;
        double quantity = 3.0;
        double expected = price * quantity * 1.2; // 37.8

        // Act
        Invoice invoice = new Invoice();
        double actual = invoice.Calculate(price, quantity);

        // Assert
        Assert.AreEqual(expected, actual, 0.0001);
    }
    
    [TestMethod]
    public void ShouldReturnZeroGivenZeroPrice()
    {
        // Act
        double price    = 0;
        double quantity = 3.0;
        double expected = 0;
        Invoice invoice = new Invoice();
        
        // Assert
        Assert.AreEqual(expected, invoice.Calculate(price, quantity), 0.0001);
    }

    [TestMethod]
    public void ShouldReturnZeroGivenZeroQuantity()
    {
        // Act
        double price    = 4.0;
        double quantity = 0;
        double expected = 0;
        Invoice invoice = new Invoice();
        
        // Assert
        Assert.AreEqual(expected, invoice.Calculate(price, quantity), 0.0001);
    }
    
    [TestMethod]
    public void ShouldReturnZeroGivenZeroBothQuantityAndPrice()
    {
        // Act
        double price    = 0;
        double quantity = 0;
        Invoice invoice = new Invoice();
        
        // Assert
        Assert.AreEqual(0.0, invoice.Calculate(price, quantity), 0.0001);
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ShouldThrowArgumentExceptionGivenNegativeQuantity()
    {
        // Act
        double price    = 34;
        double quantity = -1;

        Invoice invoice = new Invoice();
        
        invoice.Calculate(price, quantity);
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ShouldThrowArgumentExceptionGivenNegativePrice()
    {
        // Act
        double price    = -34;
        double quantity = 1;

        Invoice invoice = new Invoice();
        
        invoice.Calculate(price, quantity);
    }
    
}