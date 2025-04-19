using Stubs.Domain;
using Stubs.Domain.Interfaces;

namespace DummyTests.StubTests;

// este authenticator es un stub porque retorna algo especifico 
// en este en función del usuario

public class StubAuthenticator : IAuthenticator
{
    public bool Validate(string username, string password)
    {
        // NUNCA haga esto en la vida real
        if (username == "gaston" && password == "1234")
            return true;
        return false;
    }
}
