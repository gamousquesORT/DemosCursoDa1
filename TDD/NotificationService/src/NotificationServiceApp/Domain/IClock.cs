namespace NotificationServiceApp.Domain;

public interface IClock
{
    DateTime Now { get; }
}
