namespace WalletAppDomain;

public class Customer
{
    private Wallet _wallet;

    public Customer()
    {
        _wallet = new Wallet();
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Wallet Wallet
    {
        get { return _wallet; }
    }
}