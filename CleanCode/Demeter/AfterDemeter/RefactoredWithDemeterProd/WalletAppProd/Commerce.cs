namespace RefactoredWithDemeter;

public class Commerce
{
    public void Checkout(Customer customer, decimal amount)
    {
        if (customer.Pay(amount))
            Console.WriteLine("Purchase completed");
        else
            Console.WriteLine("Not enough money");
    }
}