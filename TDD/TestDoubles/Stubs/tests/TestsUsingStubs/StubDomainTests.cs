// namespace donde está el código de Helpers
using DummyTests.StubTests;

// namespace donde esta el código en producción
using Stubs.Domain;
using Stubs.Domain.Interfaces;

namespace TestsUsingStubs.DummyTests;

[TestClass]
public class StubDomainTests
{

    [TestMethod]
    public void TestShouldReturnTrueGivenValidCredentials()
    {
        UserController userController = new UserController();
        
        // se crea un authenticator stub que va a retornar true
        IAuthenticator authenticator = new StubAuthenticator();
        bool result = userController.Login("gaston", "1234", authenticator);

        Assert.AreEqual(true, result);
    }
    
    [TestMethod]
    public void TestShouldReturnFalseGivenInvalidCredential()
    {
        UserController userController = new UserController();
        
        // se crea un authenticator stub que va a retornar false
        IAuthenticator authenticator = new StubAuthenticator();
        bool result = userController.Login("gaston", "14", authenticator);

        Assert.AreEqual(false, result);
    }
}