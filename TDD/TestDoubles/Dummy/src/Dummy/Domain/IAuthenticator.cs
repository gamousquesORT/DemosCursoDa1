namespace Dummy.Domain
{
    public interface IAuthenticator
    {
        public bool Validate(string username, string password);
    }
}