using Doubles.Domain;

namespace DummyTests.StubTests
{
    // este authenticator es un stub porque retorna algo especifico 
    // en este en función del usuario
    
    public class StubAuthenticator : IAuthenticator
    {
        public bool Validate(string username, string password)
        {
            if (username == "gaston")
                return true;
            return false;
        }
    }
}