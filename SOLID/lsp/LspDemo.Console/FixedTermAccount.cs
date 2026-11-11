namespace LspDemo.Console;

// VIOLATES LSP: strengthens the contract of Withdraw by refusing it entirely.
// Callers holding a BankAccount reference cannot substitute this subtype safely.
public class FixedTermAccount : BankAccount
{
    public override void Withdraw(decimal amount)
    {
        throw new NotSupportedException(
            "Withdrawals are not allowed from fixed-term accounts");
    }
}
