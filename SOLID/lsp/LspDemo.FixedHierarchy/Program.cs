using LspDemo.FixedHierarchy;

Console.WriteLine("=== LSP fix #2: rearranged class hierarchy ===\n");
Console.WriteLine("Account\n├── FixedTermAccount\n└── WithdrawableAccount\n    └── CheckingAccount\n");

var checking = new CheckingAccount();
checking.Deposit(500);
var fixedTerm = new FixedTermAccount();
fixedTerm.Deposit(500);

ProcessWithdrawal(checking, 100);
Console.WriteLine($"Checking balance after withdrawal: {checking.Balance}");

// ProcessWithdrawal(fixedTerm, 100);   // <-- does NOT compile: FixedTermAccount is not a WithdrawableAccount
Console.WriteLine($"Fixed-term balance (untouched):     {fixedTerm.Balance}");
Console.WriteLine("\nUncomment the FixedTermAccount call to see the compile-time error.");

static void ProcessWithdrawal(WithdrawableAccount account, decimal amount) => account.Withdraw(amount);
