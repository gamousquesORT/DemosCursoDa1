namespace IfsBeforeRefactor;

public class PaymentProcessor
{
    public void ProcessPayment(object payment, decimal amount)
    {
        //esto hay que mejorarlo,
        //tampoco es bueno usar el downcasting
        
        if (payment is CreditCard)
        {
            ((CreditCard) payment).ProcessCreditCard(amount);
        }
        else if (payment is PayPal)
        {
            ((PayPal) payment).ProcessPayPal(amount);
        }
        else if (payment is BankTransfer)
        {
            ((BankTransfer) payment).ProcessBankTransfer(amount);
        }
    }
}

public class CreditCard
{
    public void ProcessCreditCard(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment: ${amount}");
    }
}

public class PayPal
{
    public void ProcessPayPal(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment: ${amount}");
    }   
}

public class BankTransfer
{
    public void ProcessBankTransfer(decimal amount)
    {
        Console.WriteLine($"Processing bank transfer: ${amount}");
    }  
}