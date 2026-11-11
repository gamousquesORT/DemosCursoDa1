namespace LspDemo.FixedInterface;

public class CheckingAccount : Account, IWithdrawable
{
    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
            throw new InvalidOperationException("Insufficient funds");

        Balance -= amount;
    }
}
