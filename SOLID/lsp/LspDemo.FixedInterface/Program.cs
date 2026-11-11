using LspDemo.FixedInterface;

Console.WriteLine("=== LSP fix #1: capability interface (IWithdrawable) ===\n");

var checking = new CheckingAccount();
checking.Deposit(500);
var fixedTerm = new FixedTermAccount();
fixedTerm.Deposit(500);

ProcessWithdrawal(checking, 100);
Console.WriteLine($"Checking balance after withdrawal: {checking.Balance}");

// ProcessWithdrawal(fixedTerm, 100);   // <-- does NOT compile: FixedTermAccount is not IWithdrawable
Console.WriteLine($"Fixed-term balance (untouched):     {fixedTerm.Balance}");
Console.WriteLine("\nUncomment the FixedTermAccount call to see the compile-time error.");

static void ProcessWithdrawal(IWithdrawable account, decimal amount) => account.Withdraw(amount);
