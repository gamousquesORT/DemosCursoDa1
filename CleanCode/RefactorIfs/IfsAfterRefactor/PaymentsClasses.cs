namespace IfsAfterRefactor;

public class CreditCard : IPayment
{
    public void Process(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment: ${amount}");
    }
}

public class PayPal : IPayment
{
    public void Process(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment: ${amount}");
    }
}

public class BankTransfer : IPayment
{
    public void Process(decimal amount)
    {
        Console.WriteLine($"Processing bank transfer: ${amount}");
    }
}



