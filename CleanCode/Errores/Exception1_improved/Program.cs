using System;

class Program
{
    static void Main()
    {
        int result = 0, divisor = 0;
        try
        {
            result = Calculate(5, divisor);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred.", ex.Message);
        }
        
        Console.WriteLine($"Result is {result}");
    }

    static int Calculate(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("The divisor must not be zero.");
        }
        return a / b;
    }
}