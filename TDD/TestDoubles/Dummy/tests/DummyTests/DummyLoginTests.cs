// namespace donde esta el código de doble

// namespace donde esta el código en producción
using Dummy.Domain;
using DummyTests.Helpers;

namespace DoubleTests.DummyTests
{
    [TestClass]
    public class DummyLoginTests
    {
        [TestMethod]
        public void TestShouldLoginGivenValidCredentials()
        {
            UserController userController = new UserController();
            
            //ver que se utiliza el dummy para llamar a la authenticator
            // DummyAuthenticator es porque a futuro voy a tener un autenticator real
            // mientras no esté uso el Doble dummy
            IAuthenticator authenticator = new DummyAuthenticator();
            
            //IAuthenticator authenticator = new DummyAuthenticator();
            bool result = userController.Login("gaston", "1234", authenticator);

            Assert.AreEqual(true, result);
        }
    }
}