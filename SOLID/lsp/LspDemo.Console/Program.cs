using LspDemo.Console;

public class Program
{
    public static void Main(string[] args)
    {
        BankAccount regularAccount = new BankAccount { Balance = 500 };
        BankAccount fixedAccount = new FixedTermAccount { Balance = 500 };

        Console.WriteLine("=== Liskov Substitution Principle violation demo ===\n");

        Run("Regular account (BankAccount)", regularAccount);
        Run("Fixed-term account (FixedTermAccount, used as a BankAccount)", fixedAccount);

        Console.WriteLine("Conclusion: ProcessWithdrawal(BankAccount) works for the base class,");
        Console.WriteLine("but crashes when given the subtype. The subtype is NOT substitutable.");
    }

    private static void Run(string title, BankAccount account)
    {
        Console.WriteLine($"--> {title}");
        Console.WriteLine($"    Balance before: {account.Balance}");
        try
        {
            ProcessWithdrawal(account, 100);
            Console.WriteLine($"    OK. Balance after: {account.Balance}\n");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"    FAILED: {ex.GetType().Name}: {ex.Message}\n");
            Console.ResetColor();
        }
    }

    public static void ProcessWithdrawal(BankAccount account, decimal amount)
    {
        account.Withdraw(amount);
    }
}
