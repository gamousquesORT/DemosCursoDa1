using Dummy.Domain;

namespace DummyTests.Helpers;

public class DummyAuthenticator : IAuthenticator
{
    public bool Validate(string username, string password)
    {
        return true;
    }
}
