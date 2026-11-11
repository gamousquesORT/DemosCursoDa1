namespace LspDemo.FixedHierarchy;

public class WithdrawableAccount : Account
{
    public virtual void Withdraw(decimal amount)
    {
        if (amount > Balance)
            throw new InvalidOperationException("Insufficient funds");

        Balance -= amount;
    }
}
