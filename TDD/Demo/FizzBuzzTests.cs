/*
 * Reglas FizzBuzzLogic
 * Crear una que tenga un método que dado un número retorne:
        Fizz si el número es divisible por 3
        Buzz si el número es divisible por 5
        FizzBuzz si el número es divisible por 3 y 5
        Si el número no es divisible por 3 ni 5 retorna el número
        Si el número es negativo  retorna una excepcion de argumento invalido
        Si el número es mayor que 100 retorn una una excepcion de argumento invalido 


[TestClass]
public class TestFizzBuzz
{ 

   private FizzBuzz _fizzBuzz = new FizzBuzz();

   // --- Divisible por 3 únicamente → Fizz ---

   [TestMethod]
   public void WhenNumberIsDivisibleByThreeOnlyThenReturnFizz()
   {
       var result = _fizzFuzz.Convert(3);
       Assert.AreEqual("Fizz", result);
   }

   // --- Divisible por 5 únicamente → Buzz ---

   [TestMethod]
   public void WhenNumberIsDivisibleByFiveOnlyThenReturnBuzz()
   {
       var result = _fizzFuzz.Convert(5);
       Assert.AreEqual("Buzz", result);
   }

   // --- Divisible por 3 y 5 → FizzBuzz ---

   [TestMethod]
   public void WhenNumberIsDivisibleByThreeAndFiveThenReturnFizzBuzz()
   {
       var result = _fizzFuzz.Convert(15);
       Assert.AreEqual("FizzBuzz", result);
   }

   // --- No divisible por 3 ni 5 → retorna el número ---

   [TestMethod]
   public void WhenNumberIsNotDivisibleByThreeOrFiveThenReturnNumber()
   {
       var result = _fizzFuzz.Convert(7);
       Assert.AreEqual("7", result);
   }

   // --- Número negativo → lanza error ---

   [TestMethod]
   [ExpectedException(typeof(ArgumentException))]
   public void WhenNumberIsNegativeThenThrowArgumentException()
   {
       _fizzFuzz.Convert(-1);
   }

   [TestMethod]
   [ExpectedException(typeof(ArgumentException))]
   public void WhenNumberIsGreaterThanOneHundredThenThrowArgumentException()
   {
       _fizzFuzz.Convert(101);
   }

}
*/  
   
   