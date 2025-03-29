using NameSpaceAppBackend.Domain;

namespace NameSpaceAppBackEnd.Controllers;

public class UserCtrl
{
    List<User> _users = new List<User>();
    
    public void CreateUser(string name)
    {
        _users.Add(new User());
    }
    
}