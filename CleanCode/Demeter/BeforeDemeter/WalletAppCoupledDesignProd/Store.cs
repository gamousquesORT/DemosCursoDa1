namespace WalletAppDomain;

public class Store
{
    public void Checkout(Customer customer, decimal amount)
    {
        Wallet wallet = customer.Wallet;
        if (wallet.Money >= amount)
        {
            wallet.DrawMoney(amount);
            Console.WriteLine("Purchase completed");
        }
        else
        {
            Console.WriteLine("Not enough money");
            throw new WalletException("Error: Not enough cash");
        }
    }
}

public class WalletException : Exception
{
    public WalletException()
    {
        
    }
    public WalletException(string errorNotEnoughCash):base(errorNotEnoughCash)
    {
        
    }
    
    public WalletException(string errorNotEnoughCash, Exception innerException):base(errorNotEnoughCash, innerException)
    {
        
    }
}