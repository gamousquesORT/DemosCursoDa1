using InvoiceApp;

namespace TestInvoiceApp;

[TestClass]
public class InvoiceAppTests
{
    [TestMethod]
    public void ShouldCreateInvoiceGivenPositiveQuantityAndPrice()
    {
        // Arrange
        Invoice invoice = new Invoice(100.0, 2.0);
        double expectedPrice = 240.0;
        
        double actual = invoice.Calculate();
        
        Assert.AreEqual(expectedPrice, actual, 0.0001);
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ShouldThrowArgumentExceptionGivenANegativeQuantityArgument()
    {
        // Arrange
        Invoice invoice = new Invoice(100.0, -2.0);

    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ShouldThrowArgumentExceptionCallingNegativePriceProperty()
    {
        // Arrange
        Invoice invoice = new Invoice();
        // Act
        invoice.Price = -2.0;

    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ShouldThrowArgumentExceptionCallingNegativeQuantityProperty()
    {
        // Arrange
        Invoice invoice = new Invoice();
        // Act
        invoice.Quantity = -2.0;

    }
    
    [TestMethod]
    public void ShouldReturnExpectedTotalGivenPositiveWholeNumbers()
    {
        // Arrange
        double price    = 100.0;
        double quantity = 2.0;
        double expected = price * quantity * 1.2; // 240
        Invoice invoice = new Invoice(price, quantity);
        // Act
        double actual = invoice.Calculate();

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
        Invoice invoice = new Invoice(price, quantity);
        double actual = invoice.Calculate();

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
        Invoice invoice = new Invoice(price, quantity);
        
        // Assert
        Assert.AreEqual(expected, invoice.Calculate(), 0.0001);
    }

    [TestMethod]
    public void ShouldReturnZeroGivenZeroQuantity()
    {
        // Act
        double price    = 4.0;
        double quantity = 0;
        double expected = 0;
        Invoice invoice = new Invoice(price, quantity);
        
        // Assert
        Assert.AreEqual(expected, invoice.Calculate(), 0.0001);
    }
    
    [TestMethod]
    public void ShouldReturnZeroGivenZeroBothQuantityAndPrice()
    {
        // Act
        Invoice invoice = new Invoice();
        
        // Assert
        Assert.AreEqual(0.0, invoice.Calculate(), 0.0001);
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ShouldThrowArgumentExceptionGivenNegativeQuantity()
    {
        // Act
        double price    = 34;
        double quantity = -1;

        Invoice invoice = new Invoice(price, quantity);
        
        invoice.Calculate();
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ShouldThrowArgumentExceptionGivenNegativePrice()
    {
        // Act
        double price    = -34;
        double quantity = 1;

        Invoice invoice = new Invoice(price, quantity);
        
        invoice.Calculate();
    }
    
}