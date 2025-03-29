using NameSpaceAppBackEnd.Controllers;

namespace NameSpaceAppUI.Forms;

class Program
{
    static void Main(string[] args)
    {
        var userCtrl = new UserCtrl();
        userCtrl.CreateUser("John Doe");

    }
}