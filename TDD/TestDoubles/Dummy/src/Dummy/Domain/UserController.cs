namespace Dummy.Domain
{

    public class UserController
    {

        // authencicator es Helpers - no se usa, lo necesito porque a futuro voy a tener la 
        // implementación con el autenticator
        public bool Login(string username, string password, IAuthenticator authenticator)
        {
            // en la realidad NUNCA haga esto!!!!!!
            if (username == "gaston" && password == "1234")
                return true;
            else
                return false;
        }
    }
}