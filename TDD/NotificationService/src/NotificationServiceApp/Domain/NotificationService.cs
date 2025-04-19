namespace NotificationServiceApp.Domain;

// la clase envia notificaciones solamente en horario laboral
// 9:00 AM - 5:00 PM
// la clase depende de un reloj, que para las pruebas se simula mediante un stub
public class NotificationService
{
    private const int OpenHour = 9;
    private const int CloseHour = 17;
    private readonly IClock _clock;

    public NotificationService(IClock clock)
    {
        _clock = clock;
    }

    public bool CanSendNotification()
    {
        var now = _clock.Now;
        return now.Hour >= OpenHour && now.Hour < CloseHour; 
    } 
}