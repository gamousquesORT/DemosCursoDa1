// namespace donde esta el código de doble
using DummyTests.Double;

// namespace donde esta el código en producción
using Doubles.Domain;

namespace DoubleTests.DummyTests
{
    [TestClass]
    public class DummyLoginTests
    {
        [TestMethod]
        public void TestShouldLoginGivenValidCredentials()
        {
            UserController userController = new UserController();
            
            //ver que se utiliza el double para llamar a la authenticator
            IAuthenticator authenticator = new DummyAuthenticator();
            
            //IAuthenticator authenticator = new DummyAuthenticator();
            bool result = userController.Login("gaston", "1234", authenticator);

            Assert.AreEqual(false, result);
        }
    }
}