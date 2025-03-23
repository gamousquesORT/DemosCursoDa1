namespace ClaseAbstracta;

public class EmpleadoDiario : Empleado
{
    public decimal SalarioDiario { get; set; }
    
    public override void ImrimirDescripcion()
    {
        Console.WriteLine($"Número de Empleado: {NumeroEmpleado}");
    }
    public override void ImprimirNombre()
    {
        Console.WriteLine($"Nombre: {Nombre}");
    }
}