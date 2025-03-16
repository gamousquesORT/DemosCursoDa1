// See https://aka.ms/new-console-template for more information

namespace CustomerApp;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            var customer1 = new Customer();
            customer1.Name = "Juan";
            customer1.Address = "Av. 8 de Octubre 2738";
            customer1.Email = "me@me";
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
    }
}
