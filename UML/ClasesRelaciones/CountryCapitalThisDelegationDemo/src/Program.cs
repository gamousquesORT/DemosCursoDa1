using System;

namespace ejemplosClase;

internal class Program
{
    private static void Main(string[] args)
    {
        var uy = new Country("Uruguay", "Montevideo");
        Console.WriteLine("preguntando al pais los datos --> Pais: {0} Capital {1} ", uy.Name, uy.CapitalName);

        //Pedimos al pais su capital
        var capital = uy.Capital;
        Console.WriteLine("Capital {0} ", capital.Name);
    }
}