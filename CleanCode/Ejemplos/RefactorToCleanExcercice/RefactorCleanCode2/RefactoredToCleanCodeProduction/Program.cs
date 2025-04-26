using RefactoredToCleanCodeProduction;

// this is one posible solution after refactoring and applying:
// Extract class
// extract method

public class Program
{
    public static void Main(string[] args)
    {
        // Clean Code Book Chapter 2
        GuessStatisticsMessage cm = new GuessStatisticsMessage();

        Console.WriteLine(        cm.Make('C', 4));
        Console.WriteLine(        cm.Make('E', 3));
        Console.WriteLine(        cm.Make('C', 4));

    }
}