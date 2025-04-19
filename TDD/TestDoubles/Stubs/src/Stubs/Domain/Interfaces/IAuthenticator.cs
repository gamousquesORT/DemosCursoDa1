namespace Stubs.Domain.Interfaces
{
    public interface IAuthenticator
    {
        public bool Validate(string username, string password);
    }
}