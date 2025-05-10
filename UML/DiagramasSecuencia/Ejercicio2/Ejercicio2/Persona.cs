namespace Ejercicio2;

public class Persona
{
    private Direccion _direccion = new Direccion();
    public string Numero { set; get; }
    public string NombreApellido { set; get; }

    public string Calle
    {
        set => _direccion.Calle = value;
        get => _direccion.Calle;
    }
    public string NumeroCalle
    {
        set => _direccion.Numero = value;
        get => _direccion.Numero;
    }

    public void ImprimirDatos()
    {
        Console.WriteLine($"Numero: {Numero}\n NombreApellido: {NombreApellido}\n Calle: {Calle}\n NumeroCalle: {NumeroCalle}");
    }
}