namespace IfsAfterRefactor;

public class PaymentProcessor
{
    public void ProcessPayment(IPayment payment, decimal amount)
    {
        payment.Process(amount);
    }
}