namespace OrderApp.Interfaces;

public interface IEmailSender
{
    void SendConfirmation(string customerEmail, int orderId);
}
