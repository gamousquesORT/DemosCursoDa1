class Program
{
    static void Main()
    {
        try
        {
            int result = Divide();
            Console.WriteLine($"Result is {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred.", ex.Message);
        }
    }

    static int Divide()
    {
        try
        {
            int[] numbers = { 1, 2, 0, 3, 4 };
            if (numbers[2] == 0)
            {
                throw new Exception("Division by zero.");
            }
            
            return numbers[0] / numbers[2];
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}