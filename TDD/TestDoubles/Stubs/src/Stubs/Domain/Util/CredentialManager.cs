namespace Stubs.Domain.Util;

// NUNCA HAGAS ESTO EN UN PROYECTO REAL
public class CredentialManager
{
    public Dictionary<string, string> Credentials { get; set; }
    
    public CredentialManager()
    {
        Credentials = new Dictionary<string, string>();
        Credentials.Add("admin", "admin");
        Credentials.Add("user", "user");
        Credentials.Add("gaston", "1234");
    }

    public bool Validate(string username, string password)
    {
        if (Credentials.ContainsKey(username) && Credentials[username] == password)
            return true;
        return false;
    }
}