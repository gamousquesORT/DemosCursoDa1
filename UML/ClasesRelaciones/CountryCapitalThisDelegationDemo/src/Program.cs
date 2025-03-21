using System;
namespace CapitalCountryThisDelegationDemo;

public class Program
{
    private static void Main(string[] args)
    {
        try
        {
            var uy = new Country("Uruguay", "Montevideo");

            Console.WriteLine($"\nPreguntando al pais sus datos --> Pais: {uy.Name}\n");

            //Le podemos pedir al pais su capital
            Console.WriteLine($"Capital {uy.CapitalName} ");
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine($"Upps algo salió mal:{ex.Message}");
        }
    }
}