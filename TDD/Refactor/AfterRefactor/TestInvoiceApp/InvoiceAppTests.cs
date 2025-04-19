using InvoiceApp;

namespace TestInvoiceApp;

[TestClass]
public class InvoiceAppTests
{
    [TestMethod]
    public void ShouldCreateInvoiceGivenPositiveQuantityAndPrice()
    {
        // Arrange
        Invoice invoice = new Invoice(100.0m, 2.0m);
        decimal expectedPrice = 240.0m;
        
        decimal actual = invoice.Calculate();
        
        Assert.AreEqual(expectedPrice, actual);
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ShouldThrowArgumentExceptionGivenANegativeQuantityArgument()
    {
        // Arrange
        Invoice invoice = new Invoice(100.0m, -2.0m);

    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ShouldThrowArgumentExceptionCallingNegativePriceProperty()
    {
        // Arrange
        Invoice invoice = new Invoice();
        // Act
        invoice.Price = -2;

    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ShouldThrowArgumentExceptionCallingNegativeQuantityProperty()
    {
        // Arrange
        Invoice invoice = new Invoice();
        // Act
        invoice.Quantity = -2;

    }
    
    [TestMethod]
    public void ShouldReturnExpectedTotalGivenPositiveWholeNumbers()
    {
        // Arrange
        decimal price    = 100;
        decimal quantity = 2;
        decimal expected = price * quantity * 1.2m; // 240
        Invoice invoice = new Invoice(price, quantity);
        // Act
        decimal actual = invoice.Calculate();

        // Assert
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void ShouldReturnExpectedTotalGivenPositiveDecimals()
    {
        // Arrange
        decimal price    = 10.5m;
        decimal quantity = 3;
        decimal expected = price * quantity * 1.2m; // 37.8

        // Act
        Invoice invoice = new Invoice(price, quantity);
        decimal actual = invoice.Calculate();

        // Assert
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void ShouldReturnZeroGivenZeroPrice()
    {
        // Act
        decimal price    = 0;
        decimal quantity = 3.0m;
        decimal expected = 0;
        Invoice invoice = new Invoice(price, quantity);
        
        // Assert
        Assert.AreEqual(expected, invoice.Calculate());
    }

    [TestMethod]
    public void ShouldReturnZeroGivenZeroQuantity()
    {
        // Act
        decimal price    = 4;
        decimal quantity = 0;
        decimal expected = 0;
        Invoice invoice = new Invoice(price, quantity);
        
        // Assert
        Assert.AreEqual(expected, invoice.Calculate());
    }
    
    [TestMethod]
    public void ShouldReturnZeroGivenZeroBothQuantityAndPrice()
    {
        // Act
        Invoice invoice = new Invoice();
        
        // Assert
        Assert.AreEqual(0, invoice.Calculate());
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ShouldThrowArgumentExceptionGivenNegativeQuantity()
    {
        // Act
        decimal price    = 34;
        decimal quantity = -1;

        Invoice invoice = new Invoice(price, quantity);
        
        invoice.Calculate();
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ShouldThrowArgumentExceptionGivenNegativePrice()
    {
        // Act
        decimal price    = -34;
        decimal quantity = 1;

        Invoice invoice = new Invoice(price, quantity);
        
        invoice.Calculate();
    }
    
}