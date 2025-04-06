using Doubles.Domain;
namespace DummyTests.Double
{
    public class DummyAuthenticator : IAuthenticator
    {
        public bool Validate(string username, string password)
        {
            return true;
        }
    }
}