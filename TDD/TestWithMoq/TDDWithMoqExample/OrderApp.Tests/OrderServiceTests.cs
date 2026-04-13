using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OrderApp.BusinessClasses;
using OrderApp.Interfaces;
using OrderApp.Services;

namespace OrderApp.Tests;

[TestClass]
public class OrderServiceTests
{

    private Mock<IProductRepository> _productoRepoMock = null!;
    private Mock<IEmailSender> _emailMock = null!;
    private OrderService _sut = null!;

    [TestInitialize]
    public void Setup()
    {
        _productoRepoMock = new Mock<IProductRepository>();
        _emailMock     = new Mock<IEmailSender>();
        _sut           = new OrderService(_productoRepoMock.Object, _emailMock.Object);
    }

    [TestMethod]
    public void WhenStockIsAvailableAndOrderIsPlaced_ThenReturnsAvailableQty()
    {
        // Arrange
        var order = new Order { Id = 1, CustomerEmail = "alice@example.com", ProductId = "P1", Quantity = 2 };

        _productoRepoMock
            .Setup(r => r.GetByProductId("P1"))
            .Returns(new Product { ProductId = "P1", AvailableQuantity = 10 });   

        // Act
        var result = _sut.PlaceOrder(order);

        // Assert
        Assert.AreEqual(8, result);
    }


    [TestMethod]
    public void WhenStockIsAvailable_ThenSendsConfirmationEmail()
    {
        // Arrange
        var order = new Order { Id = 42, CustomerEmail = "alice@example.com", ProductId = "P1", Quantity = 2 };

        _productoRepoMock
            .Setup(r => r.GetByProductId("P1"))
            .Returns(new Product { ProductId = "P1", AvailableQuantity = 10 });

        // Act
        _sut.PlaceOrder(order);

        // Assert
        _emailMock.Verify(
            e => e.SendConfirmation("alice@example.com", 42),   
            Times.Once);                                        
    }


    [TestMethod]
    public void WhenStockIsNotAvailableAndOrderIsPlaced_ThenDoesNotSendEmail()
    {
        // Arrange
        var order = new Order { Id = 7, CustomerEmail = "bob@example.com", ProductId = "P2", Quantity = 5 };

        _productoRepoMock
            .Setup(r => r.GetByProductId("P2"))
            .Returns(new Product { ProductId = "P2", AvailableQuantity = 2 });    

        // Act
        try
        {
            _sut.PlaceOrder(order);
        }
        catch (ArgumentException)
        {
            // do nothing just let the test continue
        }

        // Assert
        _emailMock.Verify(
            e => e.SendConfirmation(It.IsAny<string>(), It.IsAny<int>()),   
            Times.Never);                                                   
    }


    [TestMethod]
    public void WhenStockIsNotAvailableAnsOrderIsPlaced_ThenReturnsInsufficientStock()
    {
        // Arrange
        var order = new Order { Id = 3, CustomerEmail = "carol@example.com", ProductId = "P3", Quantity = 10 };

        _productoRepoMock
            .Setup(r => r.GetByProductId("P3"))
            .Returns(new Product { ProductId = "P3", AvailableQuantity = 0 });    // 0 < 10 → no stock

        // Act
       // Assert
        Assert.ThrowsException<ArgumentException>(()=> _sut.PlaceOrder(order));
    }
}
