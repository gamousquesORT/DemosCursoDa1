namespace ClaseAbstracta;

public class Empleado : Persona
{
    public string? NumeroEmpleado { get; set; }
    
    public override void ImprimirDescripcion()
    {
        Console.WriteLine($"Número de Empleado: {NumeroEmpleado}");
    }
    public override void ImprimirNombre()
    {
        Console.WriteLine($"Nombre: {Nombre}");
    }
    
    public new void MetodoSinEnlaceDinamico()
    {
        Console.WriteLine($"Método sin enlace dinámico definido en Empleado - Clase {this.GetType()} ");
    }
    
}