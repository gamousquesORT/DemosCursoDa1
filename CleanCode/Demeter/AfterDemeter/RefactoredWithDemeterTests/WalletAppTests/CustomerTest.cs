namespace WalletCoupledDesignTest;
using  RefactoredWithDemeter;

[TestClass]
public class CustomerTest
{
    [TestMethod]
    public void ShouldReturnTrueGivenEnoughMoney()
    {
        // Arrange
        Commerce store = new Commerce();
        
        Customer customer = new Customer();
        customer.AddMoney( 200);
        decimal amount = 100;

        //act
        bool result = customer.Pay(amount);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ShouldThrowArgumentExceptionGivenInsufficientFunds()
    {
        // Arrange
        Commerce store = new Commerce();
        Customer customer = new Customer();
        customer.AddMoney(50);

        // Assert
        Assert.ThrowsException<ArgumentException>(() => customer.Pay(100));
        
    }
}
