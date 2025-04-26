namespace EjerciciosReconocimiento;

class Program
{
    static void Main()
    {
        int result = 0;
        try
        {
            result = Calculate(5, 0);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine($"Result is {result}");
    }

    static int Calculate(int a, int b)
    {
        return a / b;
    }
}