namespace Doubles.Domain
{

    public class UserController
    {
        public UserController()
        {

        }
        
        // authencicator es Dummy - no hace nada
        public bool Login(string username, string password, IAuthenticator authenticator)
        {
            //aca se llama al autenticador. puede ser el real, o los doubles según quien llame
            return authenticator.Validate(username, password);
        }
    }
}