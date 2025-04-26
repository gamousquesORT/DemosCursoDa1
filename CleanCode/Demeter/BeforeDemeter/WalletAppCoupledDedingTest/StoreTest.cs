namespace WalletCoupledDesignTest;
using WalletAppDomain;

[TestClass]
public class StoreTest
{
    [TestMethod]
    public void ShouldReturnTrueGivenEnoughMoney()
    {
        // Arrange
        Store store = new Store();
        Customer customer = new Customer();
        customer.Wallet.Money = 200;
        decimal amount = 100;

        //act
        bool result = store.Checkout(customer, amount);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ShouldThrowWalletExceptionGivenInsufficientFunds()
    {
        // Arrange
        Store store = new Store();
        Customer customer = new Customer();
        customer.Wallet.Money = 50;
        decimal amount = 100;

        // Assert
        Assert.ThrowsException<WalletException>(() => store.Checkout(customer, amount));
        
    }
}
