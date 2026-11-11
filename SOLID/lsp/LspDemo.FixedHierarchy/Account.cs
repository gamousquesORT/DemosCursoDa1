namespace LspDemo.FixedHierarchy;

public abstract class Account
{
    public decimal Balance { get; protected set; }
    public void Deposit(decimal amount) => Balance += amount;
}
