using NotificationServiceApp.Domain;
using TestNotificationService.Helpers;

namespace TestNotificationService;

[TestClass]
public class NotificationServiceTests
{
    [TestMethod]
    public void ShouldSendNotificationGivenBuisinessHours()
    {
        // Arrange: 10:00 AM
        var stubClock = new ClockStub(new DateTime(2025, 4, 17, 10, 0, 0));
        var service = new NotificationService(stubClock);

        // Act
        var canSend = service.CanSendNotification();

        // Assert
        Assert.IsTrue(canSend);
    }
    
    [TestMethod]
    public void ShouldNotSendNotificationGivenNonBuisinessHours()
    {
        // Arrange: 10:00 AM
        var stubClock = new ClockStub(new DateTime(2025, 4, 17, 18, 0, 0));
        var service = new NotificationService(stubClock);

        // Act
        var canSend = service.CanSendNotification();

        // Assert
        Assert.IsFalse(canSend);
    }
}