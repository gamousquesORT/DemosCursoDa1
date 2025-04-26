using System;

class Program
{
    static void Main()
    {
        try
        {
            int result = SafeDivide();
            Console.WriteLine($"Result is {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }

    static int SafeDivide()
    {
        int[] numbers = { 1, 2, 0, 3, 4 };
        if (numbers[2] == 0)
            {
                throw new DivideByZeroException("The divisor cannot be zero.");
            }
        return numbers[0] / numbers[2];
    }
}