namespace LspDemo.Console;

public class BankAccount
{
    public decimal Balance { get; set; }

    public virtual void Withdraw(decimal amount)
    {
        if (amount > Balance)
            throw new InvalidOperationException("Insufficient funds");

        Balance -= amount;
    }
}
