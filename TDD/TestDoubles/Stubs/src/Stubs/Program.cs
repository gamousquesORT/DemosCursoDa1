using Stubs.Domain;
using Stubs.Domain.Interfaces;

namespace Stubs;

public class Program
{
    public static void Main(string[] args)
    {
        UserController userController = new UserController();
        
        IAuthenticator authenticator = new Authenticator();
        bool result = userController.Login("guest", "guest", authenticator);
        Console.WriteLine($"La autenticación resultó {result}");
    }

}