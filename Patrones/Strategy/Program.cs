namespace Strategy.Domain;

class Program
{
    
    static void Main(string[] args)
    {
        IPais us = new USA();
        IPais uy = new Uruguay();

        Compra c = new Compra() {Total = 100, Pais = uy};
        Console.WriteLine($"Impuestos en UY: {c.CalcularImpuestos()}");

        c.Pais = us;
        Console.WriteLine($"Impuestos en USA: {c.CalcularImpuestos()}");

        Console.ReadLine();

    }
}