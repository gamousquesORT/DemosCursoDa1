using DepoDominio;

namespace TestDeposito;

/*
 * Ejemplo uso DataRow
 *  este mecanismo permite probar varios casos inyectando datos a un testmethod
 * 
 * ATENCION - esto es un ejemplo, no es parte del obligatorio. En el mismo tenemos el
 * 
 *      SUT - que es la clase Deposti
 *      Colaboradores - Promotion la cual tiene un descuento
 *      Climatización - una flag para indicar si tiene climatización
 *
 * lo que estamos usando es algo similar a clases de equivalencia (si un test pasa el equivalente tambien) en este caso
 * son los test para casos válidos y los test para casos bordes
 * 
 */
[TestClass]
public class DepositTest
{
    private Deposit deposit; 
    [TestInitialize]
    public void InitializeEmptyDeposit()
    {
        deposit = new Deposit();
    }
    
    [TestMethod]
    [DataRow(50, 6, true, 20, 260)] // sizePrice = 50, Days <7, Climtatization = true, promotion = {20}, price = 260
    [DataRow(50, 8, true, 10, 360)] // sizePrice = 50, Days > 7, Climtatization = true, promotion = {10}, price = 360
    [DataRow(20, 1, true, 20, 36)] // sizePrice = 50, Days > 7, Climtatization = true, promotion = {10}, price = 3
    // otros casos validos
    public void ShouldReturnCorrectPriceGivenValidSizepriceNumberOfDaysSupplementAndPromotions(float sizePrice, int days, bool climatization, float promotion, float expectedPrice)
    {
        // arrange
        deposit.SizePrice = sizePrice;
        deposit.Days = days;
        deposit.Climatization = climatization;
        
        //create collaborator
        deposit.Promotion = new Promotion { PromotionName = "Verano", PromotionDiscount = promotion};
        
        //Act
        float actual = deposit.ComputePrice();
        
        Assert.AreEqual(expectedPrice, actual );
        
    }
    
    
    [TestMethod]
 //   [ExpectedException(typeof(ArgumentException))]
    [DataRow(50, -1, true, 20, "Error: Days should be greater than 1")] // sizePrice = 50, Days -1, Climtatization = true, promotion = {20}
    [DataRow(50, 0, false, 20, "Error: Days should be greater than 1")] // sizePrice = 50, Days 0 7, Climtatization = true, promotion = {20}
    [DataRow(50, 7, true, -20, "Error: Invalid promotion discount")] // sizePrice = 50, Days -1, Climtatization = true, promotion = {-20}
    // otros casos validos
    public void ShouldThrowArgumentExceptionWithCorrectMessageGivenValidSizepriceNumberOfDaysSupplementAndPromotions(float sizePrice, int days, bool climatization, float promotion, string exceptionMessage)
    {
        // arrange
        deposit.SizePrice = sizePrice;
        deposit.Days = days;
        deposit.Climatization = climatization;
        
        //create collaborator
        deposit.Promotion = new Promotion { PromotionName = "Verano", PromotionDiscount = promotion};
        
        //Act
        var exc = Assert.ThrowsException<ArgumentException>(() => deposit.ComputePrice());
        Assert.AreEqual(exceptionMessage, exc.Message);
    }
}

