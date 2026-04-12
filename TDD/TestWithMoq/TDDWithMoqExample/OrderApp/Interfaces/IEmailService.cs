namespace OrderApp.Interfaces;

public interface IEmailService
{
    void SendConfirmation(string customerEmail, int orderId);
}
