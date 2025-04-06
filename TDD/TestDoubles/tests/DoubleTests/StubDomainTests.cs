// namespace donde está el código de Stub
using DummyTests.StubTests;

// namespace donde esta el código en producción
using Doubles.Domain;

namespace DoubleTests.DummyTests;

[TestClass]
public class StubDomainTests
{

    [TestMethod]
    public void TestShouldLoginGivenValidCredentials()
    {
        UserController userController = new UserController();
        
        // se crea un authenticator stub
        IAuthenticator authenticator = new StubAuthenticator();
        bool result = userController.Login("gaston", "1234", authenticator);

        Assert.AreEqual(true, result);
    }
}