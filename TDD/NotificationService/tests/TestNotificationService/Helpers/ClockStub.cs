using NotificationServiceApp.Domain;
namespace TestNotificationService.Helpers;

public class ClockStub: IClock
{
    private readonly DateTime _fixedTiem;
    public ClockStub(DateTime fixedTime)
    {
        _fixedTiem = fixedTime;
    }

    public DateTime Now => _fixedTiem;

}