using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OrderApp.Interfaces;
using OrderApp.Models;
using OrderApp.Services;

namespace OrderApp.Tests;

[TestClass]
public class OrderServiceTests
{
    // ── shared fixtures ──────────────────────────────────────────────────────
    private Mock<IInventoryRepository> _inventoryMock = null!;
    private Mock<IEmailService> _emailMock = null!;
    private OrderService _sut = null!;

    [TestInitialize]
    public void Setup()
    {
        _inventoryMock = new Mock<IInventoryRepository>();
        _emailMock     = new Mock<IEmailService>();
        _sut           = new OrderService(_inventoryMock.Object, _emailMock.Object);
    }

    // ── Test 1: Setup + Returns ───────────────────────────────────────────────
    // Moq concept: mock.Setup(x => x.Method()).Returns(value)
    //   → controls what the mock returns when called
    [TestMethod]
    public void WhenStockIsAvailable_ThenReturnsSuccess()
    {
        // Arrange
        var order = new Order { Id = 1, CustomerEmail = "alice@example.com", ProductId = "P1", Quantity = 2 };

        _inventoryMock
            .Setup(r => r.HasStock("P1", 2))
            .Returns(true);                     // <-- stub: always say "yes, stock exists"

        // Act
        var result = _sut.PlaceOrder(order);

        // Assert
        Assert.AreEqual(OrderResult.Success, result);
    }

    // ── Test 2: Verify + Times.Once ───────────────────────────────────────────
    // Moq concept: mock.Verify(x => x.Method(), Times.Once)
    //   → asserts the method was called exactly once
    [TestMethod]
    public void WhenStockIsAvailable_ThenSendsConfirmationEmail()
    {
        // Arrange
        var order = new Order { Id = 42, CustomerEmail = "alice@example.com", ProductId = "P1", Quantity = 2 };

        _inventoryMock
            .Setup(r => r.HasStock("P1", 2))
            .Returns(true);

        // Act
        _sut.PlaceOrder(order);

        // Assert
        _emailMock.Verify(
            e => e.SendConfirmation("alice@example.com", 42),   // <-- exact args
            Times.Once);                                        // <-- called exactly once
    }

    // ── Test 3: Verify + Times.Never ─────────────────────────────────────────
    // Moq concept: Times.Never
    //   → asserts the method was NEVER called (negative verification)
    [TestMethod]
    public void WhenStockIsNotAvailable_ThenDoesNotSendEmail()
    {
        // Arrange
        var order = new Order { Id = 7, CustomerEmail = "bob@example.com", ProductId = "P2", Quantity = 5 };

        _inventoryMock
            .Setup(r => r.HasStock("P2", 5))
            .Returns(false);                    // <-- stub: no stock

        // Act
        _sut.PlaceOrder(order);

        // Assert
        _emailMock.Verify(
            e => e.SendConfirmation(It.IsAny<string>(), It.IsAny<int>()),   // <-- any args
            Times.Never);                                                   // <-- must NOT be called
    }

    // ── Test 4: Returns + Assert on result ───────────────────────────────────
    // Moq concept: combining Setup with result assertion
    //   → stub drives a different code path; we verify the outcome
    [TestMethod]
    public void WhenStockIsNotAvailable_ThenReturnsInsufficientStock()
    {
        // Arrange
        var order = new Order { Id = 3, CustomerEmail = "carol@example.com", ProductId = "P3", Quantity = 10 };

        _inventoryMock
            .Setup(r => r.HasStock("P3", 10))
            .Returns(false);

        // Act
        var result = _sut.PlaceOrder(order);

        // Assert
        Assert.AreEqual(OrderResult.InsufficientStock, result);
    }
}
