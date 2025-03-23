namespace ClaseAbstracta;

public abstract class Persona
{
    public string? Nombre { get; set; }
    public abstract void ImrimirDescripcion();
    public virtual void ImprimirNombre()
    {
        Console.WriteLine($"Nombre: {Nombre}");
    }

    public void MetodoSinEnlaceDinamico()
    {
        Console.WriteLine("Método sin enlace dinámico definido en Persona");
    }
}