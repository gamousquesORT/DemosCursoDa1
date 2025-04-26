namespace WalletAppDomain;

public class Wallet
{
    private decimal _money=0;
    
    public decimal Money
    {
        get { return _money; }
        set { _money = value; }
    }
    
    public decimal AddMoney(decimal money)
    {
        _money += money;
        return _money;
    }
    public decimal DrawMoney(decimal money)
    {
        _money -= money;
        return _money;
    }
}