using Stubs.Domain.Interfaces;
using Stubs.Domain.Util;
namespace Stubs.Domain;

public class Authenticator : IAuthenticator
{
    public bool Validate(string username, string password)
    {
        CredentialManager credential = new CredentialManager();
        return credential.Validate(username, password);
    }
}