using Stubs.Domain.Interfaces;

namespace Stubs.Domain
{

    public class UserController
    {
        
        // la funcion no sabe que autenticador se le pasa, puede ser el real o un double
        public bool Login(string username, string password, IAuthenticator authenticator)
        {
            return authenticator.Validate(username, password);
        }
    }
}