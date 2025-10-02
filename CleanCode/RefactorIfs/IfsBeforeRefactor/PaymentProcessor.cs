namespace IfsBeforeRefactor;

public class PaymentProcessor
{
    public void ProcessPayment(object payment, decimal amount)
    {
        if (payment is CreditCard)
        {
            Console.WriteLine($"Processing credit card payment: ${amount}");
        }
        else if (payment is PayPal)
        {
            Console.WriteLine($"Processing PayPal payment: ${amount}");
        }
        else if (payment is BankTransfer)
        {
            Console.WriteLine($"Processing bank transfer: ${amount}");
        }
    }
}

public class CreditCard { }
public class PayPal { }
public class BankTransfer { }