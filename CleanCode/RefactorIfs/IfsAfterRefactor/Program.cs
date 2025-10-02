namespace IfsAfterRefactor;

public class Program
{
    public static void Main(string[] args)
    {
        var processor = new PaymentProcessor();
        
        IPayment payment1 = new CreditCard();
        IPayment payment2 = new PayPal();
        IPayment payment3 = new BankTransfer();
        
        processor.ProcessPayment(payment1, 100.50m);
        processor.ProcessPayment(payment2, 75.25m);
        processor.ProcessPayment(payment3, 200.00m);
    }
}